using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LmycWeb.Models;

namespace LmycWeb.Data
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            //InitializeBoats(db);
        }

        public static void InitializeBoats(ApplicationDbContext db)
        {
            if (!db.Boat.Any())
            {
                List<Boat> boats = new List<Boat>()
                {
                    new Boat()
                    {
                        BoatName = "S.S. Wave",
                        LengthInFeet = 35.21,
                        Make = "Cruiser Yachts",
                        Year = 2005,
                        RecordCreationDate = Convert.ToDateTime("2010-03-24")
                    },
                    new Boat()
                    {
                        BoatName = "Lady Luck",
                        LengthInFeet = 37.19,
                        Make = "Hunton Yachts",
                        Year = 2011,
                        RecordCreationDate = Convert.ToDateTime("2013-09-12")
                    },
                    new Boat()
                    {
                        BoatName = "Captain Sea",
                        LengthInFeet = 40.12,
                        Make = "MasterCraft",
                        Year = 2008,
                        RecordCreationDate = Convert.ToDateTime("2011-10-02")
                    },
                    new Boat()
                    {
                        BoatName = "Anchorage Scourge",
                        LengthInFeet = 42.18,
                        Make = "Sunseeker",
                        Year = 2009,
                        RecordCreationDate = Convert.ToDateTime("2011-11-09")
                    },
                };

                db.Boat.AddRange(boats);
                db.SaveChanges();
            }
        }
    }
}
