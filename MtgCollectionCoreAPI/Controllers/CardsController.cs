using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MtgCollectionCoreAPI.Db;
using MtgCollectionCoreModel.Model;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;

namespace MtgCollectionCoreAPI.Controllers
{
    [Route("api/Cards")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly MtgCollectionContext _context;

        public CardsController(MtgCollectionContext context)
        {
            _context = context;
        }

        //GET: api/Cards/GetCardById
        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> GetCardById(int id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            return Ok(card);
        }

        //GET: api/Cards/GetAllCards
        [HttpGet]
        public async Task<ActionResult<List<Card>>> GetAllCards()
        {
            return await _context.Cards.ToListAsync();
        }

        //GET: api/Cards/GetCardsByName
        [HttpGet("Name/{name}")]
        public async Task<ActionResult<List<Card>>> GetCardByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("El nombre no puede estar vacio");
            }

            var cards = await _context.Cards.Where(x => EF.Functions.Like(x.Name, $"%{name}%")).ToListAsync();

            return Ok(cards);
        }

        //GET: api/Cards/GetCardsByColor
        [HttpGet("Color/{color}")]
        public async Task<ActionResult<List<Card>>> GetCardsByColor(string color)
        {
            if (string.IsNullOrEmpty(color))
            {
                return BadRequest("El color no puede estar vacio");
            }
            List<Card> cards;
            switch (color)
            {
                case "G":
                case "g":
                    cards = await _context.Cards.Where(x => x.Green == true).ToListAsync();
                    return Ok(cards);
                case "R":
                case "r":
                    cards = await _context.Cards.Where(x => x.Red == true).ToListAsync();
                    return Ok(cards);
                case "U":
                case "u":
                    cards = await _context.Cards.Where(x => x.Blue == true).ToListAsync();
                    return Ok(cards);
                case "B":
                case "b":
                    cards = await _context.Cards.Where(x => x.Black == true).ToListAsync();
                    return Ok(cards);
                case "W":
                case "w":
                    cards = await _context.Cards.Where(x => x.White == true).ToListAsync();
                    return Ok(cards);
            }
            cards = await _context.Cards.Where(x => !x.White && !x.Black && !x.Blue && !x.Green && !x.Red).ToListAsync();
            return Ok(cards);
        }

        //POST api/Cards
        [HttpPost]
        public async Task<ActionResult<Card>> PostCard(Card card)
        {
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCardById), new { id = card.Id }, card);
        }

        //PUT api/Cards/PutCard
        [HttpPut("{id}")]
        public async Task<ActionResult<Card>> PutCard(int id, Card card)
        {
            if (id != card.Id)
            {
                return BadRequest("El id no concuerda con el id de la carta");
            }
            _context.Entry(card).State = EntityState.Modified;

            try
            {
                _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardExists(id))
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

        //DELETE api/Cards/DeleteCard
        [HttpDelete("{id}")]
        public async Task<ActionResult<Card>> DeleteCard(int id)
        {
            Card card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool CardExists(int id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
    }
}
