using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO;
using SIGESU.Entidades.DTO_TP3;

namespace SIGESU.Datos.AutoMapper
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            ConfigureUserMapping();

        }

        private static void ConfigureUserMapping()
        {
            Mapper.Initialize(cfg =>
            {
                #region "SIGESU ANTIGUO"
                cfg.CreateMap<SIGESU_PlanificacionSel_Result, SIGESU.Entidades.DTO.EPlanificacion>().ReverseMap();
                cfg.CreateMap<SIGESU_ProductoSelTodo_Result, SIGESU.Entidades.DTO.EProducto>().ReverseMap();
                cfg.CreateMap<SIGESU_LaboratorioSelTodo_Result, SIGESU.Entidades.DTO.ELaboratorio>().ReverseMap();
                cfg.CreateMap<SIGESU_EspecialistaSelTodo_Result, SIGESU.Entidades.DTO.EEspecialista>().ReverseMap();
                cfg.CreateMap<SIGESU_ProductoSelAtributosxIdProducto_Result, SIGESU.Entidades.DTO.EProducto>().ReverseMap();
                cfg.CreateMap<SIGESU_SucursalAlmacenSelTodo_Result, ESurcursalAlmacen>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionIns_Result, SIGESU.Entidades.DTO.ERespuesta>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionSelUltimoGenerado_Result, SIGESU.Entidades.DTO.EPlanificacion>().ReverseMap();
                cfg.CreateMap<SIGESU_ServidorSel_Result, SIGESU.Entidades.DTO.EServidor>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionAct_Result, SIGESU.Entidades.DTO.ERespuesta>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionSelxIdPlanificacion_Result, SIGESU.Entidades.DTO.EPlanificacion>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionLaboratorioSel_Result, EPlanificacionLaboratorio>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionLaboratorioSelxIdPlanificacionLaboratorio_Result, EPlanificacionLaboratorio>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionLaboratorioAct_Result, SIGESU.Entidades.DTO.ERespuesta>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionLaboratorioActxIdPlanificacion_Result, SIGESU.Entidades.DTO.ERespuesta>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionLaboratorioIns_Result, SIGESU.Entidades.DTO.ERespuesta>().ReverseMap();
                cfg.CreateMap<SIGESU_PlanificacionLaboratorioActxIdPlanificacionxImpresion_Result, SIGESU.Entidades.DTO.ERespuesta>().ReverseMap();
                #endregion


                #region "PROYECTO TP3"
                cfg.CreateMap<GCPS_SP_EspecialistaSelTodo_Result, SIGESU.Entidades.DTO_TP3.EEspecialista>().ReverseMap();
                cfg.CreateMap<GCPS_SP_ProductoSelTodo_Result, SIGESU.Entidades.DTO_TP3.EProducto>().ReverseMap();
                cfg.CreateMap<GCPS_SP_ServidorSel_Result, SIGESU.Entidades.DTO_TP3.EServidor>().ReverseMap();
                cfg.CreateMap<GCPS_SP_SucursalSelTodo_Result, SIGESU.Entidades.DTO_TP3.ESucursal>().ReverseMap();
                cfg.CreateMap<GCPS_SP_ProductoSelAtributosxIdProducto_Result, SIGESU.Entidades.DTO_TP3.EProducto>().ReverseMap();
                cfg.CreateMap<GCPS_SP_ProductoEnPlanificacionSel_Result, SIGESU.Entidades.DTO_TP3.EProducto>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionIns_Result, SIGESU.Entidades.DTO_TP3.ERespuesta>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionSel_Result, SIGESU.Entidades.DTO_TP3.EPlanificacion>().ReverseMap();
                cfg.CreateMap<GCPS_SP_LaboratorioSelTodo_Result, SIGESU.Entidades.DTO_TP3.ELaboratorio>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionSelDetalle_Result, SIGESU.Entidades.DTO_TP3.EProducto>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificionSelxIdPlanificacion_Result, SIGESU.Entidades.DTO_TP3.EPlanificacion>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionAct_Result, SIGESU.Entidades.DTO_TP3.ERespuesta>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionLaboratorioSel_Result, SIGESU.Entidades.DTO_TP3.EPlanificacionDetalle>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionDetalleAct_Result, SIGESU.Entidades.DTO_TP3.ERespuesta>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle_Result, SIGESU.Entidades.DTO_TP3.EPlanificacionDetalle>().ReverseMap();
                cfg.CreateMap<GCPS_SP_PlanificacionDetalleActxCheckin_Result, SIGESU.Entidades.DTO_TP3.ERespuesta>().ReverseMap();
                cfg.CreateMap<GCPS_SP_EquipmentSel_Result, SIGESU.Entidades.DTO_TP3.EEquipment>().ReverseMap();
                cfg.CreateMap<GCPS_SP_QCEquipmentPruebaSelxIdEquipment_Result, SIGESU.Entidades.DTO_TP3.EEquipmentPrueba>().ReverseMap();
                cfg.CreateMap<GCPS_SP_QC_LEVEY_JENNINGS_Result, SIGESU.Entidades.DTO_TP3.ELeveyJennings>().ReverseMap();
                cfg.CreateMap<GCPS_SP_ReporteCampo_Result, SIGESU.Entidades.DTO_TP3.EReporte>().ReverseMap();
                cfg.CreateMap<GCPS_SP_ObservacionesSugerenciasSel_Result, SIGESU.Entidades.DTO_TP3.EObservacionSugerencia>().ReverseMap();
                #endregion
            });
        }
    }
}
