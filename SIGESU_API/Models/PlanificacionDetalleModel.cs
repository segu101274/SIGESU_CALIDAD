using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGESU_API.Models
{
    public class PlanificacionDetalleModel
    {
        public int IdPlanificacionDetalle { get; set; }
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

        public virtual PlanificacionModel GCPS_PLANIFICACION { get; set; }
        public virtual ProductoModel GINV_TBL001_PRODUCTO { get; set; }
    }
}