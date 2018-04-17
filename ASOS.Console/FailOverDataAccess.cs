namespace ASOS.Console
{
    public class FailOverDataAccess
    {
        public Customer GetCustomer(int id)
        {
            return new Customer {Id = 1, Name = "FailOverSourceCustomer"};

        }
    }
}