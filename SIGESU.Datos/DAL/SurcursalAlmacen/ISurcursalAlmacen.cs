using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO;

namespace SIGESU.Datos.DAL.SurcursalAlmacen
{
    public interface ISurcursalAlmacen
    {
        List<ESurcursalAlmacen> SIGESU_SucursalAlmacenSelTodo();
    }
}
