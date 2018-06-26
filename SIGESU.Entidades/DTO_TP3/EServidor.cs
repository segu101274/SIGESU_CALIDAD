using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Helpers;

namespace SIGESU.Entidades.DTO_TP3
{
    public class EServidor
    {
        public System.DateTime FechaHoraActual { get; set; }
        public string NombreServidor { get; set; }

        //Adicionales
        public string FormatoGeneralFecha
        {
            get { return FechaHoraActual.ToString(Constantes.FormatosFecha.yyyyMMdd); }
        }

        public string FormatoFiltroFecha
        {
            get { return FechaHoraActual.ToString(Constantes.FormatosFecha.ddMMyyyy); }
        }
    }
}
