using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefVago.Api.Models
{
    public class RecetaIngrrediente
    {
        public long Id { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; } //Gramo, Litro
    }
}
