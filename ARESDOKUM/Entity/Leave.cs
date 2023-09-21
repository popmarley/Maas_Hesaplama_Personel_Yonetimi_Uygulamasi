using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ARESDOKUM.Entity
{
	// Leaves Tablosu için sınıf
	public class Leave
	{
		[Key]
		public int LeaveId { get; set; }

		[Required]
		public int EmployeeId { get; set; }

		[ForeignKey("EmployeeId")]
		public Employee Employee { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		[MaxLength(255)]
		public string Reason { get; set; }
	}
}
