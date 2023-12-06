using System;
using System.ComponentModel.DataAnnotations;
namespace EVMwithReact.Data.Models
{
	public class Transaction
	{
		public int TransactionId { get; set; }

		public string userId { get; set; }	//this will store the Userid wo is douing the transaction
		public string paymentId { get; set; }
		public DateTime date { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public Boolean status { get; set; }
	}
}

