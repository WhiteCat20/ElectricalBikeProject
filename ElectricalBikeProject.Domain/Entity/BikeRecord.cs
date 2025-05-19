namespace ElectricalBikeProject.Domain.Entity;

public class BikeRecord
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int LastSocValue { get; set; } = 100;
    public DateTime LastUsedTimestamp { get; set; }
    public DateTime CreatedTimestamp { get; set; }
    public string? BikeUsageHistory { get; set; }
    public bool ChargingStatus { get; set; } = false;
}