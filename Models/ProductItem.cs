using System;
using System.ComponentModel.DataAnnotations;

namespace KeepOnTruckin.Models
{
	public class ProductItem
	{
		public int Id { get; set; }
		public string? Title { get; set; }

		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }
		public string? Type { get; set; }
		public decimal Price { get; set; }
	}
}

