using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4
{
    [Table("State")]
    public class State
    {
        public int ID { get; set; }
        public string StateName { get; set; }    
        public int PlateNumber{ get; set; }
        
        [ForeignKey("City")]
        public int CityId { get; set; }
        
       public virtual City City{ get; set; }

    }
}
