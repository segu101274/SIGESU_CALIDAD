using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Entidades.DTO_TP3
{
    public class EObservacionSugerencia
    {
        public int IdObservacionSugerencia { get; set; }
        public int IdObservacion { get; set; }
        public Nullable<decimal> PorcentajeMin { get; set; }
        public Nullable<decimal> PorcentajeMax { get; set; }
        public string Sugerencia { get; set; }

        public string Descripcion { get; set; }
    }
}
