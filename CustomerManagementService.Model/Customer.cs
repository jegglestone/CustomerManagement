using System;

namespace CustomerManagementService.Model
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNo { get; set; }

        public bool IsActive { get; set; }

        public Guid AddressId { get; set; }
    }
}
