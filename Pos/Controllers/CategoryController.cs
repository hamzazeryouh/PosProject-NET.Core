using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Pos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly DataContext _Data;

        public CategoryController( DataContext data)
        {
            _Data = data;
        }


        // GET: api/Catogory
        [HttpGet]
        public ActionResult<IEnumerable<Categorys>> Get()
        {
            var Cat = _Data.Categorys.ToList();
            if (Cat == null)
            {
                return BadRequest("vide List");
            }
            return Cat;
        }

        // GET: api/Catogory/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Categorys>> GetByID(int id)
        {
            var Category = _Data.Categorys.Find(id);
            if (Category == null)
            {
                return NotFound();
            }
            return Ok(Category);
        }

        // POST: api/Catogory
        [HttpPost]
        public ActionResult Post([FromBody]  Categorys categorys)
        {
            _Data.Categorys.Add(categorys);
            _Data.SaveChanges();
            return Ok();


        }

        // PUT: api/Catogory/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Categorys cat)
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
        public async Task<ActionResult>   Delete(int id)
        {
            var cat = await _Data.Categorys.FindAsync(id);
                if(cat == null)
            {
                return NotFound();
            }
            _Data.Categorys.Remove(cat);
         await _Data.SaveChangesAsync();
            return Ok();
        }
    }
}
