using APITEST.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITEST.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PeopleController : ControllerBase
    {
        [Authorize]
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonReponse> Get()
        {
            List<PersonReponse> personas = new List<PersonReponse>();

            for(int i = 1; i <= 100; i++) { 
                PersonReponse person = new PersonReponse();
                person.FirstName = "Persona" + i;
                person.LastName = "Apellido" + i;

                personas.Add(person);
            }
            return personas;
        }

        [Authorize]
        [HttpGet(Name = "Get2")]
        public IEnumerable<PersonReponse> Get2()
        {
            List<PersonReponse> personas = new List<PersonReponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonReponse person = new PersonReponse();
                person.FirstName = "Persona" + i;
                person.LastName = "Apellido" + i;

                personas.Add(person);
            }
            return personas;
        }

    }
}
