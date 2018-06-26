using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGESU_API.Models
{
    public class ProductoModel
    {

        public int PRODUCTOID { get; set; }
        public string COD_PRODUCTO { get; set; }
        public string COD_UNIDADMEDIDA { get; set; }
        public string COD_MARCA { get; set; }
        public string COD_TIPO { get; set; }
        public string CODIGOBARRAS { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public string DESCRIP_PRODUCTO { get; set; }
        public string PRESENT_PRODUCTO { get; set; }
        public string OBS_PRODUCTO { get; set; }
        public string FOTO_PRODUCTO { get; set; }
        public string ESTADO { get; set; }
        public string FECHA_REGISTRO { get; set; }
        public string HORA_REGISTRO { get; set; }
        public string USUARIO_REGISTRO { get; set; }
        public Nullable<int> CNTPLAN_PRODUCTO { get; set; }

        public virtual ICollection<PlanificacionDetalleModel> GCPS_PLANIFICACION_DETALLE { get; set; }
    }
}