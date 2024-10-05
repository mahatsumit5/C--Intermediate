using MyApp.data;
using MyApp.Models;

namespace MyApp
{
    internal class Program
    {

             
      static void Main(string[] args)
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
            DataContextDapper dapper = new DataContextDapper();
            string sqlCommand = "SELECT GETDATE()";
            DateTime rightNow=  dapper.LoadDataSingle<DateTime>(sqlCommand);
            Console.WriteLine(rightNow);


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


            bool result=dapper.ExecuteQuery(sql);                
            Console.WriteLine(@"Number of rows "+result+"");

            string sqlSelect = @"Select * FROM TutorialAppSchema.Computer";
            // dapper reutnr IEnumrables 
           IEnumerable<Computer> computers= dapper.LoadData<Computer>(sqlSelect);
            System.Console.WriteLine("CPUCORS, MotherBoard HASLTE,  HAS WIFI, VIDEOCARD"); 
           foreach (Computer item in computers)
            {
             Console.WriteLine(item.CPUCores+item.Motherboard+item.HasLTE+item.HasWifi+item.VideoCard);
            }
         }
    }
}