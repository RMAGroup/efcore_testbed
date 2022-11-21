using Model;

// setup
// Build a config object, using env vars and JSON providers.
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.Development.json", false)
    .AddJsonFile("appsettings.json", true)
    .AddEnvironmentVariables()
    .Build();

var ConfigSettings = new ConfigSettings(config);
var appSetting = new AppSettings(ConfigSettings);
var context = new ActivityContext(appSetting.ActivityContextOptions);

// test
var test = new Test();
await test.FirstTest(context);

Console.WriteLine("done");

