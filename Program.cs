using System;
using System.Data;
using System.Dynamic;
using Dapper;
using Microsoft.Data.SqlClient;
using MyApp.Models;

namespace MyApp
{
    internal class Program
    {

             
        public  static void Main(string[] args)
        {
            Computer lenovo = new Computer()
            { 
                Motherboard="Lenovo",
                Price=99.99m,
                ReleaseDate=DateTime.Now,
                HasLTE=true,
                HasWifi=true,
                VideoCard = "asdfd"

            };
            // System.Console.WriteLine(lenovo.VideoCard);
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
            // Mac and linux Connection String
            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sumit;Password=SQLConnect1";
            IDbConnection dbConnection =new SqlConnection(connectionString);
            string sqlCommand = "SELECT GETDATE()";
            DateTime rightNow=  dbConnection.QuerySingle<DateTime>(sqlCommand);
            System.Console.WriteLine(rightNow);


            string sql = @"INSERT INTO TutorialAppSchema.Computer (
                     Motherboard,
                     Price,
                     ReleaseDate,
                     HasLTE,
                     HasWifi,
                     VideoCard,   
                     CPUCores          
            )   
                    VALUES ('"+lenovo.Motherboard
                            +"','"+lenovo.Price
                            +"','"+lenovo.ReleaseDate
                            +"','"+lenovo.HasLTE
                            +"','"+lenovo.HasWifi
                            +"','"+lenovo.VideoCard
                            +"','2')";


            // int result=dbConnection.Execute(sql);                
            // System.Console.WriteLine(@"Number of rows '"+result+"'");

            string sqlSelect = @"Select * FROM TutorialAppSchema.Computer";
            // dapper reutnr IEnumrables 
           IEnumerable<Computer> computers= dbConnection.Query<Computer>(sqlSelect);
            System.Console.WriteLine("CPUCORS, MotherBoard HASLTE,  HAS WIFI, VIDEOCARD"); 
           foreach (Computer item in computers)

           {
        Console.WriteLine(item.CPUCores+item.Motherboard+item.HasLTE+item.HasWifi+item.VideoCard);
         
           }
        }
    }
}