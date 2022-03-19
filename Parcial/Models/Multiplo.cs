using System;
using System.ComponentModel.DataAnnotations;

namespace Parcial.Models
{
    public class Multiplo
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Debe rellenar con un monto")]
        public Double Monto { get; set; }
       //[Range(1, 10, ErrorMessage = "El campo {0} debe estar entre la nota {1} y {2}")]
    }
}
