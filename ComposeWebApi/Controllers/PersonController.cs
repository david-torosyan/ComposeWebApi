using ComposeWebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComposeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonRepository _personRepository;

        public PersonController(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personRepository.GetPersons();
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            _personRepository.AddPerson(value);
        }
    }
}
