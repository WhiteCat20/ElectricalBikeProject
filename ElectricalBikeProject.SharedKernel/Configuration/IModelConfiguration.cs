using Microsoft.EntityFrameworkCore;

namespace ElectricalBikeProject.SharedKernel.Configuration;

public interface IModelConfiguration
{
    void Configure(ModelBuilder builder);
}