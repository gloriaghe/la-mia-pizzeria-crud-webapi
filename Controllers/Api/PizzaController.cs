using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IPizzeriaRepository _pizzeriaRepository;

        public PizzaController(IPizzeriaRepository pizzeriaRepository)
        {
            _pizzeriaRepository = pizzeriaRepository;
        }
        public IActionResult Get()
        {
            List<Pizza> pizzas = _pizzeriaRepository.All();
            return Ok(pizzas);
        }

        [HttpGet("{id:int}")]
        public IActionResult Detail(int id)
        {
            Pizza pizza = _pizzeriaRepository.getID(id);
            return Ok(pizza);
        }

        public IActionResult Search(string? name)
        {

            List<Pizza> pizzas = _pizzeriaRepository.SearchByName(name);

            return Ok(pizzas);

        }
    }
}
