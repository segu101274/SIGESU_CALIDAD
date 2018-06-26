using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.PlanificacionDetalle;
using SIGESU.Datos.DAL.Servidor;
using SIGESU.Helpers;

namespace SIGESU.Negocio.BL
{
    public class PlanificacionDetalleBL
    {
        PlanificacionDetalleDAL objPlanificacionDetalle = new PlanificacionDetalleDAL();
        public List<Entidades.DTO_TP3.EPlanificacionDetalle> GCPS_SP_PlanificacionLaboratorioSel(int? IdPlanificacion)
        {
            try
            {
                return objPlanificacionDetalle.GCPS_SP_PlanificacionLaboratorioSel(IdPlanificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionDetalleAct(Entidades.DTO_TP3.EPlanificacionDetalle oPlanificacionDetalle)
        {
            try
            {
                return objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleAct(oPlanificacionDetalle);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO_TP3.EPlanificacionDetalle GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(int IdPlanificacionDetalle)
        {
            try
            {
                return objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(IdPlanificacionDetalle);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionDetalleActxCheckin(Entidades.DTO_TP3.EPlanificacionDetalle oPlanificacionDetalle)
        {
            try
            {
                return objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleActxCheckin(oPlanificacionDetalle);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
