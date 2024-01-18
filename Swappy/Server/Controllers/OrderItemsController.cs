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
    public class OrderItemsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        //public OrderItemsController(ApplicationDbContext context)
        public OrderItemsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/OrderItems
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        public async Task<IActionResult> GetOrderItems()
        {
            //if (_context.OrderItems == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.OrderItems.ToListAsync();

            var orderitems = await _unitOfWork.OrderItems.GetAll();

            if (orderitems == null)
            {
                return NotFound();
            }

            return Ok(orderitems);
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        public async Task<IActionResult> GetOrderItem(int id)
        {
            //if (_context.OrderItems == null)
            //{
            //    return NotFound();
            //}
            //  var orderitem = await _context.OrderItems.FindAsync(id);

            var orderitem = await _unitOfWork.OrderItems.Get(q => q.Id == id);

            if (orderitem == null)
            {
                return NotFound();
            }

            return Ok(orderitem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderitem)
        {
            if (id != orderitem.Id)
            {
                return BadRequest();
            }

            //_context.Entry(orderitem).State = EntityState.Modified;
            _unitOfWork.OrderItems.Update(orderitem);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!OrderItemExists(id))
                if (!await OrderItemExists(id))
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

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderitem)
        {
            //if (_context.OrderItems == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.OrderItems'  is null.");
            //}
            //  _context.OrderItems.Add(orderitem);
            //  await _context.SaveChangesAsync();

            await _unitOfWork.OrderItems.Insert(orderitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOrderItem", new { id = orderitem.Id }, orderitem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            //if (_context.OrderItems == null)
            //{
            //    return NotFound();
            //}
            //var orderitem = await _context.OrderItems.FindAsync(id);

            var orderitem = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            if (orderitem == null)
            {
                return NotFound();
            }

            //_context.OrderItems.Remove(orderitem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> OrderItemExists(int id)
        {
            //return (_context.OrderItems?.Any(e => e.Id == id)).GetValueOrDefault();\
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.Id == id);

            return orderitem != null;
        }
    }
}
