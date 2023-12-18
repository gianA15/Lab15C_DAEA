using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab15C_DAEA.Models.Response;

namespace Lab15C_DAEA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [Authorize]
        [HttpGet(Name = "Get2")]
        public IEnumerable<PersonResponse> Get2()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonResponse person = new PersonResponse();
                person.FirstName = "Persona" + i;
                person.LastName = "Apellido" + i;

                personas.Add(person);
            }
            return personas;
        }

        [Authorize("Administrador")]
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonResponse person = new PersonResponse();
                person.FirstName = "Persona" + i;
                person.LastName = "Apellido" + i;

                personas.Add(person);
            }
            return personas;
        }

        [Authorize("Vendedor")]
        [HttpGet(Name = "Get3")]
        public IEnumerable<PersonResponse> Get3()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonResponse person = new PersonResponse();
                person.FirstName = "Persona" + i;
                person.LastName = "Apellido" + i;

                personas.Add(person);
            }
            return personas;
        }
    }
}
