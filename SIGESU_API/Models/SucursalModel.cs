using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGESU_API.Models
{
    public class SucursalModel
    {
        public int SUCURSALID { get; set; }
        public string COD_SUCURSAL { get; set; }
        public string COD_CADENA_AUTOSERVICIO { get; set; }
        public string NOMBRE_SUCURSAL { get; set; }
        public string DESCRIP_SUCURSAL { get; set; }
        public string OBS_SUCURSAL { get; set; }
        public string LOGO_SUCURSAL { get; set; }
        public string ESTADO { get; set; }
        public string FECHA_REGISTRO { get; set; }
        public string HORA_REGISTRO { get; set; }
        public string USUARIO_REGISTRO { get; set; }
        public virtual ICollection<PlanificacionModel> GCPS_PLANIFICACION { get; set; }
    }
}