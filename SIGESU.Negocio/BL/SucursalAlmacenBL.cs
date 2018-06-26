using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.SurcursalAlmacen;

namespace SIGESU.Negocio.BL
{
    public class SucursalAlmacenBL
    {
        SucursalAlmacenDAL objSucursalAlmacen = new SucursalAlmacenDAL();

        public List<ESurcursalAlmacen> SIGESU_SucursalAlmacenSelTodo()
        {
            try
            {
                return objSucursalAlmacen.SIGESU_SucursalAlmacenSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
