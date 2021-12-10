using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WAR_UI;

namespace WAR_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly WARDbContext _context;

        public CardsController(WARDbContext context)
        {
            _context = context;
        }

        // GET: api/Cards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cards>>> GetCards()
        {
        
            return await _context.Cards.ToListAsync();
        }
        [HttpGet("{playernum}")]
        public async Task<ActionResult<Cards>> PlayerCard(int num)
        {
            return await _context.Cards.FindAsync(num);
        }
        [HttpGet("rand")]
        public async Task<ActionResult<Cards>> GetCard(int playernum)
        {
            Random rand = new Random();
            var number = rand.Next(52);
            while (number == playernum)
            {
                number = rand.Next(52);
            }
            return await _context.Cards.FindAsync(number);
            
           
        }
        // GET: api/Cards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cards>> GetCards(int id)
        {
            var cards = await _context.Cards.FindAsync(id);

            if (cards == null)
            {
                return NotFound();
            }

            return cards;
        }

        // PUT: api/Cards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCards(int id, Cards cards)
        {
            if (id != cards.Id)
            {
                return BadRequest();
            }

            _context.Entry(cards).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardsExists(id))
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

        // POST: api/Cards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cards>> PostCards(Cards cards)
        {
            _context.Cards.Add(cards);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCards", new { id = cards.Id }, cards);
        }

        // DELETE: api/Cards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCards(int id)
        {
            var cards = await _context.Cards.FindAsync(id);
            if (cards == null)
            {
                return NotFound();
            }

            _context.Cards.Remove(cards);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardsExists(int id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
        private List<Cards> Shuffle(List<Cards> cards)
        {
            var deck = new List<Cards>();
            deck = Cards.Deck();
            deck = Cards.Mix(cards );
            return deck;
        }
    }
}
