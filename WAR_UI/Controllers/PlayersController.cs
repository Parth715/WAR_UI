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
    public class PlayersController : ControllerBase
    {
        private readonly WARDbContext _context;

        public PlayersController(WARDbContext context)
        {
            _context = context;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            return await _context.Players.Include(x => x.Card).Where(x => x.Id < 3).ToListAsync();
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _context.Players.Include(x => x.Card).SingleOrDefaultAsync(x => x.Id == id); 

            if (player == null)
            {
                return NotFound();
            }

            return player;
        }
        

        // PUT: api/Players/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer(int id, Player player)
        {
            if (id != player.Id)
            {
                return BadRequest();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
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

        [HttpGet("rand")] //get AI and Player card
        public async Task<ActionResult<Player>> GetCard()
        {
            var player = await _context.Players.FindAsync(1);
            var Comp = await _context.Players.SingleOrDefaultAsync(x => x.Name == "AI");
            Random rand = new Random();
            var number = rand.Next(1, 53);
            var card = await _context.Cards.FindAsync(number);
            await _context.SaveChangesAsync();
            player.Card = card;
            number = rand.Next(1, 53);
            card = await _context.Cards.FindAsync(number);
            Comp.Card = card;
            await _context.SaveChangesAsync();
            var blank = await _context.Cards.FindAsync(53);
            var blank1 = await _context.Cards.FindAsync(54);
            blank.Playerid = 3;
            blank1.Playerid = 3;
            await _context.SaveChangesAsync();
            return NoContent();

        }
        [HttpPut("Blank/{player}")]//gets player and assigns blank card so properties are not null on frontend
        public async Task<ActionResult<Player>> Blank(Player player)
        {
            for(var i = 1; i <= 52; i++)
            {
                var card = await _context.Cards.FindAsync(i);
                card.Playerid = 3;
                await _context.SaveChangesAsync();
            }
            var blankcard = await _context.Cards.FindAsync(53);
            player.Card = blankcard;
            await _context.SaveChangesAsync();
            return player;
        }
        [HttpPut("Blank1/{AI}")]//gets player and assigns blank card so properties are not null on frontend
        public async Task<ActionResult<Player>> AIBlank(Player AI)
        {
            var blankcard = await _context.Cards.FindAsync(53);
            AI.Card = blankcard;
            await _context.SaveChangesAsync();
            return AI;
        }
        // POST: api/Players
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayer", new { id = player.Id }, player);
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.Id == id);
        }
    }
}
