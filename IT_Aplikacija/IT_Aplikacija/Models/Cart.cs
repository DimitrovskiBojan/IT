using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Aplikacija.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        
        public string Name { get; set; }
        
        public int Weight { get; set; }
        
        public int Price { get; set; }
        
        public string Recommended_dose { get; set; }
       
        public string Expiration_date { get; set; }
        
        public string Company { get; set; }
        
        public string ImageURL { get; set; }
    }
}