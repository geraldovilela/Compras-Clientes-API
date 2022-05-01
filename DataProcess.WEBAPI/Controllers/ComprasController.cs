using Microsoft.AspNetCore.Mvc;
using WEBAPI.Domain.DTO;
using WEBAPI.Service.Interfaces;

namespace DataProcess.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {

        private ICompraFacade _compraFacade;
        public ComprasController(ICompraFacade compraFacade)
        {
            _compraFacade = compraFacade;
        }
        
        [HttpPost]
        public  IActionResult CreateCompra([FromBody] CompraRequestDTO request)
        {
            var result = _compraFacade.CreateCompra(request);
            return Ok(result);
        }
    }
}
