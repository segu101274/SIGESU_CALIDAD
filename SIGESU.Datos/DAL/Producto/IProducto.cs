using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO;

namespace SIGESU.Datos.DAL.Producto
{
    public interface IProducto
    {
        List<EProducto> SIGESU_ProductoSelTodo();
        EProducto SIGESU_ProductoSelAtributosxIdProducto(int IdProducto);

        List<Entidades.DTO_TP3.EProducto> GCPS_SP_ProductoEnPlanificacionSel();

        List<Entidades.DTO_TP3.EProducto> GCPS_SP_PlanificacionSelDetalle(int IdPlanificacion);

        List<Entidades.DTO_TP3.EProducto> GCPS_SP_ProductoSelTodo();
    }
}
