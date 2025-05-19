using System.Threading.Tasks;
using ElectricalBikeProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectricalBikeProject.Controllers;

[Route("dev-test")]
public class DevTestController : ControllerBase
{
    private readonly BikeRecordService _bikeRecordService;

    public DevTestController(BikeRecordService bikeRecordService)
    {
        _bikeRecordService = bikeRecordService;
    }
    [HttpGet]
    [Route("good")]
    public async Task<ActionResult> DevTest()
    {
        var result = await _bikeRecordService.GetBike();
        return Ok(result);
    }
}