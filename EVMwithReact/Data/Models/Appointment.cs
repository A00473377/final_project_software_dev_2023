using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVMwithReact.Data.Models
{
	public class Appointment
	{
        [Key]
        public int  AppointmentId { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        public TimeSpan AppointmentTime { get; set; }

        public int BranchId { get; set; }  //id of the branch that posted the appointment
        
	}
}

