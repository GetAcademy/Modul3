using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_Test_2.Model;


namespace ASP_Test_2.Repositories
{

    public class PeopleRepository : ControllerBase
    {
        UsersContext _context;
        public PeopleRepository(UsersContext connection)
        {
            _context = connection;
        }

        public async Task<ActionResult<IEnumerable<People>>> GetPeople()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<ActionResult<People>> GetPeople(int id)
        {
            var people = await _context.People.FindAsync(id);
            return people;
        }

        public async Task<ActionResult<IEnumerable<People>>> GetPeople(string name)
        {
            var people = await _context.People.Where(p => p.Name.Contains(name)).ToArrayAsync();
            return people;
        }

        public async Task<ActionResult<IEnumerable<People>>> SearchPeople(string search)
        {
            string[] Words = search.Split(' ', ',', '-', '_');
            List<People> people = new List<People>();
            foreach (string Word in Words)
            {
                people.AddRange(await _context.People.Where(s => s.Id.ToString().Contains(Word)
                                                              || s.Name.Contains(Word)
                                                              || s.BirthYear.ToString().Contains(Word)
                                                              || s.Age.ToString().Contains(Word)
                                                              || s.Mother.Contains(Word)
                                                              || s.Father.Contains(Word)).ToArrayAsync());
            }
            people = people.Distinct().OrderByDescending(p => p.Id).ToList();
            return people;
        }

        public async Task<ActionResult<People>> PutPeople(int id, People people)
        {
            _context.Entry(people).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return people;
        }

        public async Task<ActionResult<People>> PostPeople(People people)
        {
            _context.People.Add(people);
            await _context.SaveChangesAsync();
            return CreatedAtAction("AddPeople", people);
        }

        public async Task<ActionResult<People>> DeletePeople(int id)
        {
            var people = await _context.People.FindAsync(id);
            _context.People.Remove(people);
            await _context.SaveChangesAsync();
            return people;
        }

        private bool PeopleExists(int id)
        {
            return _context.People.Any(e => e.Id == id);
        }
    }
}
