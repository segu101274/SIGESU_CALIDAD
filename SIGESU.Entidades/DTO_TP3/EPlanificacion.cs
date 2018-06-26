using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Helpers;

namespace SIGESU.Entidades.DTO_TP3
{
    public class EPlanificacion
    {
        #region "Campos"
        public int IdPlanificacion { get; set; }
        public int IdEspecialista { get; set; }
        public int IdLaboratorio { get; set; }
        public Nullable<int> IdPlanificacionOrigen { get; set; }
        public string NumeroPlanificacion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string TipoPlanificacion { get; set; }
        public string TipoUrgencia { get; set; }
        public string Observacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string Estado { get; set; }

        public Nullable<bool> EsJustificado { get; set; }
        #endregion

        #region "Adicionales"
        public List<EPlanificacionDetalle> detallePlanificacion { get; set; }

        public List<EProducto> detalleProductos { get; set; }

        public List<EPlanificacionSucursal> ListaPlanificacionSucursal { get; set; }

        public string FechaInicioWithFormat
        {
            get { return Convert.ToDateTime(FechaInicio).ToString(Constantes.FormatosFecha.ddMMyyyy); }
        }

        public string FechaFinWithFormat
        {
            get { return Convert.ToDateTime(FechaFin).ToString(Constantes.FormatosFecha.ddMMyyyy); }
        }

        public string NombreEspecialista { get; set; }
        public string NombreLaboratorio { get; set; }

        public string TipoPlanificacionDescripcion
        {
            get
            {
                if (TipoPlanificacion.Equals("L"))
                {
                    return "Laboratorio";
                }
                else
                {
                    return "Campo";
                }
            } 
        }

        public string COD_SUCURSAL { get; set; }

        #endregion
    }
}
