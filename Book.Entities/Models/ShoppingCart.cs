using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Book.Entities.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        [ValidateNever]
        public Books Book { get; set; }
        [Range(1, 10, ErrorMessage = "You must enter value between 1 to 10")]
        public int Count { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

    }
}
