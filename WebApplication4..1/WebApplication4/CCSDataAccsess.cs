
using Microsoft.EntityFrameworkCore;


namespace WebApplication4
{
    public class CCSDataAccsess : DbContext 
    {
        public CCSDataAccsess()
        {
        }

        public CCSDataAccsess(DbContextOptions<CCSDataAccsess>options):base(options)
        {
         
        }

       


        


        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
       public DbSet<User_Table> user_Tables { get; set; }

    }
}
