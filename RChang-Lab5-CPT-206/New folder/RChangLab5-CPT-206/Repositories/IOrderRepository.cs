using Packt.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RChangLab5_CPT_206.Repositories
{
	public interface IOrderRepository
	{
		Task<Order?> CreateAsync(Order order);
		Task<IEnumerable<Order>> RetrieveAllAsync();
		Task<Order?> RetrieveAsync(int id);
		Task<Order?> UpdateAsync(int id, Order order);
		Task<bool?> DeleteAsync(int id);
	}
}
