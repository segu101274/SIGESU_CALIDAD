//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGESU.Datos.EntityFramework
{
    using System;
    
    public partial class SIGESU_PlanificacionSelxIdPlanificacion_Result
    {
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
        public string IdSucursalAlmacen { get; set; }
        public string NombreComposicion { get; set; }
        public string Fabricante { get; set; }
        public string DescripcionFamilia { get; set; }
        public string NombreCertificado { get; set; }
    }
}
