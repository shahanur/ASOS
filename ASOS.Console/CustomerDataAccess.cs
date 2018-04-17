namespace ASOS.Console
{
    public class CustomerDataAccess
    {
        public Customer GetCustomer(int id)
        {

            return new Customer {Id = 1, Name = "OriginalDataSoruce"};
        }
    }
}