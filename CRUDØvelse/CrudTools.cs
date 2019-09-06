using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace CRUDØvelse
{
    class CrudTools
    {
        //(localdb)\MSSQLLocalDB
        string ConnectionString;
        SqlConnection Connection;


        public CrudTools(string ServerName, string DBName)
        {
            ConnectionString = $@"Data Source={ServerName};Initial Catalog={DBName};Integrated Security=True;";
            Connection = new SqlConnection(ConnectionString);
        }


        string Create = @"INSERT INTO People (Name, BirthYear, Age, Mother, Father) VALUES (@Name, @BirthYear, @Age, @Mother, @Father)";
        string ReadAll = @"SELECT * FROM People";
        string PrintPersonID = @"Select * from People where ID = @ID";
        string PrintPersonName = @"Select * from People where Name = @Name";
        string EraseAll = @"delete from People";
        string EraseID = @"delete * from People where ID = @ID";
        string UpdateRow = @"update People set Name = @Name, BirthYear = @BirthYear, Age = @Age, Mother = @Mother, Father = @Father where ID = @ID";


        public async Task DeleteAll()
        {
            await Connection.ExecuteAsync(EraseAll);
        }

        public async Task DeleteID(int id)
        {
            await Connection.ExecuteAsync(EraseID, new { ID = id });
        }

        public async Task<int> Insert(string name, int birthyear, int age, string mother, string father)
        {
            return await Connection.ExecuteAsync(Create, new { Name = name, BirthYear = birthyear, Age = age, Mother = mother, Father = father });
        }

        public async Task<Person> GetPersonID(int id)
        {
           return await Connection.QueryFirstOrDefaultAsync<Person>(PrintPersonID, new { ID = id });
        }

        public async Task<Person> GetPersonName(string name)
        {
            return await Connection.QueryFirstOrDefaultAsync<Person>(PrintPersonName, new { Name = name });
        }

        public async Task Update(int id, string name, int birthyear, int age, string mother, string father)
        {
            await Connection.ExecuteAsync(UpdateRow, new { Name = name, BirthYear = birthyear, Age = age, Mother = mother, Father = father });
        }

        public async Task ShowAll()
        {
            IEnumerable<Person> Personer = await Connection.QueryAsync<Person>(ReadAll);

            foreach (Person person in Personer)
            {
                person.Show();
            }
        }
    }
}
