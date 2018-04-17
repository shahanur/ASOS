namespace ASOS.Console
{
    public class FailOverDataSourceHandler:ICustomerRequestHandler
    {
        public CustomerResponse GetResponse(CustomerRequest customerRequest)
        {
            var customer = new FailOverDataAccess().GetCustomer(customerRequest.CustomerId);
            return new CustomerResponse { Customer = customer, IsArchived = true };
        }

        public int Priority => 2;
    }
}