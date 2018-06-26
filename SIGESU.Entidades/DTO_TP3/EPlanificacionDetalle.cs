using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Helpers;

namespace SIGESU.Entidades.DTO_TP3
{
    public class EPlanificacionDetalle
    {
        #region "Campos Tabla"
        public int IdPlanificacion { get; set; }
        public string COD_PRODUCTO { get; set; }
        public Nullable<int> IdPrueba { get; set; }
        public Nullable<int> IdObservacion { get; set; }
        public string Resultado { get; set; }
        public string RangoInferior { get; set; }
        public string RangoSuperior { get; set; }
        public Nullable<System.DateTime> FechaCheckin { get; set; }
        public Nullable<System.DateTime> FechaEdicion { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaValidacion { get; set; }
        public Nullable<System.DateTime> FechaImpresion { get; set; }
        public int IdPlanificacionDetalle { get; set; }
        #endregion

        #region "Adicionales"
        public string NumeroPlanificacion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public string NombrePrueba { get; set; }
        public string NombreLaboratorio { get; set; }
        public string NombreEspecialista { get; set; }
        public string EstadoResultado { get; set; }

        public string FechaInicioWithFormat
        {
            get { return Convert.ToDateTime(FechaInicio).ToString(Constantes.FormatosFecha.ddMMyyyy); }
        }
        public string FechaCheckinWithFormat
        {
            get
            {
                if (FechaCheckin == null) { return ""; } else { return Convert.ToDateTime(FechaCheckin).ToString(Constantes.FormatosFecha.ddMMyyyyHHmmss); }
            }
        }
        public string FechaValidacionWithFormat
        {
            get
            {
                if (FechaValidacion == null) { return ""; } else { return Convert.ToDateTime(FechaValidacion).ToString(Constantes.FormatosFecha.ddMMyyyyHHmmss); }
            }
        }

        public string FechaImpresionWithFormat
        {
            get
            {
                if (FechaImpresion == null) { return ""; } else { return Convert.ToDateTime(FechaImpresion).ToString(Constantes.FormatosFecha.ddMMyyyyHHmmss); }
            }
        }
        #endregion

    }
}
