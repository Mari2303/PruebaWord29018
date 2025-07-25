using Business.Interfaces;
using Entity.Dtos.ClientesDTO;
using Entity.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Interface;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Web.Controllers.Implements
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : GenericController<ClientesDTO, Clientes>, IClientesController
    {
        private readonly IClientesBusiness _clientesBusiness;

        public ClientesController(IClientesBusiness ClientesBusiness, ILogger<ClientesController> logger)
            : base(ClientesBusiness, logger)
        {
            _clientesBusiness = ClientesBusiness;
        }

        protected override int GetEntityId(ClientesDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
