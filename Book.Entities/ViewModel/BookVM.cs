using Book.Entities.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.ViewModel
{
    public class BookVM
    {
        public Books book { get; set; }
        [ValidateNever]

        public IEnumerable<SelectListItem> CategoryList { get; set; }


    }
}
