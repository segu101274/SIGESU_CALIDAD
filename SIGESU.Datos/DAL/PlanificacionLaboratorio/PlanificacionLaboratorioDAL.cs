using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;


namespace SIGESU.Datos.DAL.PlanificacionLaboratorio
{
    public class PlanificacionLaboratorioDAL : IPlanificacionLaboratorio
    {
        public ERespuesta SIGESU_PlanificacionLaboratorioAct(EPlanificacionLaboratorio entidadPlanificacionLaboratorio)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionLaboratorioAct(
                                    entidadPlanificacionLaboratorio.IdPlanificacionLaboratorio,
                                    entidadPlanificacionLaboratorio.NumeroVeces,
                                    entidadPlanificacionLaboratorio.Resultado,
                                    entidadPlanificacionLaboratorio.FechaCheckin,
                                    entidadPlanificacionLaboratorio.FechaeEdicion,
                                    entidadPlanificacionLaboratorio.FechaValidacion,
                                    entidadPlanificacionLaboratorio.FechaImpresion,
                                    entidadPlanificacionLaboratorio.AplicaRemuestreo,
                                    entidadPlanificacionLaboratorio.ResultadoAdverso
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

        public ERespuesta SIGESU_PlanificacionLaboratorioActxIdPlanificacion(EPlanificacionLaboratorio entidadPlanificacionLaboratorio)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionLaboratorioActxIdPlanificacion(
                                    entidadPlanificacionLaboratorio.IdPlanificacion,
                                    entidadPlanificacionLaboratorio.NumeroVeces,
                                    entidadPlanificacionLaboratorio.Resultado,
                                    entidadPlanificacionLaboratorio.FechaCheckin,
                                    entidadPlanificacionLaboratorio.FechaeEdicion,
                                    entidadPlanificacionLaboratorio.FechaValidacion,
                                    entidadPlanificacionLaboratorio.FechaImpresion,
                                    entidadPlanificacionLaboratorio.AplicaRemuestreo,
                                    entidadPlanificacionLaboratorio.ResultadoAdverso
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

        public ERespuesta SIGESU_PlanificacionLaboratorioActxIdPlanificacionxImpresion(EPlanificacionLaboratorio entidadPlanificacionLaboratorio)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionLaboratorioActxIdPlanificacionxImpresion(
                                    entidadPlanificacionLaboratorio.IdPlanificacion,
                                    entidadPlanificacionLaboratorio.NumeroVeces,
                                    entidadPlanificacionLaboratorio.Resultado,
                                    entidadPlanificacionLaboratorio.FechaCheckin,
                                    entidadPlanificacionLaboratorio.FechaeEdicion,
                                    entidadPlanificacionLaboratorio.FechaValidacion,
                                    entidadPlanificacionLaboratorio.FechaImpresion,
                                    entidadPlanificacionLaboratorio.AplicaRemuestreo,
                                    entidadPlanificacionLaboratorio.ResultadoAdverso
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

        public ERespuesta SIGESU_PlanificacionLaboratorioIns(int IdPlanificacion)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionLaboratorioIns(IdPlanificacion).FirstOrDefault();

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

        public List<EPlanificacionLaboratorio> SIGESU_PlanificacionLaboratorioSel(int? IdPlanificacion)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionLaboratorioSel(IdPlanificacion);

                    List<EPlanificacionLaboratorio> listaPlanificacionLaboratorio =
                        Mapper.Map<List<EPlanificacionLaboratorio>>(result);

                    return listaPlanificacionLaboratorio;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EPlanificacionLaboratorio SIGESU_PlanificacionLaboratorioSelxIdPlanificacionLaboratorio(int IdPlanificacionLaboratorio)
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_PlanificacionLaboratorioSelxIdPlanificacionLaboratorio(IdPlanificacionLaboratorio).FirstOrDefault();

                    EPlanificacionLaboratorio listaPlanificacionLaboratorio =
                        Mapper.Map<EPlanificacionLaboratorio>(result);

                    return listaPlanificacionLaboratorio;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
