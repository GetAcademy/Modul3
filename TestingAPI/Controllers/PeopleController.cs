using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestingAPI.Model;

namespace TestingAPI.Controllers
{
    class MyDBContext { }
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly MyDBContext _context;

        public PeopleController(MyDBContext context)
        {
            _context = context;
        }

        // GET: api/People
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPerson()
        {
            return _context.Person;
            return new[]
            {
                new Person{ID = 1, Name = "Kålmann", BirthYear = 1912, Age = 107, Mother = "Klingklong", Father = "WasabiBOMBOM"},
                new Person{ID = 2, Name = "Kjell", BirthYear = 2010, Age = 9, Mother = "karoline", Father = "Tom"},
                new Person{ID = 3, Name = "jolk", BirthYear = 1980, Age = 39, Mother = "janine", Father = "frank"},
            };
        }

        // GET: api/People/5
        [HttpGet("{ID}")]
        public async Task<Person> GetPerson([FromRoute] int ID)
        {
            //var person = await _context.Person.FindAsync(id);
            var person = ID == 1 ? new Person { ID = 1, Name = "Kålmann", BirthYear = 1912, Age = 107, Mother = "Klingklong", Father = "WasabiBOMBOM" } : ID == 2 ? new Person { ID = 2, Name = "Kjell", BirthYear = 2010, Age = 9, Mother = "karoline", Father = "Tom" } : new Person { ID = 3, Name = "jolk", BirthYear = 1980, Age = 39, Mother = "janine", Father = "frank" };
            return person;
        }

        // PUT: api/People/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(int id, Person person)
        {
            if (id != person.ID)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/People
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson([FromRoute] Person person)
        {
            _context.Person.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.ID }, person);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Person>> DeletePerson(int id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return person;
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.ID == id);
        }
    }
}
