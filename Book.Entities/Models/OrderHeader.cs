using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.Models
{
	public class OrderHeader
	{
		public int Id { get; set; }
		public string ApplicationUserId { get; set; }
		[ValidateNever]
		public ApplicationUser applicationUser { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime ShippingDate { get; set; }
		public decimal TotalPrice { get; set; }

		public string? OrderStatus { get; set;}
		public string? PaymentStatus { get; set; }
		public string? TrackingNumber { get; set; }
		public string? Carrier{ get; set; }

		public DateTime PaymentDate { get; set; }

		// stripe Props
		public string? SessionId { get; set;}
		public string? PaymentIntentId { get; set; }

		//Data of User

		public string Name { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		//[Required]
		//[Phone(ErrorMessage ="Please Enter Valid Number")]
		public string Phone { get; set; }
	}
}
