using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication4

{
    public class User_Table
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string E_Mail { get; set; }
        //[ForeignKey("State")]
        //public int StateId { get; set; }
        

        //[ForeignKey("City")]
        //public int CityId { get; set; }

      

        //[ForeignKey("Country")]
        //public int CountryID { get; set; }
        
        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
        public virtual State State  { get; set; }
    }
}