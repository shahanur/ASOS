using System;

namespace ASOS.Console
{
    public interface ICustomerService
    {
        Customer GetCustomer(CustomerRequest request);
        
    }
}