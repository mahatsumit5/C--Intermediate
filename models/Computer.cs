// to use namespace start with app name with folder name see the example below

namespace MyApp.Models 
{
  public class Computer 
        {

            // one way
            // private string _motherboard; this is a field starts with lowercase and ends with ;.

            // this is property it has getter and setter that returns and assigns value to the fields.
            // private string Motherboard { get { return _motherboard; } set { _motherboard = value; }} 

            // Second approach
            // In Simple Approach the above can be written as 
            // this will create a field name _motherboard for us and sets the value.
            // this is a attributes it has uppercase and does not have colon ";".
            public string Motherboard { get; set; } = "";
            public int ComputerId { get; set; }
            public int CPUCores { get; set; } 
            public bool HasWifi { get; set; } 
            public bool HasLTE { get; set; } 

            public DateTime ReleaseDate { get; set; } 

            public decimal Price { get; set; }

            public string VideoCard { get; set; } = "";
         
     }
}