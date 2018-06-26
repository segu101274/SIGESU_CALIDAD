using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;

namespace SIGESU.Datos.DAL.PlanificacionDetalle
{
    public interface IPlanificacionDetalle
    {
        List<EPlanificacionDetalle> GCPS_SP_PlanificacionLaboratorioSel(int? IdPlanificacion);
        ERespuesta GCPS_SP_PlanificacionDetalleAct(Entidades.DTO_TP3.EPlanificacionDetalle oPlanificacionDetalle);

        EPlanificacionDetalle GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(int IdPlanificacionDetalle);

        ERespuesta GCPS_SP_PlanificacionDetalleActxCheckin(Entidades.DTO_TP3.EPlanificacionDetalle oPlanificacionDetalle);
    }
}
