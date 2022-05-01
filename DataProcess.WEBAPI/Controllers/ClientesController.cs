using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using WEBAPI.Domain.DTO;
using WEBAPI.Service.Interfaces;

namespace DataProcess.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IClienteFacade _clienteFacade;
        public ClientesController(  IClienteFacade clienteFacade,
                                    IMapper mapper)
        {
            _clienteFacade = clienteFacade;
            _Mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get([FromHeader] Guid request)
        {

            var result = _clienteFacade.GetCliente(request);
            return Ok(result);
        }

        [HttpGet("All")]
        public IActionResult GetAll()
        {
            var result = _clienteFacade.GetAllClientes();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateCliente([FromBody]ClienteRequestDTO request)
        {
            var result = _clienteFacade.CreateCliente(request);
            return Ok(result);
        }
    }
}
