using Microsoft.AspNetCore.Mvc;
using Notas_APE.DTO_s;
using Notas_APE.Services;

namespace Notas_APE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromediosController : ControllerBase
    {
        private readonly PromedioService _service;

        public PromediosController(PromedioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromedioDTO>>> Get()
        {
            var promedios = await _service.GetPromediosDTOAsync();
            return Ok(promedios);
        }
    }
}
