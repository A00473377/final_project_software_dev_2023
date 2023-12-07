using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int CompanyId { get; set; }  //id of the company that posted the appointment
        
	}
}

