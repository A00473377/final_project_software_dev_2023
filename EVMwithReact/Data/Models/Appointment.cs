using System;
using System.ComponentModel.DataAnnotations;

namespace EVMwithReact.Data.Models
{
	public class Appointment
	{
        [Key]
        public int AppointmentId { get; set; }


        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        public TimeSpan AppointmentTime { get; set; }
        //// Foreign key to Company
        
        public int CompanyId { get; set; }
        
        
	}
}

