using SIGESU_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGESU_API.Repositorios
{
    public class PlanificacionRepository
    {
        private static DB_A3CA54_segu101274Entities dataContext = new DB_A3CA54_segu101274Entities();
        public static List<GCPS_SP_APIPlanificacionxEspecialista_Result> GetAllPlanificacionxEspecialista(int IdEspecialista)
        {
            var planificacion = dataContext.GCPS_SP_APIPlanificacionxEspecialista(IdEspecialista).ToList();

            return planificacion;
        }

        public static List<GCPS_SP_APIPlanificacionDetallexIdPlanificacion_Result> GetPlanificacionDetallexIdPlanificacion(int IdPlanificacion)
        {
            var productos = dataContext.GCPS_SP_APIPlanificacionDetallexIdPlanificacion(IdPlanificacion).ToList();

            return productos;
        }

        public static List<GCPS_SP_APISucursalesxPlanificacion_Result> GetSucursalesxPlanificacion(int IdPlanificacion)
        {
            var sucursales = dataContext.GCPS_SP_APISucursalesxPlanificacion(IdPlanificacion).ToList();

            return sucursales;
        }

        public static List<GCPS_SP_APIAreasxSucursal_Result> GetAreasxSucursal(string COD_SUCURSAL)
        {
            var areas = dataContext.GCPS_SP_APIAreasxSucursal(COD_SUCURSAL).ToList();

            return areas;
        }

        public static List<GCPS_SP_APIAreaSucursalDistancia_Result> GetAreaSucursalDistancia(int IdPlanificacion, int IdAreaSucursal)
        {
            var distancias = dataContext.GCPS_SP_APIAreaSucursalDistancia(IdPlanificacion, IdAreaSucursal).ToList();

            return distancias;
        }

        public static GCPS_SP_APIESPECIALISTALOGIN_Result GetEspecialistaLogin(string codigo, string pwd)
        {
            var especialista = dataContext.GCPS_SP_APIESPECIALISTALOGIN(codigo, pwd).FirstOrDefault();

            return especialista;
        }

        public static GCPS_SP_APIProductoxCodigoBarra_Result GetProductoxCodigoBarra(string codigobarra)
        {
            var producto = dataContext.GCPS_SP_APIProductoxCodigoBarra(codigobarra).FirstOrDefault();

            return producto;
        }

        public static List<GCPS_SP_APIProductoObservacionxProducto_Result> GetProductoObservacionesxProducto(string cod_producto)
        {
            var observaciones = dataContext.GCPS_SP_APIProductoObservacionxProducto(cod_producto).ToList();

            return observaciones;
        }

        public static GCPS_SP_APIPlanificacionDetalleIns_Result InsertarDetallePlanificacion(int IdPlanificacion, string cod_producto,
                                                                                                int IdObservacion, string resultado)
        {
            var respuesta = dataContext.GCPS_SP_APIPlanificacionDetalleIns(IdPlanificacion, cod_producto, IdObservacion, resultado).FirstOrDefault();

            return respuesta;
        }
    }
}