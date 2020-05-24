using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Consult
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo de Consulta")]
        [MaxLength(50)]
        public string ConsultType { get; set; }

        [Required]
        [Display(Name = "Dia de Consulta")]
        public DateTime ConsultDate { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        public Veterinary Veterinary { get; set; }
        public Pet Pet { get; set; }
    }
}