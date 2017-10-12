using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lizykitchen.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string ShortDescription { get; set; }

        [Required]
        [Display(Name = "Modo de Preparacion")]
        public string LongDescription { get; set; }

        [Required]
        [Display(Name = "Photo Url")]
        public string URLPhoto { get; set; }
    }
}