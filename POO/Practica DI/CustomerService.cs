using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DI
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        // Constructor que recibe la dependencia como parámetro
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(string customerName)
        {
            _customerRepository.AddCustomer(customerName);
        }
    }
}
