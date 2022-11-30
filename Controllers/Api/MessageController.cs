using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IPizzeriaRepository _pizzeriaRepository;

        public MessageController(IPizzeriaRepository pizzeriaRepository)
        {
            _pizzeriaRepository = pizzeriaRepository;
        }
        public IActionResult Create(Message message)
        {
            _pizzeriaRepository.NewMessage(message);
           
            return Ok(message);
        }
    }
}
