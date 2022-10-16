using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Aplikacija.Models
{
    public class Supplement
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int Price { get; set; }
        public enum taste
        {
            Chocolate,
            Vanilla,
            Strawberry,
            Caramel,
            Banana,
            Neutral,
        }
        [Required]
        public taste Taste { get; set; }
        [Required]
        public string Recommended_dose { get; set; }
        [Required]
        public string Expiration_date { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string ImageURL { get; set; }
    }
}