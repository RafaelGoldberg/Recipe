using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe.Models
{
    [Keyless]
    public class RecipeCategory
    {
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Required]
        [Display(Name = "Recipe")]
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public virtual RecipeData Recipe { get; set; }

    }
}
