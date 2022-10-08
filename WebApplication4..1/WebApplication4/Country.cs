using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4
{
    [Table("Country")]                           
    public class Country
    {
        public int ID { get; set; } 
        public string CountryName { get; set; }
        
        
    }
}
