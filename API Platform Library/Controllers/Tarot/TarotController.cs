using API_Platform_Library.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace API_Platform_Library.Controllers.Tarot
{
    [ApiController]
    [Route("[controller]")]
    public class TarotController : ControllerBase
    {
        public readonly ApiPlatformContext _context;
        public TarotController(ApiPlatformContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Models.Tarot.Tarot> GetAll()
        {
            return _context.Tarot;
        }

        [HttpGet("{id}")]
        public ActionResult<Models.Tarot.Tarot> GetById(int id)
        {
            Models.Tarot.Tarot card = _context.Tarot
                .SingleOrDefault(card => card.ID == id);

            if(card is null)
            {
                return NotFound();
            }

            return card;

        }
    }

}
