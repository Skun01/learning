namespace Domain.Entities;

public class BaseEntity
{
    public string Id {set; get; } = null!;
    public DateTime CreatedAt { set; get; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { set; get; }
}
