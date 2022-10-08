using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace WebApplication4
{
    public static class DataBaseSeed
    {
        public static void Seed(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context is CCSDataAccsess)
                {
                    CCSDataAccsess _context = context as CCSDataAccsess;
                    var A = _context.Countries.Count();
                    //if (_context.Countries.Count() == 0)
                    //{
                    //    _context.Countries.AddRangeAsync(countries);
                    //}

                    //if (_context.Cities.Count() == 0)
                    //{
                    // _context.Cities.AddRange(cities);
                    //}
                    //if (_context.States.Count() == 0)
                    //{
                    //    _context.States.AddRange(states);
                    //    }



                        context.SaveChanges();

                }
            }


            

        }


        private static Country[] countries =
        {

            new Country(){CountryName ="Türkiye"}
            
        };
        private static City[] cities =
       {
            new City(){CityName = "Ankara",CountryID=2},
            new City(){CityName = "Istanbul",CountryID=2},
            new City(){CityName = "Izmir",CountryID=2},
            new City(){CityName = "Trabzon",CountryID=2},
            new City(){CityName = "Antalya",CountryID=2},


        };

        private static State[] states =
        {
            new State(){StateName = "Sincan",PlateNumber = 06,CityId = 4},
            new State(){StateName = "Cankaya",PlateNumber = 06,CityId = 4},
            new State(){StateName = "Yenidogan",PlateNumber = 06,CityId = 4},
            new State(){StateName = "Etimesgut",PlateNumber = 06,CityId = 4},

            new State(){StateName = "Besiktas",PlateNumber = 34,CityId = 5},
            new State(){StateName = "Kadikoy",PlateNumber = 34,CityId = 5},



            new State(){StateName = "Karsıyaka",PlateNumber = 35,CityId = 6},
            new State(){StateName = "Goztepe",PlateNumber = 35,CityId = 6},

            new State(){StateName = "Akcaabat",PlateNumber = 35,CityId = 7},

            new State(){StateName = "Akseki",PlateNumber = 07,CityId = 8},
            new State(){StateName = "Manavgat",PlateNumber = 07,CityId = 8},
            new State(){StateName = "Kepez",PlateNumber = 07,CityId = 8},
        };
    }
}
