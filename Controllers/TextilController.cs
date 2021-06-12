using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiTextil.Context;

namespace ApiTextil.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TextilController : ControllerBase
    {
        private readonly AppDbContext context;
        public TextilController(AppDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            //Error handling Try-catch
            return Ok(context.Textil.ToList());
        }

    }
}
