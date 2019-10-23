using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_Test_2.Model;
using ASP_Test_2.Repositories;
using PagedList;

namespace ASP_Test_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public PeopleRepository Mine;

        public PeopleController(UsersContext context)
        {
            Mine = new PeopleRepository(context);
        }

        // GET: api/People
        [HttpGet]
        public async Task<ActionResult<IEnumerable<People>>> GetAllPeople([FromQuery]int? Page)
        {
            int? page = Page ?? 1;
            var people = await Mine.GetAllPeople(page);
            if (people == null)
            {
                return NotFound();
            }
            return  Ok(people);
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<ActionResult<People>> GetByID(int id)
        {
            var people = await Mine.GetPersonID(id);
            if (people == null)
            {
                return NotFound();
            }
            return people;
        }

        [HttpGet("Count")]
        public async Task<ActionResult<int>> GetPeopleCount()
        {
            var count = await Mine.GetPeopleCount();
            if (count == null)
            {
                return NotFound();
            }
            return count;
        }
        // GET: api/People/name/Henry
        [HttpGet("name/{name}")]
        public async Task<ActionResult<IEnumerable<People>>> GetByName(string name)
        {
            var people = await Mine.GetPersonName(name);
            if (people == null)
            {
                return NotFound();
            }
            return people;
        }
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<People>>> GetBySearch([FromQuery] string search, int Page)
        {
            var people = await Mine.SearchPeople(search,Page);
            if (people == null)
            {
                return NotFound();
            }
            return people;
        }
        //[HttpGet("TokenCheck")]
        //public async Task<ActionResult<IEnumerable<People>>> GetApproval([FromQuery] string Token)
        //{

        //}

        // PUT: api/People/5
        [HttpPut("{id}")]
        public async Task<ActionResult<People>> UpdateByID(int id, People people)
        {
            var retVal = await Mine.PutPeople(id, people);
            if (retVal == null)
            {
                return NotFound();
            }
            else if(retVal == (ActionResult<People>)people)
            {
                return NoContent();
            }
            return retVal;
        }

        // POST: api/People
        [HttpPost]
        public async Task<ActionResult<People>> AddPeople(People people)
        {
            return await Mine.PostPeople(people);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<People>> DeletePeople(int id)
        {
            var people = await Mine.DeletePeople(id);
            if (people == null)
            {
                return NotFound();
            }
            return people;
        }
    }
}
