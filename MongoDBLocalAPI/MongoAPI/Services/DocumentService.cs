using MongoAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MongoAPI.Services
{
    public class DocumentService
    {
        private readonly IMongoCollection<Documents> documents;

        public DocumentService(IDocumentsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            documents = database.GetCollection<Documents>(settings.DocumentsCollectionName);
        }

        public List<ServeDocument> Get()
        {
            var DocList = documents.Find(document => true).ToList();
            List<ServeDocument> MyRetList = new List<ServeDocument>();
            foreach(Documents doc in DocList)
            {
                byte[] file = Convert.FromBase64String(doc.Document);
                MyRetList.Add(new ServeDocument { DocName = doc.DocumentName, Id = doc.Id, file = file });
            }
            return MyRetList;
        }


        public ServeDocument Get(string id)
        {
            var document = documents.Find<Documents>(document => document.Id == id).FirstOrDefault();
            //byte[] file = Convert.FromBase64String(MyDocument.Document);
            //return new ServeDocument { DocName = MyDocument.DocumentName, Id = MyDocument.Id, file = file };


            string docid = document.Id;
            byte[] buffer = new byte[0];

            //generate pdf document
            MemoryStream memoryStream = new MemoryStream();
            MyPDFGenerator.New().PrintToStream(document, memoryStream);

            //get buffer
            buffer = memoryStream.ToArray();

            //content length for use in header
            var contentLength = buffer.Length;

            //200
            //successful
            var statuscode = HttpStatusCode.OK;

            response = Request.CreateResponse(statuscode);
            response.Content = new StreamContent(new MemoryStream(buffer));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
            response.Content.Headers.ContentLength = contentLength;
            ContentDispositionHeaderValue contentDisposition = null;
            if (ContentDispositionHeaderValue.TryParse("inline; filename=" + document.DocumentName + ".pdf", out contentDisposition))
            {
                response.Content.Headers.ContentDisposition = contentDisposition;
            }
        }

        public Documents Create(Documents document)
        {
            documents.InsertOne(document);
            return document;
        }

        public void Update(string id, Documents DocumentIn) =>
            documents.ReplaceOne(document => document.Id == id, DocumentIn);

        public void Remove(Documents DocumentIn) =>
            documents.DeleteOne(document => document.Id == DocumentIn.Id);

        public void Remove(string id) =>
            documents.DeleteOne(document => document.Id == id);
    }
}
