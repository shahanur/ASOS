using System.Collections.Generic;
using System.Linq;

namespace ASOS.Console
{
    public class CustomerService:ICustomerService
    {

        public Customer GetCustomer(CustomerRequest request)
        {
            Customer customer = null;
            var requestHandlers = new List<ICustomerRequestHandler>
            {
                new ArchivedDataRequestHandler(),
                new CustomerDataSourceHandler(),
                new FailOverDataSourceHandler()
            };

            foreach (var customerRequestHandler in requestHandlers.OrderBy(rqh => rqh.Priority))
            {
                customer = customerRequestHandler.GetResponse(request).Customer;
                if(null != customer)
                    break;
            }

            return customer;
        }
    }
}