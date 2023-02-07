using booksapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SQLite;

namespace booksapi.Data
{

    public class BookContext : DbContext
    {
        SQLiteConnection con;

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
            string cs = @"URI=/Users/archermorgan/Documents/personalProjects/SelfTeachIteration1/apiservice/selfteachIt1.db";
            con = new SQLiteConnection(cs);
            con.Open();
        }

        public bool CreateNewBook(Book book)
        {

            //try to add book to books table
            //if successful, try to add sections
            //if successful, try to add problems

            return true; // todo salió bien
        }

        public Book GetBook(string title) {
            return new Book();
        }

        // update completion status of a Problem
        public bool UpdateProblem() {
            return true;
        }

        // update completion status of a Problem
        public bool UpdateSection() {
            return true;
        }


        // Purely for development purposes -- to make sure we can connect to the database
        public bool TestConnection()
        {
            Console.WriteLine("got here");
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS cars";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY,
                    name TEXT, price INT)";
            cmd.ExecuteNonQuery();

            return (cmd.ExecuteNonQuery() > 0);
        }
    }
}