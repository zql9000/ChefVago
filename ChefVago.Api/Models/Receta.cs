using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefVago.Api.Models
{
    public class Receta
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public List<RecetaIngrrediente> Ingredientes { get; set; }
        public string Instrucciones { get; set; }
        public TipoReceta TipoReceta { get; set; }
    }

    public enum TipoReceta
    {
        Dulce,
        Saldado
    }
}
