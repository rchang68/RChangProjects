using Microsoft.AspNetCore.Mvc;
using Packt.Shared;


namespace RChangLab5_CPT_206.Repositories
{

	//base address: api/customers
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly ICustomerRepository repo;

		//create our constructor with teh Interface as parameter
		public CustomersController(ICustomerRepository repo)
		{
			this.repo = repo;
		}
		// GET: api/customers
		// GET: api/customers/?country=[county]
		// this will always return a list of customers (but it might be empty)
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
		public async Task<IEnumerable<Customer>> GetCustomers(string? country)
		{
			if (string.IsNullOrWhiteSpace(country)) //if country is null return everything
			{
				return await repo.RetrieveAllAsync(); 
			}
			else //if country is not null then we search for where country = country
			{
				return (await repo.RetrieveAllAsync())
					.Where(Customer => Customer.Country == country);
			}
		}
		// GET: api/customers/[id]
		[HttpGet("{id}", Name = nameof(GetCustomers))] //named route
		[ProducesResponseType(200, Type = typeof(Customer))]
		[ProducesResponseType(404)]
		public async Task<IActionResult> GetCustomer(string id)
		{
			Customer? customer = await repo.RetrieveAsync(id);
			if(customer == null)
			{
				return NotFound();
			}
			return Ok(customer);
		}

		// POST: api/customers
		// BODY: Customer (JSON, XML)
		[HttpPost]
		[ProducesResponseType(201, Type = typeof(Customer))]
		[ProducesResponseType(400)]
		public async Task<IActionResult> Create([FromBody] Customer customer)
		{
			if(customer == null)
			{
				return BadRequest();

			}
			Customer? addedCustomer = await repo.CreateAsync(customer);
			if (addedCustomer == null)
			{
				return BadRequest("Repository failed to create customer");
			}
			else
			{
				return CreatedAtRoute(
					routeName: nameof(GetCustomer),
					routeValues: new { id = addedCustomer.CustomerId.ToLower() },
					value: addedCustomer);
			}
		}
		// PUT: api/customer/[id]
		// BODY: Customer(JSON, XML)
		[HttpPut("{id}")]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<IActionResult> Update(string id, [FromBody] Customer customer)
		{
			id = id.ToUpper();
			customer.CustomerId = customer.CustomerId.ToUpper();

			if(customer == null || customer.CustomerId == null)
			{
				return BadRequest();

			}
			Customer? existing = await repo.RetrieveAsync(id);
			if (existing == null)
			{
				return NotFound();
			}
			await repo.UpdateAsync(id, customer);
			return new NoContentResult();
		}

		// DELETE: api/customer/[id]
		[HttpDelete("{id}")]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<IActionResult> Delete(string id)
		{
			Customer? existsing = await repo.RetrieveAsync(id);
			if (existsing == null)
			{
				return NotFound();
			}
			bool? deleted = await repo.DeleteAsync(id);
			if(deleted.HasValue && deleted.Value)
			{
				return new NoContentResult();
			}
			else
			{
				return BadRequest($"Customer {id} was found but failed to delete!");
			}
		}
	}
}
