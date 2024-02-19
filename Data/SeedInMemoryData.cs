using AssessmentUserInterface.Models;
using System;

namespace AssessmentUserInterface.Data
{
    public static class SeedInMemoryData
    {
        public static async Task InitializeAsync(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Hastings",
                        EmailAddress = "jhastings@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(1),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(10),
                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "Sam",
                        LastName = "Galloway",
                        EmailAddress = "sgalloway@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(2),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(11),
                    },
                    new User
                    {
                        Id = 3,
                        FirstName = "Mary",
                        LastName = "Smith",
                        EmailAddress = "msmith@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(3),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(12),
                    },
                    new User
                    {
                        Id = 4,
                        FirstName = "Sara",
                        LastName = "Longway",
                        EmailAddress = "slongway@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(4),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(13),
                    },
                    new User
                    {
                        Id = 5,
                        FirstName = "Mike",
                        LastName = "Maddox",
                        EmailAddress = "mmaddox@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(5),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(14),
                    },
                    new User
                    {
                        Id = 6,
                        FirstName = "Selena",
                        LastName = "Kaine",
                        EmailAddress = "skaine@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(6),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(15),
                    },
                    new User
                    {
                        Id = 7,
                        FirstName = "Atropos",
                        LastName = "stewart",
                        EmailAddress = "astewart@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(7),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(16),
                    },
                    new User
                    {
                        Id = 8,
                        FirstName = "Vriek",
                        LastName = "Vorpal",
                        EmailAddress = "vvorpal@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(8),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(17),
                    },
                    new User
                    {
                        Id = 9,
                        FirstName = "Keith",
                        LastName = "Panatone",
                        EmailAddress = "kpanatone@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(9),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(18),
                    },
                    new User
                    {
                        Id = 10,
                        FirstName = "Olga",
                        LastName = "Ingot",
                        EmailAddress = "oingot@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(10),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(19),
                    },
                    new User
                    {
                        Id = 11,
                        FirstName = "Richard",
                        LastName = "Radigon",
                        EmailAddress = "rradigon@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(11),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(20),
                    },
                    new User
                    {
                        Id = 12,
                        FirstName = "Stewart",
                        LastName = "Bennings",
                        EmailAddress = "sbennings@company.com",
                        DateCreated = DateTime.Now + TimeSpan.FromDays(12),
                        DateUpdated = DateTime.Now + TimeSpan.FromDays(21),
                    },
                };
                context.Users.AddRange(users);
                await context.SaveChangesAsync();
            }
        }
    }
}
