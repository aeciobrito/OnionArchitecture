using Repository.Interfaces;
using Domain.Models;
using Services.Interfaces;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> _repository;
        
        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.SelectAll();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.Select(id);
        }

        public void AddCustomer(Customer customer)
        {
            _repository.Add(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomer(id);
            _repository.Remove(customer);
        }
    }
}
