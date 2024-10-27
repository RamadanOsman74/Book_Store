using Book.Entities.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Book.entities.Models;

public class Category
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedTime { get; set; } = DateTime.Now;
    [ValidateNever]
    public List<Books> Books { get; set; }

}
