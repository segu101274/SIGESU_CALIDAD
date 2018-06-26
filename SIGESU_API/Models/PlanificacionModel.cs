using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGESU_API.Models
{
    public class PlanificacionModel
    {
        public int IdPlanificacion { get; set; }
        public int IdEspecialista { get; set; }
        public Nullable<int> IdLaboratorio { get; set; }
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
        public virtual ICollection<PlanificacionDetalleModel> GCPS_PLANIFICACION_DETALLE { get; set; }
    }
}