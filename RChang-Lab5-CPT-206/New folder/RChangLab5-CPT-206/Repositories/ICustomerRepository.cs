﻿using Packt.Shared;
namespace RChangLab5_CPT_206.Repositories
{
	public interface ICustomerRepository
	{
		Task<Customer?> CreateAsync(Customer customer);
		Task<IEnumerable<Customer>> RetrieveAllAsync();
		Task<Customer?> RetrieveAsync(string id);
		Task<Customer?> UpdateAsync(string id, Customer customer);
		Task<bool?> DeleteAsync(string id);

	}
}
