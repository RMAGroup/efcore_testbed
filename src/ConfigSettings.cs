public class ConfigSettings {
    public string ConnectionString { get; set; } = "";
    public bool Enable_EFCore_Logging { get; set; }

    public ConfigSettings(IConfiguration config) {
                ConnectionString = config["ConnectionStrings:Default"] ?? "";

        Enable_EFCore_Logging = config["Enable_EFCore_Logging"] != null
            ? bool.Parse(config["Enable_EFCore_Logging"] ?? "false")
            : false;

    }

}