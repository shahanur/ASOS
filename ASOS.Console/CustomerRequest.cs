using System;

namespace ASOS.Console
{
    public class CustomerRequest
    {
        public int CustomerId { get; set; }
        public DateTime? RequestStartTime { get; set; }
        public int RetryCount { get; set; }
        public bool IsCustomerArchived { get; set; }
        public bool IsFailOverMode { get; set; }
    }
}