namespace Model;

public class Activity : EntityBase {
    public string Title { get; set; } = "";
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? End { get; set; }
    public int? DurationMinutes { get; set; }
}