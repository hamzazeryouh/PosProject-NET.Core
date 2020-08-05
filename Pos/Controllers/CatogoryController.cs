using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatogoryController : ControllerBase
    {
        public DataContext _Data { get; }

        public CatogoryController( DataContext data)
        {
            _Data = data;
        }


        // GET: api/Catogory
        [HttpGet]
        public ActionResult<IEnumerable<Categorys>> Get()
        {
            var Cat = _Data.Categorys.ToList<Categorys>();
            return Cat;
        }

        // GET: api/Catogory/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<Categorys>> Get(int id)
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
