namespace Model;
public class ActivityContext : DbContext {

    public DbSet<Activity> Activities => Set<Activity>();


    public ActivityContext() {}
    public ActivityContext(DbContextOptions options) : base(options) {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        var activity = modelBuilder.Entity<Activity>();
        activity.HasKey(t => t.Id);
        activity.Property(t => t.Id).ValueGeneratedOnAdd();
        activity.Property(t => t.Title).HasMaxLength(200);
        activity.HasIndex(t => t.Title);
        activity.HasIndex(t => new { t.Start, t.End });
        activity.HasIndex(t => t.DurationMinutes);
        activity.HasIndex(t => t.CreatedAt);
    }
    
}