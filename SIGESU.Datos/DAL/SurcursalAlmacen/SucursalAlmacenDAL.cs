using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;
using SIGESU.Helpers;

namespace SIGESU.Datos.DAL.SurcursalAlmacen
{
    public class SucursalAlmacenDAL : ISurcursalAlmacen
    {
        public List<ESurcursalAlmacen> SIGESU_SucursalAlmacenSelTodo()
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_SucursalAlmacenSelTodo().Where(t => t.Estado == Constantes.EstadoProducto.activo.ToString()).ToList();

                    List<ESurcursalAlmacen> listaSucursalAlmacen =
                            Mapper.Map<List<ESurcursalAlmacen>>(result);

                    var data = listaSucursalAlmacen.ToList();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
