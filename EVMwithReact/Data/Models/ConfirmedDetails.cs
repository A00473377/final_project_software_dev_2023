using System;
using System.ComponentModel.DataAnnotations;

namespace EVMwithReact.Data.Models
{
	public class ConfirmedDetails
	{
		[Key]
		public int CDId { get; set; } //To store the unique id

		public User user { get; set; } //Foreign key mapped to User Details
		public Appointment appointment { get; set; }	// Foreign key mapped to Appointments
	}
}

