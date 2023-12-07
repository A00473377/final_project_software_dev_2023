using System;
using System.ComponentModel.DataAnnotations;
namespace EVMwithReact.Data.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
        
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}