using Model;

public class Test {

    public async Task FirstTest(ActivityContext context) {
        // ensure databse
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();

        // test
        context.Activities.Add(new Activity {
            Title = "Iterate on EF Core setup from scratch",
            Start = new DateTimeOffset(DateTime.Now)
        });

        await context.SaveChangesAsync();

        var activities = await context.Activities.ToListAsync();

        foreach (var activity in activities) {
            Console.WriteLine($"--- {activity.Title} ---");
            Console.WriteLine($" .  {activity.Start} ---");
        }

    }
}