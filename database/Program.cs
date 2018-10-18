using System;
using System.Collections.Generic;
using DbConnection;

namespace database
{
    class Program
    {

        static void ShowAll(){
            // DbConnector.Execute("INSERT INTO user (FirstName, LastName, FavoriteNumber)VALUES('Habiba', 'Mohamed', 10)");
            List<Dictionary<string, object>> result = DbConnector.Query("SELECT FirstName, LastName, FavoriteNumber FROM user");
            foreach (var item in result)
                System.Console.WriteLine(item["FirstName"] + "" + item["LastName"] + "" + item["FavoriteNumber"]);
            {
                
            }
            // List<Dictionary<string, object>> Query(string queryString)
        }

        static void Create() {
            Console.WriteLine("Please input your name");
            string FirstName = Console.ReadLine();
            // Console.WriteLine(FirstName);

            Console.WriteLine("Please input your last name");
            string LastName = Console.ReadLine();
            // Console.WriteLine(LastName);

            Console.WriteLine("Please input your number");
            string FavoriteNumber = Console.ReadLine();
            // Console.WriteLine(FavoriteNumber);

            List<Dictionary<string, object>> result = DbConnector.Query($"INSERT INTO user(FirstName, LastName, FavoriteNumber)VALUES('{FirstName}', '{LastName}', {FavoriteNumber})");

        }

        static void ShowOne(string id) {
            List<Dictionary<string, object>> result = DbConnector.Query($"SELECT FirstName, LastName, FavoriteNumber FROM user WHERE id = {id}");
            foreach (var item in result)
            {
                System.Console.WriteLine(item["FirstName"] + "" + item["LastName"] + "" + item["FavoriteNumber"]);
            }    
        }

        static void Delete(string id) {
            List<Dictionary<string, object>> result = DbConnector.Query($"DELETE FROM user WHERE id = {id}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShowAll();
            Create();
            Delete("3");
            Delete("4");
            Delete("5");
            Delete("6");
            Delete("7");
            Delete("8");
            Delete("9");
            Delete("10");
        }
    }
}
