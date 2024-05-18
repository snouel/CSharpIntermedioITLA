using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DI
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public void AddCustomer(string customerName)
        {
            // Implementación falsa para pruebas unitarias
            Console.WriteLine($"Customer '{customerName}' added (fake implementation).");
        }
    }
}
