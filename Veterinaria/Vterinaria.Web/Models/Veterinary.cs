using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Veterinary
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(50)]
        public string Description { get; set; }
        public string ImgUrl { get; set; }

        ICollection<Consult> Consults { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}