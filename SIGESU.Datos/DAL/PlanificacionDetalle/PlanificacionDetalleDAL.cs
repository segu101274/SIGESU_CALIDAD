using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO_TP3;

namespace SIGESU.Datos.DAL.PlanificacionDetalle
{
    public class PlanificacionDetalleDAL : IPlanificacionDetalle
    {
        public Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionDetalleAct(EPlanificacionDetalle oPlanificacionDetalle)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionDetalleAct(oPlanificacionDetalle.IdPlanificacionDetalle,
                                                                    oPlanificacionDetalle.Resultado,
                                                                    oPlanificacionDetalle.FechaCheckin,
                                                                    oPlanificacionDetalle.FechaEdicion,
                                                                    oPlanificacionDetalle.FechaValidacion,
                                                                    oPlanificacionDetalle.FechaImpresion).FirstOrDefault();

                    Entidades.DTO_TP3.ERespuesta respuesta =
                        Mapper.Map<Entidades.DTO_TP3.ERespuesta>(result);

                    return respuesta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionDetalleActxCheckin(EPlanificacionDetalle oPlanificacionDetalle)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionDetalleActxCheckin(oPlanificacionDetalle.IdPlanificacion,
                                                                                    oPlanificacionDetalle.COD_PRODUCTO,
                                                                                    oPlanificacionDetalle.FechaCheckin).FirstOrDefault();

                    Entidades.DTO_TP3.ERespuesta respuesta =
                        Mapper.Map<Entidades.DTO_TP3.ERespuesta>(result);

                    return respuesta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EPlanificacionDetalle GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(int IdPlanificacionDetalle)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(IdPlanificacionDetalle).FirstOrDefault();

                    EPlanificacionDetalle entidadPlanificacionDetalle =
                        Mapper.Map<EPlanificacionDetalle>(result);

                    return entidadPlanificacionDetalle;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EPlanificacionDetalle> GCPS_SP_PlanificacionLaboratorioSel(int? IdPlanificacion)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_PlanificacionLaboratorioSel(IdPlanificacion);

                    List<EPlanificacionDetalle> listadoPlanificacionDetalle =
                        Mapper.Map<List<EPlanificacionDetalle>>(result);

                    return listadoPlanificacionDetalle;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
