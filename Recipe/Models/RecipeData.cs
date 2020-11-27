using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe.Models
{
    public class RecipeData
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string  Title { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string LongDescription { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Directions { get; set; }

        [Required]
        public byte[] MainImage { get; set; }
        public byte[] PhotoTwo { get; set; }
        public byte[] PhotoThree { get; set; }
        public byte[] PhotoFour { get; set; }
        public byte[] PhotoFive { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime LastModifiedDate { get; set; }

    }
}
