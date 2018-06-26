using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;
using SIGESU.Datos.EntityFramework;
using SIGESU.Helpers;
using AutoMapper;

namespace SIGESU.Datos.DAL.Sucursal
{
    public class SucursalDAL : ISucursal
    {
        public List<ESucursal> GCPS_SP_SucursalSelTodo()
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_SucursalSelTodo().Where(t => t.ESTADO == Constantes.EstadoSucursal.activo.ToString()).ToList();

                    List<ESucursal> listaSucursalAlmacen =
                            Mapper.Map<List<ESucursal>>(result);

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
