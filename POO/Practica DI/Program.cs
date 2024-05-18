using Practica_DI;

class Program
{
    static void Main()
    {
        // Inyección de dependencia manual
        ICustomerRepository customerRepository = new CustomerRepository();
        CustomerService customerService = new CustomerService(customerRepository);
        customerService.AddCustomer("John Doe");

        // Prueba unitaria con inyección de dependencia de una implementación falsa
        ICustomerRepository fakeCustomerRepository = new FakeCustomerRepository();
        CustomerService customerServiceForTest = new CustomerService(fakeCustomerRepository);
        customerServiceForTest.AddCustomer("Test Customer");
    }
}