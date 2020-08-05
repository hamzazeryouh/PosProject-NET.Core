using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Pos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly DataContext _Data;

        public UsersController(DataContext data)
        {
            _Data = data;
        }


        // GET: api/Catogory
        [HttpGet]
        public ActionResult<IEnumerable<Users>> Get()
        {
            var Cat = _Data.Users.ToList();
            if (Cat == null)
            {
                return BadRequest("vide List");
            }
            return Cat;
        }

        // GET: api/Catogory/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Users>> GetByID(int id)
        {
            var Category = _Data.Users.Find(id);
            if (Category == null)
            {
                return NotFound();
            }
            return Ok(Category);
        }

        // POST: api/Catogory
        [HttpPost]
        public ActionResult Post([FromBody]  Users Users)
        {
            _Data.Users.Add(Users);
            _Data.SaveChanges();
            return Ok();


        }

        // PUT: api/Catogory/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Users cat)
        {
            if (id != cat.Id)
            {
                return BadRequest();
            }
            _Data.Entry(cat).State = EntityState.Modified;
            _Data.SaveChanges();
            return Ok();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var cat = await _Data.Users.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }
            _Data.Users.Remove(cat);
            await _Data.SaveChangesAsync();
            return Ok();
        }
    }
}
