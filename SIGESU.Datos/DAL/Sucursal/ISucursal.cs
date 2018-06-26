using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;

namespace SIGESU.Datos.DAL.Sucursal
{
    public interface ISucursal
    {
        List<ESucursal> GCPS_SP_SucursalSelTodo();
    }
}
