using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.Models
{
	public class OrderDetail
	{
		public int Id { get; set; }
		public int OrderHeaderId { get; set; }
		[ValidateNever]
		public OrderHeader OrderHeader { get; set; }
		public int BookId { get; set; }
		[ValidateNever]
		public Books Book {  get; set; }
		public int Count { get; set; }
		public decimal Price { get; set; }

	}
}
