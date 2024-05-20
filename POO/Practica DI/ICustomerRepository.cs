using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DI
{
    public interface ICustomerRepository
    {
        void AddCustomer(string customerName);
    }
}
