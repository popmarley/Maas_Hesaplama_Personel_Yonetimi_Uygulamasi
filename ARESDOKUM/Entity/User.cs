using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ARESDOKUM.Entity
{
	// Advances Tablosu için sınıf
	public class User
	{
		[Key]
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string UserPassword { get; set; }

		
	}
}
