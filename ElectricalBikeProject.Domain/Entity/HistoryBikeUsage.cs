namespace ElectricalBikeProject.Domain.Entity;

public class HistoryBikeUsage
{
    public Guid Id { get; set; }
    public Guid BikeRecordId { get; set; }
    public DateTime StartTimestamp { get; set; }
    public DateTime FinishTimestamp { get; set; }
    public DateTime CreatedTimestamp { get; set; }
}