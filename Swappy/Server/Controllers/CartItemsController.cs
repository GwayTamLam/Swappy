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
    public class CartItemsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        //public CartItemsController(ApplicationDbContext context)
        public CartItemsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/CartItems
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<CartItem>>> GetCartItems()
        public async Task<IActionResult> GetCartItems()
        {
            //if (_context.CartItems == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.CartItems.ToListAsync();

            var cartitems = await _unitOfWork.CartItems.GetAll(includes: q=>q.Include(x=>x.User).Include(x=>x.Product).Include(x=>x.Order));

            if (cartitems == null)
            {
                return NotFound();
            }

            return Ok(cartitems);
        }

        // GET: api/CartItems/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<CartItem>> GetCartItem(int id)
        public async Task<IActionResult> GetCartItem(int id)
        {
            //if (_context.CartItems == null)
            //{
            //    return NotFound();
            //}
            //  var cartitem = await _context.CartItems.FindAsync(id);

            var cartitem = await _unitOfWork.CartItems.Get(q => q.Id == id);

            if (cartitem == null)
            {
                return NotFound();
            }

            return Ok(cartitem);
        }

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartItem(int id, CartItem cartitem)
        {
            if (id != cartitem.Id)
            {
                return BadRequest();
            }

            //_context.Entry(cartitem).State = EntityState.Modified;
            _unitOfWork.CartItems.Update(cartitem);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!CartItemExists(id))
                if (!await CartItemExists(id))
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

        // POST: api/CartItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CartItem>> PostCartItem(CartItem cartitem)
        {
            //if (_context.CartItems == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.CartItems'  is null.");
            //}
            //  _context.CartItems.Add(cartitem);
            //  await _context.SaveChangesAsync();

            await _unitOfWork.CartItems.Insert(cartitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCartItem", new { id = cartitem.Id }, cartitem);
        }

        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(int id)
        {
            //if (_context.CartItems == null)
            //{
            //    return NotFound();
            //}
            //var cartitem = await _context.CartItems.FindAsync(id);

            var cartitem = await _unitOfWork.CartItems.Get(q => q.Id == id);
            if (cartitem == null)
            {
                return NotFound();
            }

            //_context.CartItems.Remove(cartitem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.CartItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CartItemExists(int id)
        {
            //return (_context.CartItems?.Any(e => e.Id == id)).GetValueOrDefault();\
            var cartitem = await _unitOfWork.CartItems.Get(q => q.Id == id);

            return cartitem != null;
        }
    }
}
