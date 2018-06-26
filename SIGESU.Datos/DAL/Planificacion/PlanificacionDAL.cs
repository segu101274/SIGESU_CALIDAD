using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;

namespace SIGESU.Datos.DAL.Planificacion
{
    public class PlanificacionDAL : IPlanificacion
    {
        public Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionAct(Entidades.DTO_TP3.EPlanificacion entidadPlanificacion)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionAct(
                                        entidadPlanificacion.IdPlanificacion,
                                        entidadPlanificacion.IdEspecialista,
                                        entidadPlanificacion.IdLaboratorio,
                                        entidadPlanificacion.IdPlanificacionOrigen,
                                        entidadPlanificacion.NumeroPlanificacion,
                                        entidadPlanificacion.FechaInicio,
                                        entidadPlanificacion.FechaFin,
                                        entidadPlanificacion.TipoPlanificacion,
                                        entidadPlanificacion.TipoUrgencia,
                                        entidadPlanificacion.Observacion,
                                        entidadPlanificacion.Estado,
                                        entidadPlanificacion.COD_SUCURSAL).FirstOrDefault();

                    Entidades.DTO_TP3.ERespuesta oRespuesta =
                        Mapper.Map<Entidades.DTO_TP3.ERespuesta>(result);

                    return oRespuesta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionIns(string xml)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionIns(xml).FirstOrDefault();

                    Entidades.DTO_TP3.ERespuesta objRespuesta =
                        Mapper.Map<Entidades.DTO_TP3.ERespuesta>(result);

                    return objRespuesta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO_TP3.EPlanificacion> GCPS_SP_PlanificacionSel(string FechaInicio, string FechaFin)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionSel(FechaInicio, FechaFin).ToList();

                    List<Entidades.DTO_TP3.EPlanificacion> listaPlanificacion =
                        Mapper.Map<List<Entidades.DTO_TP3.EPlanificacion>>(result);

                    var data = listaPlanificacion.ToList();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO_TP3.EPlanificacion GCPS_SP_PlanificionSelxIdPlanificacion(int IdPlanificacion)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificionSelxIdPlanificacion(IdPlanificacion).FirstOrDefault();

                    Entidades.DTO_TP3.EPlanificacion oPlanificacion =
                        Mapper.Map<Entidades.DTO_TP3.EPlanificacion>(result);

                    return oPlanificacion;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ERespuesta SIGESU_PlanificacionAct(EPlanificacion entidadPlanificacion)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionAct(
                                entidadPlanificacion.IdPlanificacion,
                                entidadPlanificacion.NumeroPlanificacion,
                                entidadPlanificacion.FechaInicio,
                                entidadPlanificacion.FechaFin,
                                entidadPlanificacion.Remuestreo,
                                entidadPlanificacion.Observacion,
                                entidadPlanificacion.Estado,
                                entidadPlanificacion.IdEspecialista,
                                entidadPlanificacion.IdLaboratorio,
                                entidadPlanificacion.IdPlanificacionOrigen,
                                entidadPlanificacion.IdSucursalAlmacen
                        ).FirstOrDefault();

                    ERespuesta objRespuesta =
                        Mapper.Map<ERespuesta>(result);

                    return objRespuesta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ERespuesta SIGESU_PlanificacionIns(string xml)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionIns(xml).FirstOrDefault();

                    ERespuesta objRespuesta =
                        Mapper.Map<ERespuesta>(result);

                    return objRespuesta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EPlanificacion> SIGESU_PlanificacionSel(string FechaInicio, string FechaFin)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionSel(FechaInicio, FechaFin).ToList();

                    List<EPlanificacion> listaPlanificacion =
                            Mapper.Map<List<EPlanificacion>>(result);

                    var data = listaPlanificacion.ToList();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EPlanificacion SIGESU_PlanificacionSelUltimoGenerado()
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionSelUltimoGenerado().FirstOrDefault();

                    EPlanificacion objPlanifacion =
                        Mapper.Map<EPlanificacion>(result);

                    return objPlanifacion;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EPlanificacion SIGESU_PlanificacionSelxIdPlanificacion(int IdPlanificacion)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionSelxIdPlanificacion(IdPlanificacion).FirstOrDefault();

                    EPlanificacion objPlanifacion =
                        Mapper.Map<EPlanificacion>(result);

                    return objPlanifacion;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
