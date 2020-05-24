using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Manager
    {
        public int id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}