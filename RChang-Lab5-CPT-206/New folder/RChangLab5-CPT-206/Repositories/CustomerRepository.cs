using Microsoft.EntityFrameworkCore.ChangeTracking;
using Packt.Shared;//customer from northwind data context
using System.Collections.Concurrent;//concurrent and async stuff
namespace RChangLab5_CPT_206.Repositories
{
	public class CustomerRepository : ICustomerRepository
	{
		//Create a chache of customers that will stay in our browser
		private static ConcurrentDictionary<string, Customer>? customerCache;
		//instance of the datacontext
		private NorthwindContext db;

		public CustomerRepository(NorthwindContext injectedContext)
		{
			db = injectedContext;
			//load the customers from teh database
			//then convert ot our dictionary
			if (customerCache ==null)
			{
				customerCache = new ConcurrentDictionary<string, Customer>(
					db.Customers.ToDictionary(c => c.CustomerId));
			}
			
		}
		public async Task<Customer?> CreateAsync(Customer c)
		{
			c.CustomerId = c.CustomerId.ToUpper();
			//add to db user ef core
			EntityEntry<Customer> addedCustomer = await db.Customers.AddAsync(c);
			int affected = await db.SaveChangesAsync();
			if (affected == 1)
			{
				if (customerCache == null) return c;
				//if customer si new add to cache else call update
				return customerCache.AddOrUpdate(c.CustomerId, c, UpdateCache);
			}
			else
			{
				return null;
			}
		}
		public Task<IEnumerable<Customer>> RetrieveAllAsync() 
		{
			return Task.FromResult(customerCache is null ? Enumerable.Empty<Customer>() : customerCache.Values);
		}
		public Task<Customer?> RetrieveAsync(string id)
		{
			id = id.ToUpper();
			if (customerCache == null) return null!;
			customerCache.TryGetValue(id, out Customer? customer);
			return Task.FromResult(customer);
		}

		private Customer UpdateCache(string id, Customer customer)
		{
			Customer? old;
			if(customerCache is not null)
			{
				if(customerCache.TryGetValue(id, out old))
				{
					if(customerCache.TryUpdate(id, customer, old))
					{
						return customer;
					}
				}
			}
			return null;
		}
		public async Task<Customer?> UpdateAsync(string id, Customer customer)
		{
			id = id.ToUpper();
			customer.CustomerId = customer.CustomerId.ToUpper();

			//update the database
			db.Customers.Update(customer);
			int affected = await db.SaveChangesAsync();
			if (affected == 1)
			{
				//update the cache
				return UpdateCache(id, customer);
			}
			return null;
        }

		public async Task<bool?> DeleteAsync(string id)
		{
			id = id.ToUpper();
			//remove from db
			Customer? customer = db.Customers.Find(id);
			if (customer != null)
			{
				return null;//nothing to delete
			}
			db.Customers.Remove(customer);
			int affected = await db.SaveChangesAsync();
			if (affected == 1)
			{
				if (customerCache is null) return null;
				//else remove
				return customerCache.TryRemove(id, out customer);
			}
			else { return null; }
		}
	}
}
