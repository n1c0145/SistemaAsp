using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAsp.Models.ViewModels
{
    public class ListTablaEmpleados
    {
        public int Id {get; set;}
        public string nombre {get; set;}
        public int edad { get; set;}
         public int telefono { get; set;}
        public string direccion { get; set;}
        public string empresa { get; set;}
        public string departamento { get; set;}

    }
}