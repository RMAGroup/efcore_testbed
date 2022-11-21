using Model;

public class AppSettings {

    public DbContextOptions<ActivityContext> ActivityContextOptions;
    public AppSettings(ConfigSettings config) {

        // ActivityContextOptions
        var contextOptionsBuilder = new DbContextOptionsBuilder<ActivityContext>().UseSqlServer(config.ConnectionString);
        if (config.Enable_EFCore_Logging) {
            contextOptionsBuilder
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        ActivityContextOptions = contextOptionsBuilder.Options;
    }
}