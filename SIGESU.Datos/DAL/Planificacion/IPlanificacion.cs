using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO;

namespace SIGESU.Datos.DAL.Planificacion
{
    public interface IPlanificacion
    {
        List<EPlanificacion> SIGESU_PlanificacionSel(string FechaInicio, string FechaFin);
        ERespuesta SIGESU_PlanificacionIns(string xml);
        EPlanificacion SIGESU_PlanificacionSelUltimoGenerado();
        ERespuesta SIGESU_PlanificacionAct(EPlanificacion entidadPlanificacion);
        EPlanificacion SIGESU_PlanificacionSelxIdPlanificacion(int IdPlanificacion);

        Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionIns(string xml);

        List<Entidades.DTO_TP3.EPlanificacion> GCPS_SP_PlanificacionSel(string FechaInicio, string FechaFin);

        Entidades.DTO_TP3.EPlanificacion GCPS_SP_PlanificionSelxIdPlanificacion(int IdPlanificacion);

        Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionAct(Entidades.DTO_TP3.EPlanificacion entidadPlanificacion);

    }
}
