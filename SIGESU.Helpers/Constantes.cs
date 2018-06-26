using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Helpers
{
    public static class Constantes
    {
        public struct FormatoCorrelativo
        {
            public const string fmt = "000.##";
        }
        public struct FormatosFecha
        {
            public const string ddMMyyyy = "dd/MM/yyyy";
            public const string yyyyMMdd = "yyyyMMdd";
            public const string ddMMyyyyHHmmss = "dd/MM/yyyy HH:mm:ss";
        }

        public struct EstadoProducto
        {
            public const int activo = 1;
        }

        public struct EstadoSucursal
        {
            public const string activo = "A";
        }

        public struct EstadoPlanificacion
        {
            public const int registrado = 0;
            public const int aprobado = 1;
            public const int desaprobado = 3;
            public const int terminado = 5;

            public const string TextRegistrado = "REGISTRADO";
            public const string TextAprobado = "APROBADO";
            public const string TextDesaprobado = "DESAPROBADO";
            public const string TextTerminado = "TERMINADO";
        }

        public struct TipoPlanificacion
        {
            public const string LABORATORIO = "L";
            public const string CAMPO = "C";
        }

    }
}
