using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.Producto;

namespace SIGESU.Negocio.BL
{
    public class ProductoBL
    {
        ProductoDAL objProducto = new ProductoDAL();

        public List<EProducto> SIGESU_ProductoSelTodo()
        {
            try
            {
                return objProducto.SIGESU_ProductoSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EProducto SIGESU_ProductoSelAtributosxIdProducto(int IdProducto)
        {
            try
            {
                return objProducto.SIGESU_ProductoSelAtributosxIdProducto(IdProducto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO_TP3.EProducto> GCPS_SP_ProductoEnPlanificacionSel()
        {
            try
            {
                return objProducto.GCPS_SP_ProductoEnPlanificacionSel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO_TP3.EProducto> GCPS_SP_PlanificacionSelDetalle(int IdPlanificacion)
        {
            try
            {
                return objProducto.GCPS_SP_PlanificacionSelDetalle(IdPlanificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO_TP3.EProducto> GCPS_SP_ProductoSelTodo()
        {
            try
            {
                return objProducto.GCPS_SP_ProductoSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
