using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;
using SIGESU.Datos.DAL.Sucursal;

namespace SIGESU.Negocio.BL
{
    public class SucursalService
    {
        SucursalDAL objSucursal = new SucursalDAL();

        public List<ESucursal> GCPS_SP_SucursalSelTodo()
        {
            try
            {
                return objSucursal.GCPS_SP_SucursalSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
