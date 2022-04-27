using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Domain.Entities;
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
        public IActionResult GetAll()
        {
            var result = _clienteFacade.getAllClientes();
            return Ok(result);
        }
    }
}
