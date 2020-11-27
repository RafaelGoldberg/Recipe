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
    public class Comment
    {
        [Required]
        [Display(Name = "Recipe")]
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public virtual RecipeData Recipe { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string UserComment { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
