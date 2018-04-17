using System;

namespace ASOS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var customer = customerService.GetCustomer(new CustomerRequest{CustomerId = 1,IsCustomerArchived = false,RequestStartTime = DateTime.Now});

            System.Console.WriteLine(customer.Name);
            System.Console.Read();
        }
    }
}
