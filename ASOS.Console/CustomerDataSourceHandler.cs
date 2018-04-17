using System;

namespace ASOS.Console
{
    public class CustomerDataSourceHandler : ICustomerRequestHandler
    {
        public CustomerResponse GetResponse(CustomerRequest customerRequest)
        {
            Customer customer = null;
            while (!customerRequest.IsFailOverMode && null == customer)
            {
                customerRequest.RetryCount++;
                customer = new CustomerDataAccess().GetCustomer(customerRequest.CustomerId);
                if (customerRequest.RequestStartTime != null && customerRequest.RetryCount > 5 &&
                     DateTime.Now.Subtract(customerRequest.RequestStartTime.Value).TotalSeconds < 10)
                    customerRequest.IsFailOverMode = true;
            }

            return new CustomerResponse {Customer = customer, IsArchived = true};

        }

        public int Priority => 1;

        
    }
}