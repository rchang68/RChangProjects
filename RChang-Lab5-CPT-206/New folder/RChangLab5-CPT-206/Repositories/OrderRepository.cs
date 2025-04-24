using Microsoft.EntityFrameworkCore;
using Packt.Shared;
using System.Collections.Concurrent;

namespace RChangLab5_CPT_206.Repositories
{
	public class OrderRepository : IOrderRepository
	{
		private readonly NorthwindContext db;

		public OrderRepository(NorthwindContext injectedContext)
		{
			db = injectedContext;
		}

		public async Task<Order?> CreateAsync(Order order)
		{
			db.Orders.Add(order);
			int affected = await db.SaveChangesAsync();
			return affected == 1 ? order : null;
		}

		public Task<IEnumerable<Order>> RetrieveAllAsync()
		{
			return Task.FromResult(db.Orders.AsEnumerable());
		}

		public async Task<Order?> RetrieveAsync(int id)
		{
			return await db.Orders.FindAsync(id);
		}

		public async Task<Order?> UpdateAsync(int id, Order order)
		{
			var existingOrder = await db.Orders.FindAsync(id);
			if (existingOrder != null)
			{
				db.Entry(existingOrder).CurrentValues.SetValues(order);
				int affected = await db.SaveChangesAsync();
				return affected == 1 ? order : null;
			}
			return null;
		}

		public async Task<bool?> DeleteAsync(int id)
		{
			var order = await db.Orders.FindAsync(id);
			if (order != null)
			{
				db.Orders.Remove(order);
				int affected = await db.SaveChangesAsync();
				return affected == 1;
			}
			return null;
		}
	}
}
