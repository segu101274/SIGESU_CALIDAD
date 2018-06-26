using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Helpers;

namespace SIGESU.Entidades.DTO
{
    public class EPlanificacion
    {
        #region "Campos"
        public int IdPlanificacion { get; set; }
        public string NumeroPlanificacion { get; set; }
        public int IdProducto { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public Nullable<bool> Remuestreo { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdEspecialista { get; set; }
        public Nullable<int> IdLaboratorio { get; set; }
        public Nullable<int> IdPlanificacionOrigen { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }

        #endregion

        #region "Adicionales"
        public string NombreProducto { get; set; }
        public string Fabricante { get; set; }
        public string DescripcionFamilia { get; set; }
        public string NombreEspecialista { get; set; }
        public string NombreLaboratorio { get; set; }
        public string IdSucursalAlmacen { get; set; }
        public string NombreComposicion { get; set; }
        public string NombreCertificado { get; set; }
        public string FechaCreacionWithFormat
        {
            get { return Convert.ToDateTime(FechaCreacion).ToString(Constantes.FormatosFecha.ddMMyyyy); }
        }
        public string FechaInicioWithFormat
        {
            get { return Convert.ToDateTime(FechaInicio).ToString(Constantes.FormatosFecha.ddMMyyyy); }
        }

        public List<EPlanificacionSucursalAlmacen> ListaPlanificacionSucursalAlmacen { get; set; }

        #endregion


    }
}
