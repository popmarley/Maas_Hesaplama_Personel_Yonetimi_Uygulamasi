using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ARESDOKUM.Entity
{
	// Shifts Tablosu için sınıf
	public class Shift
	{
		[Key]
		public int ShiftId { get; set; }

		[Required]
		public int EmployeeId { get; set; }

		[ForeignKey("EmployeeId")]
		public Employee Employee { get; set; }

		public DateTime Date { get; set; }

		[Column(TypeName = "decimal(5, 2)")]
		public decimal HoursWorked { get; set; }

        [DefaultValue(false)] 
        public bool PaymentMade { get; set; }
    }
}
