using Business.Interfaces;
using Entity.Dtos.PizzasDTO;
using Entity.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Interface;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Web.Controllers.Implements
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : GenericController<PizzasDto, Pizzas>, IPizzasController
    {
        private readonly IPizzasBusiness _pizzasBusiness;

        public PizzasController(IPizzasBusiness pizzasBusiness, ILogger<PizzasController> logger)
            : base(pizzasBusiness, logger)
        {
            _pizzasBusiness = pizzasBusiness;
        }

        protected override int GetEntityId(PizzasDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
