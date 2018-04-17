namespace ASOS.Console
{
    public class ArchivedDataRequestHandler:ICustomerRequestHandler
    {
        public CustomerResponse GetResponse(CustomerRequest customerRequest)
        {
            Customer customer = null;
            if(customerRequest.IsCustomerArchived)
                customer = new ArchivedDataService().GetCustomer(customerRequest.CustomerId);
            return new CustomerResponse { Customer = customer, IsArchived = true };
        }
        public int Priority => 3;
    }
}