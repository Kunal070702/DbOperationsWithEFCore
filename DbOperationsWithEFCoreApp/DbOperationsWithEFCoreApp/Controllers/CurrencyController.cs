using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDBContext db;

        public CurrencyController(AppDBContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCurrencyAsync()
        {
            var res = await db.Currencies.ToListAsync();
            return Ok(res);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAllCurrencyByIdAsync([FromRoute] int Id)
        {
            var res= await db.Currencies.FindAsync(Id);
            return Ok(res);

        }

        [HttpGet("{Id}/{Title}")]
        public async Task<IActionResult> GetCurrenciesByIdAndTitle([FromRoute] int Id,string? Title)
        {
            var res = await db.Currencies.FirstOrDefaultAsync(x => x.Id==Id && x.Title==Title);
            return Ok(res);
        }


    }
}
