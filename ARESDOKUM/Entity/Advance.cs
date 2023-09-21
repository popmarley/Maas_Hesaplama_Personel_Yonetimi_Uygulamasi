using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ARESDOKUM.Entity
{
	// Advances Tablosu için sınıf
	public class Advance
	{
		[Key]
		public int AdvanceId { get; set; }

		[Required]
		public int EmployeeId { get; set; }

		[ForeignKey("EmployeeId")]
		public Employee Employee { get; set; }

		[Column(TypeName = "decimal(10, 2)")]
		public decimal Amount { get; set; }

		public DateTime RequestDate { get; set; }
	}
}
