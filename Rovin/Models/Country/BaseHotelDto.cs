using System.ComponentModel.DataAnnotations;

namespace rovin.Models.Country
{
    public abstract class BaseHotelDto
    {
       
            
            public string Name { get; set; }

       
            public string Address { get; set; }

            public double? Rating { get; set; }

     
            public int CountryId { get; set; }
        
    }
}