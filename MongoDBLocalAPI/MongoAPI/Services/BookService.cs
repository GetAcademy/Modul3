using MongoAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoAPI.Services
{
    public class BookService
    {
        private readonly IMongoCollection<Book> documents;

        public BookService(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            documents = database.GetCollection<Book>(settings.BooksCollectionName);
        }

        public List<Book> Get() =>
            documents.Find(book => true).ToList();

        public Book Get(string id) =>
            documents.Find<Book>(book => book.Id == id).FirstOrDefault();

        public Book Create(Book book)
        {
            documents.InsertOne(book);
            return book;
        }

        public void Update(string id, Book bookIn) =>
            documents.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Book bookIn) =>
            documents.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            documents.DeleteOne(book => book.Id == id);
    }
}
