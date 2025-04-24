using Microsoft.AspNetCore.Mvc;
using Packt.Shared;

namespace RChangLab5_CPT_206.Repositories
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository repo;

        public OrdersController(IOrderRepository repo)
        {
            this.repo = repo;
        }

        // GET: api/orders
        [HttpGet]
        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await repo.RetrieveAllAsync();
        }

        // GET: api/orders/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await repo.RetrieveAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // POST: api/orders
        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder([FromBody] Order order)
        {
            var newOrder = await repo.CreateAsync(order);
            if (newOrder == null)
            {
                return BadRequest("Failed to create order");
            }
            return CreatedAtAction(nameof(GetOrder), new { id = newOrder.OrderId }, newOrder);
        }

        // PUT: api/orders/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, [FromBody] Order order)
        {
            var updatedOrder = await repo.UpdateAsync(id, order);
            if (updatedOrder == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        // DELETE: api/orders/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var deleted = await repo.DeleteAsync(id);
            if (!deleted.HasValue || !deleted.Value)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
