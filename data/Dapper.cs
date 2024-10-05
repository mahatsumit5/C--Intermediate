using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using MyApp.Models;
// string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
 // Mac and linux Connection String
  // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sumit;Password=SQLConnect1";
    // IDbConnection dbConnection =new SqlConnection(connectionString);
namespace MyApp.data 
{

    public class DataContextDapper 
    {
         private readonly string _connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";

        public IEnumerable<T>LoadData<T>(string sql)
        {
            IDbConnection dbConnection =new SqlConnection(_connectionString);        
            return  dbConnection.Query<T>(sql);           
        }

          public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection =new SqlConnection(_connectionString);        
            return  dbConnection.QuerySingle<T>(sql);           
        }
          public bool ExecuteQuery(string sql)
        {
            IDbConnection dbConnection =new SqlConnection(_connectionString);
            return dbConnection.Execute(sql) > 0;         
        }
          public int ExecuteQueryWithRowCount(string sql)
        {
            IDbConnection dbConnection =new SqlConnection(_connectionString);
            return dbConnection.Execute(sql);        
        }

    }
}