using System;
namespace EVMwithReact.Data.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public string TypeOfCreditCard { get; set; }

        public string CardNumber { get; set; }

        public string ExpirationDate { get; set; }

        public string EmailAddress { get; set; }

        // Add other properties as needed for your specific requirements
    }

}

