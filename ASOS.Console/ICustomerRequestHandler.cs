namespace ASOS.Console
{
    public interface ICustomerRequestHandler
    {
        CustomerResponse GetResponse(CustomerRequest customerRequest);
        int Priority { get;}
    }
}