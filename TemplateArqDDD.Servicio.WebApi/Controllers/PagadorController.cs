using Microsoft.AspNetCore.Mvc;
using TemplateArqDDD.Aplicacion.Entidad;
using TemplateArqDDD.Aplicacion.Interface;

namespace TemplateArqDDD.Servicio.WebApi.Controllers
{
    public class PagadorController : Controller
    {
        private readonly IPagadorApInterface _pagadorApInterface;
        public PagadorController(IPagadorApInterface pagadorApInterface)
        {
            _pagadorApInterface = pagadorApInterface;
        }
        
        [HttpPost("InsertPagadorAsync")]
        public async Task<IActionResult> InsertPagadorAsync([FromBody] PagadorApEntidad pagadorApEntidad)
        {
            if (pagadorApEntidad == null)
                return BadRequest();
            var response = await _pagadorApInterface.InsertPagadorAsync(pagadorApEntidad);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

    }
}
