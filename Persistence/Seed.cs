using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 Month ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 Month ago",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 Month in future",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 Month in future",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 Month in future",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 Month in future",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 Month in future",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 Month in future",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                }
            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}
