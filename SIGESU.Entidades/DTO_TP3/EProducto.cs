using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Entidades.DTO_TP3
{
    public class EProducto
    {
        #region "Campos"
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
        #endregion

        #region "Adicionales"

        public Nullable<int> TOTALFALLAS { get; set; }
        public Nullable<int> TOTALPLANES { get; set; }
        public Nullable<decimal> PORCENTAJE { get; set; }
        public string TIPOPLAN { get; set; }

        public string NOMBRE_CATEGORIA { get; set; }
        public string NOMBRE_MARCA { get; set; }
        public string NombreComposicion { get; set; }

        #endregion
    }
}
