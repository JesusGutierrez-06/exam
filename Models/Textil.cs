using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTextil.Models
{
    public class Textil
    {
        [Key]
        public int id { get; set; }
        public string marca { get; set; }
        public string ancho { get; set; }
        public string largo { get; set; }
        public string tipo { get; set; }
        public string color { get; set; }
        public string pais { get; set; }
        public bool estado { get; set; }
    }
}
