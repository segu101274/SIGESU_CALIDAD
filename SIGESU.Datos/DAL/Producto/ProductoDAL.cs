using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;
using SIGESU.Helpers;

namespace SIGESU.Datos.DAL.Producto
{
    public class ProductoDAL : IProducto
    {
        public List<Entidades.DTO_TP3.EProducto> GCPS_SP_PlanificacionSelDetalle(int IdPlanificacion)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionSelDetalle(IdPlanificacion).ToList();

                    List<Entidades.DTO_TP3.EProducto> listaProducto =
                        Mapper.Map<List<Entidades.DTO_TP3.EProducto>>(result);

                    var data = listaProducto.ToList();

                    return data;
                }
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
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_ProductoEnPlanificacionSel().ToList();

                    List<Entidades.DTO_TP3.EProducto> listaProducto =
                        Mapper.Map<List<Entidades.DTO_TP3.EProducto>>(result);

                    var data = listaProducto.ToList();

                    return data;
                }
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
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_ProductoSelTodo().ToList();

                    List<Entidades.DTO_TP3.EProducto> lista =
                        Mapper.Map<List<Entidades.DTO_TP3.EProducto>>(result);

                    return lista;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO.EProducto SIGESU_ProductoSelAtributosxIdProducto(int IdProducto)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_ProductoSelAtributosxIdProducto(IdProducto).FirstOrDefault();

                    EProducto objProducto =
                        Mapper.Map<EProducto>(result);

                    return objProducto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO.EProducto> SIGESU_ProductoSelTodo()
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_ProductoSelTodo().Where(t => t.Estado == Constantes.EstadoProducto.activo).ToList();

                    List<Entidades.DTO.EProducto> listaProducto =
                            Mapper.Map<List<Entidades.DTO.EProducto>>(result);

                    var data = listaProducto.ToList();

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
