using System;
using System.Dynamic;
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
            System.Console.WriteLine(lenovo.VideoCard);
        }
    }
}