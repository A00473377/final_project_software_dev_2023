using System;
using System.ComponentModel.DataAnnotations;

namespace EVMwithReact.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string UserName { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNo { get; set; }
        
        public string Address { get; set; }
        
        public string Password { get; set; }


        // Add other user details as needed
    }
}