using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Entidades.DTO
{
    public class EProducto
    {
        #region "Campos"
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Familia { get; set; }
        public string Fabricante { get; set; }
        public Nullable<int> IdProductoFamilia { get; set; }
        public Nullable<int> Estado { get; set; }
        #endregion

        #region "Adicionales"
        public string NombreCertificado { get; set; }
        public string NombreComposicion { get; set; }
        public string DescripcionFamilia { get; set; }
        #endregion

    }
}
