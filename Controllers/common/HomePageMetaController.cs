using idflNet.Core.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("api/home-meta")]
    public class HomePageMetaController : ControllerBase
    {
        private readonly ILogger<HomePageMetaController> _logger;

        private readonly HomeMetaDataService _homeMetaService;
        public HomePageMetaController(ILogger<HomePageMetaController> logger, HomeMetaDataService homeMetaDataService)
        {
            _logger = logger;
            _homeMetaService = homeMetaDataService;
        }
        [HttpGet]
        public IActionResult GetAllHomeMetaData([FromQuery] IParams queryParams)
        {
            try
            {   
                var data = _homeMetaService.HomeMetaResult(queryParams);
                if (data != null)
                {
                    return Ok(data);
                }
                else{
                    return NotFound();
                }
            }
            catch (System.Exception ex)
            {
                _logger.LogError("Get data home page", ex.Message);
                return BadRequest("Get data home page is error");
            }

        }
    }
}