using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.Domain.DTO;
using WEBAPI.Domain.Entities;

namespace WEBAPI.Service.Interfaces
{
    public interface IClienteFacade
    {

        ClienteResponseDTO GetCliente(Guid request);

        List<ClienteDTO> GetAllClientes();

        ClienteDTO CreateCliente(ClienteRequestDTO request);
    }
}
