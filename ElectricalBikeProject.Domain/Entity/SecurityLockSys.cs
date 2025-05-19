namespace ElectricalBikeProject.Domain.Entity;

public class SecurityLockSys
{
    public Guid Id { get; set; }
    public string RfidCredential { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public Guid? LastBikeUsed { get; set; }
    public DateTime? LastActiveTimestamp { get; set; }
    public DateTime CreatedTimestamp { get; set; }
    public bool IsMember { get; set; } = false;
    public double Mileage { get; set; } = 0;
}