using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LmycWeb.Models;
using Microsoft.AspNetCore.Identity;

namespace LmycWeb.Data
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            InitializeBoats(db);
            InitializeUsers(db, userManager);
        }

        public static void InitializeUsers(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {

            if (!db.Users.Any(u => u.UserName == "m@m.m"))
            {
                var user = new ApplicationUser
                {
                    UserName = "m@m.m",
                    Email = "m@m.m",
                    FirstName = "Ronno",
                    LastName = "Tran",
                    Street = "7777 Seven Ave",
                    City = "London",
                    Province = "BC",
                    PostalCode = "Y6T 5P9",
                    Country = "Canada",
                    MobileNumber = "604-002-5427",
                    SailingExperience = "Beginner"
                };

                userManager.CreateAsync(user, "P@$$w0rd");

                userManager.AddToRoleAsync(user, "Member");
            }
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
