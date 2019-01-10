using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelUploads.Models;

namespace ModelUploads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Nothing", "To", "See" };
        }

        // POST api/values
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> PostAdImage([FromForm] AdModel model)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid model");
            if (model.AdImages == null) return BadRequest("Images are required");

            foreach (var img in model.AdImages)
            {
                if (img.Length == 0) continue;
                
                var filePath = Path.GetTempFileName();
                using (var stream = new FileStream(filePath, FileMode.Create))
                    await img.CopyToAsync(stream);
            }
            return Ok();
        }
    }
}
