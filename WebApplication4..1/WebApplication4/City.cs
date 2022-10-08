using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4
{
    [Table("City")]
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public virtual Country country { get; set; }


    }
}
