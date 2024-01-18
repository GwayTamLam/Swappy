using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swappy.Server.Data;
using Swappy.Shared.Domain;
using Swappy.Server.IRepository;
using Swappy.Client;


namespace Swappy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        //public CartsController(ApplicationDbContext context)
        public CartsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Carts
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
        public async Task<IActionResult> GetCarts()
        {
            //if (_context.Carts == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Carts.ToListAsync();

            var carts = await _unitOfWork.Carts.GetAll();

            if (carts == null)
            {
                return NotFound();
            }

            return Ok(carts);
        }

        // GET: api/Carts/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Cart>> GetCart(int id)
        public async Task<IActionResult> GetCart(int id)
        {
            //if (_context.Carts == null)
            //{
            //    return NotFound();
            //}
            //  var cart = await _context.Carts.FindAsync(id);

            var cart = await _unitOfWork.Carts.Get(q => q.Id == id);

            if (cart == null)
            {
                return NotFound();
            }

            return Ok(cart);
        }

        // PUT: api/Carts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart(int id, Cart cart)
        {
            if (id != cart.Id)
            {
                return BadRequest();
            }

            //_context.Entry(cart).State = EntityState.Modified;
            _unitOfWork.Carts.Update(cart);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!CartExists(id))
                if (!await CartExists(id))
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

        // POST: api/Carts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cart>> PostCart(Cart cart)
        {
            //if (_context.Carts == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Carts'  is null.");
            //}
            //  _context.Carts.Add(cart);
            //  await _context.SaveChangesAsync();

            await _unitOfWork.Carts.Insert(cart);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCart", new { id = cart.Id }, cart);
        }

        // DELETE: api/Carts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            //if (_context.Carts == null)
            //{
            //    return NotFound();
            //}
            //var cart = await _context.Carts.FindAsync(id);

            var cart = await _unitOfWork.Carts.Get(q => q.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            //_context.Carts.Remove(cart);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Carts.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CartExists(int id)
        {
            //return (_context.Carts?.Any(e => e.Id == id)).GetValueOrDefault();\
            var cart = await _unitOfWork.Carts.Get(q => q.Id == id);

            return cart != null;
        }
    }
}
