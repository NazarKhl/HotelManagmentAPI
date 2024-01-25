using HotelManagmentAPI.Context;
using HotelManagmentAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly CRUDContext _crudContext;

        public PeopleController(CRUDContext crudContext)
        {
            _crudContext = crudContext;
        }
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<People> Get()
        {
            return _crudContext.People;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public People Get(int id)
        {
            return _crudContext.People.SingleOrDefault(x => x.PeopleId == id);
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] People people)
        {
            _crudContext.People.Add(people);
            _crudContext.SaveChanges();
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] People people)
        {
            people.PeopleId = id;
            _crudContext.People.Update(people);
            _crudContext.SaveChanges();
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _crudContext.People.SingleOrDefault(x => x.PeopleId == id);
            if (item != null)
            {
                _crudContext.People.Remove(item);
                _crudContext.SaveChanges();
            }
        }
    }
}
