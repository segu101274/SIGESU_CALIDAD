using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.Planificacion;
using SIGESU.Datos.DAL.Servidor;
using SIGESU.Helpers;

namespace SIGESU.Negocio.BL
{
    public class PlanificacionBL
    {
        PlanificacionDAL objPlanificacion = new PlanificacionDAL();
        ServidorDAL objServidor = new ServidorDAL();

        public List<EPlanificacion> SIGESU_PlanificacionSel(string FechaInicio, string FechaFin)
        {
            try
            {
                return objPlanificacion.SIGESU_PlanificacionSel(FechaInicio, FechaFin);
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
                return objPlanificacion.SIGESU_PlanificacionIns(xml);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string SIGESU_PlanificacionSelUltimoGenerado()
        {
            string NumeroPlanifacion = string.Empty;
            string FormatoCorrelativo = string.Empty;
            int IdPlanificacion = 0;
            EPlanificacion entidadPlanificacion;

            try
            {
                entidadPlanificacion = objPlanificacion.SIGESU_PlanificacionSelUltimoGenerado();
                if (entidadPlanificacion == null) { IdPlanificacion = 1; } else { IdPlanificacion = entidadPlanificacion.IdPlanificacion + 1; }

                FormatoCorrelativo = IdPlanificacion.ToString().PadLeft(3, '0');

                NumeroPlanifacion = objServidor.SIGESU_ServidorSel().FechaHoraActual.ToString(Constantes.FormatosFecha.yyyyMMdd);

                NumeroPlanifacion = "PCP" + NumeroPlanifacion + "_" + FormatoCorrelativo;

                return NumeroPlanifacion;
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
                return objPlanificacion.SIGESU_PlanificacionSelxIdPlanificacion(IdPlanificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EPlanificacion> PlanificacionSelHistoricoxPeriodo(string FechaInicio, string FechaFin)
        {
            try
            {

                FechaInicio = Convert.ToDateTime(FechaInicio).ToString(Constantes.FormatosFecha.yyyyMMdd);
                FechaFin = Convert.ToDateTime(FechaFin).ToString(Constantes.FormatosFecha.yyyyMMdd);

                return objPlanificacion.SIGESU_PlanificacionSel(FechaInicio, FechaFin).
                    Where(x => x.Estado.Equals(Constantes.EstadoPlanificacion.TextTerminado)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EPlanificacion> PlanificacionSelAprobadoxPeriodo(string FechaInicio, string FechaFin)
        {
            try
            {

                FechaInicio = Convert.ToDateTime(FechaInicio).ToString(Constantes.FormatosFecha.yyyyMMdd);
                FechaFin = Convert.ToDateTime(FechaFin).ToString(Constantes.FormatosFecha.yyyyMMdd);

                return objPlanificacion.SIGESU_PlanificacionSel(FechaInicio, FechaFin).
                    Where(x => x.Estado.Equals(Constantes.EstadoPlanificacion.TextAprobado)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO_TP3.EPlanificacion> PlanificacionSelAprobadoxPeriodo2(string FechaInicio, string FechaFin)
        {
            try
            {

                FechaInicio = Convert.ToDateTime(FechaInicio).ToString(Constantes.FormatosFecha.yyyyMMdd);
                FechaFin = Convert.ToDateTime(FechaFin).ToString(Constantes.FormatosFecha.yyyyMMdd);

                return objPlanificacion.GCPS_SP_PlanificacionSel(FechaInicio, FechaFin).
                    Where(x => x.Estado.Equals(Constantes.EstadoPlanificacion.TextAprobado) && x.TipoPlanificacion.Equals(Constantes.TipoPlanificacion.LABORATORIO)).ToList();
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
                return objPlanificacion.SIGESU_PlanificacionAct(entidadPlanificacion);
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
                return objPlanificacion.GCPS_SP_PlanificacionIns(xml);
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
                return objPlanificacion.GCPS_SP_PlanificacionSel(FechaInicio, FechaFin);
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
                return objPlanificacion.GCPS_SP_PlanificionSelxIdPlanificacion(IdPlanificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Entidades.DTO_TP3.ERespuesta GCPS_SP_PlanificacionAct(Entidades.DTO_TP3.EPlanificacion entidadPlanificacion)
        {
            try
            {
                return objPlanificacion.GCPS_SP_PlanificacionAct(entidadPlanificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
