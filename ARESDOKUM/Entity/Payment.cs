using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ARESDOKUM.Entity
{
	// Payments Tablosu için sınıf
	public class Payment
	{
		[Key]
		public int PaymentId { get; set; }

		[Required]
		public int EmployeeId { get; set; }

		[ForeignKey("EmployeeId")]
		public Employee Employee { get; set; }

		[Column(TypeName = "decimal(10, 2)")]
		public decimal Amount { get; set; }

		public DateTime PaymentDate { get; set; }

		[MaxLength(255)]
		public string Description { get; set; }
	}
}
