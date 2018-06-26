using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.PlanificacionLaboratorio;
using SIGESU.Datos.DAL.Servidor;
using SIGESU.Helpers;
namespace SIGESU.Negocio.BL
{
    public class PlanificacionLaboratorioBL
    {
        PlanificacionLaboratorioDAL objPlanificacionLaboratorio = new PlanificacionLaboratorioDAL();

        public List<EPlanificacionLaboratorio> SIGESU_PlanificacionLaboratorioSel(int? IdPlanificacion)
        {
            try
            {
                return objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioSel(IdPlanificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ERespuesta SIGESU_PlanificacionLaboratorioAct(EPlanificacionLaboratorio entidadPlanificacionLaboratorio)
        {
            try
            {
                return objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioAct(entidadPlanificacionLaboratorio);
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
                return objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioSelxIdPlanificacionLaboratorio(IdPlanificacionLaboratorio);
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
                return objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioActxIdPlanificacion(entidadPlanificacionLaboratorio);
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
                return objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioActxIdPlanificacionxImpresion(entidadPlanificacionLaboratorio);
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
                return objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioIns(IdPlanificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
