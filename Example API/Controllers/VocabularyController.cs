using EngDict.NET;
using Microsoft.AspNetCore.Mvc;

namespace Example_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VocabularyController : ControllerBase
    {
        [HttpGet("Search")]
        public async Task<IActionResult> Search(string keyword)
        {
            var result = await EngDict.NET.EngDict.SearchAsync(keyword); 
            return Ok(result);
        }
    }
}
