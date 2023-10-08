using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace ARESDOKUM.Entity
{
	public class Employee
	{
		[Key]
		public int EmployeeId { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; }

		[Column(TypeName = "decimal(10, 2)")]
		public decimal BaseHourlyRate { get; set; }

		public DateTime DateOfStart { get; set; } = DateTime.Now;

	}
}
