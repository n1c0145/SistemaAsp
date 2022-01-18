using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaAsp.Models.ViewModels
{
    public class EmpleadosViewModel
    {
        public int Id { get; set; }
        [Required]
        
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required]

        [Display(Name = "Edad")]
        public int edad { get; set; }
        [Required]

        [Display(Name = "Telefono")]
        public int telefono { get; set; }
        [Required]

        [Display(Name = "Direccion")]
        public string direccion { get; set; }
        [Required]

        [Display(Name = "Empresa")]
        public string empresa { get; set; }
        [Required]

        [Display(Name = "Departamento")]
        public string departamento { get; set; }

    }
}