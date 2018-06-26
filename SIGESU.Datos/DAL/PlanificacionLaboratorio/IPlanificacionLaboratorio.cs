using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO;

namespace SIGESU.Datos.DAL.PlanificacionLaboratorio
{
    public interface IPlanificacionLaboratorio
    {
        List<EPlanificacionLaboratorio> SIGESU_PlanificacionLaboratorioSel(int? IdPlanificacion);
        EPlanificacionLaboratorio SIGESU_PlanificacionLaboratorioSelxIdPlanificacionLaboratorio(int IdPlanificacionLaboratorio);
        ERespuesta SIGESU_PlanificacionLaboratorioAct(EPlanificacionLaboratorio entidadPlanificacionLaboratorio);
        ERespuesta SIGESU_PlanificacionLaboratorioActxIdPlanificacion(EPlanificacionLaboratorio entidadPlanificacionLaboratorio);
        ERespuesta SIGESU_PlanificacionLaboratorioIns(int IdPlanificacion);
        ERespuesta SIGESU_PlanificacionLaboratorioActxIdPlanificacionxImpresion(EPlanificacionLaboratorio entidadPlanificacionLaboratorio);
    }
}
