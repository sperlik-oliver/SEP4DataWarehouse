using Microsoft.AspNetCore.Mvc;
using SEP4DataWarehouse.DTO.DwDTO;
using SEP4DataWarehouse.Services.DwServices.Interfaces;
using SEP4DataWarehouse.Utilities;

namespace SEP4DataWarehouse.Controllers.DwControllers;

[Route("api/[Controller]")]
public class DimLightController : ControllerBase {
    private readonly IDimLight _DimLightService;
    private readonly IExceptionUtilityService _exceptionUtility;

    public DimLightController(IDimLight dimLightService, IExceptionUtilityService exceptionUtility) {
        _DimLightService = dimLightService;
        _exceptionUtility = exceptionUtility;
    }


    [HttpGet]
    public async Task<ActionResult<float>> GetLightAverage(string boardId, DateTime timeFrom, DateTime timeTo) {
        try {
            var lightAverage = await _DimLightService.GetLightAverage(boardId, timeFrom, timeTo);
            return Ok(lightAverage);
        }
        catch (Exception e) {
            return _exceptionUtility.HandleException(e);
        }
    }
    
    [HttpGet("/LightEventValues")]
    public async Task<ActionResult<List<DimReadingDto>>> GetEventValues(string boardId, DateTime timeFrom,
        DateTime timeTo) {
        try {
            var eventValues = await _DimLightService.GetEvents(boardId, timeFrom, timeTo);
            return Ok(eventValues);
        }
        catch (Exception e) {
            return _exceptionUtility.HandleException(e);
        }
    }
}