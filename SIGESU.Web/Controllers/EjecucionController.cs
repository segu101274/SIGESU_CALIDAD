using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIGESU.Negocio.BL;
using SIGESU.Entidades.DTO;
using SIGESU.Helpers;

namespace SIGESU.Web.Controllers
{ 
    
    public class EjecucionController : Controller
    {
        PlanificacionLaboratorioBL objPlanificacionLaboratorio = new PlanificacionLaboratorioBL();
        PlanificacionDetalleBL objPlanificacionDetalle = new PlanificacionDetalleBL();
        PlanificacionBL objPlanificacion = new PlanificacionBL();
        ServidorBL objServidor = new ServidorBL();
        // GET: Ejecucion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listarPlanificacionLaboratorioUltimo()
        {
            try
            {
                var lista = objPlanificacionDetalle.GCPS_SP_PlanificacionLaboratorioSel(null);

                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult PlanificacionLaboratorioAct(int IdPlanificacionDetalle, string Resultado)
        {
            try
            {
                EServidor entidadServidor = new EServidor();
                entidadServidor = objServidor.SIGESU_ServidorSel();

                Entidades.DTO_TP3.EPlanificacionDetalle entidadPlanificacionDetalle = 
                    objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(IdPlanificacionDetalle);

                entidadPlanificacionDetalle.Resultado = Resultado;
                entidadPlanificacionDetalle.FechaEdicion = entidadServidor.FechaHoraActual;

                Entidades.DTO_TP3.ERespuesta objRespuesta = objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleAct(entidadPlanificacionDetalle);

                return Json(objRespuesta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult PlanificacionLaboratorioActResultadoAdverso(int IdPlanificacionLaboratorio, string Resultado)
        {
            try
            {
                EServidor entidadServidor = new EServidor();
                entidadServidor = objServidor.SIGESU_ServidorSel();

                EPlanificacionLaboratorio entidadPlanificacionLaboratorio =
                    objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioSelxIdPlanificacionLaboratorio(IdPlanificacionLaboratorio);

                entidadPlanificacionLaboratorio.ResultadoAdverso = Resultado;
                entidadPlanificacionLaboratorio.FechaeEdicion = entidadServidor.FechaHoraActual;

                ERespuesta objRespuesta = objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioAct(entidadPlanificacionLaboratorio);

                return Json(objRespuesta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult PlanificacionCheckin(int IdPlanificacionDetalle)
        {
            try
            {
                EServidor entidadServidor = new EServidor();
                entidadServidor = objServidor.SIGESU_ServidorSel();

                Entidades.DTO_TP3.EPlanificacionDetalle  entidadPlanificacionDetalle =
                    objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(IdPlanificacionDetalle);

                entidadPlanificacionDetalle.FechaCheckin = entidadServidor.FechaHoraActual;

                Entidades.DTO_TP3.ERespuesta objRespuesta = objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleActxCheckin(entidadPlanificacionDetalle);

                return Json(objRespuesta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult PlanificacionImprimir(int IdPlanificacionLaboratorio)
        {
            try
            {
                EServidor entidadServidor = new EServidor();
                entidadServidor = objServidor.SIGESU_ServidorSel();

                EPlanificacionLaboratorio entidadPlanificacionLaboratorio =
                    objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioSelxIdPlanificacionLaboratorio(IdPlanificacionLaboratorio);

                entidadPlanificacionLaboratorio.FechaImpresion = entidadServidor.FechaHoraActual;

                ERespuesta objRespuesta = objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioActxIdPlanificacionxImpresion(entidadPlanificacionLaboratorio);

                return Json(objRespuesta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult PlanificacionValidacion(int IdPlanificacionDetalle)
        {
            try
            {
                EServidor entidadServidor = new EServidor();
                entidadServidor = objServidor.SIGESU_ServidorSel();

                Entidades.DTO_TP3.EPlanificacionDetalle entidadPlanificacionDetalle =
                    objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleSelxIdPlanificacionDetalle(IdPlanificacionDetalle);

                entidadPlanificacionDetalle.FechaValidacion  = entidadServidor.FechaHoraActual;

                Entidades.DTO_TP3.ERespuesta objRespuesta = objPlanificacionDetalle.GCPS_SP_PlanificacionDetalleAct(entidadPlanificacionDetalle);

                return Json(objRespuesta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult PlanificacionLaboratorioIns(int IdPlanificacion)
        {
            try
            {
                ERespuesta objRespuesta = objPlanificacionLaboratorio.SIGESU_PlanificacionLaboratorioIns(IdPlanificacion);

                return Json(objRespuesta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult listarPlanificacionLaboratorioxIdPlanificacion(int IdPlanificacion)
        {
            try
            {
                var lista = objPlanificacionDetalle.GCPS_SP_PlanificacionLaboratorioSel(IdPlanificacion);

                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult listarPlanificacionHistorico(string FechaInicio, string FechaFin)
        {
            try
            {
                if (FechaInicio == "")
                    FechaInicio = objServidor.SIGESU_ServidorSel().FechaHoraActual.ToString(Constantes.FormatosFecha.ddMMyyyy);
                if (FechaFin == "")
                    FechaFin = objServidor.SIGESU_ServidorSel().FechaHoraActual.ToString(Constantes.FormatosFecha.ddMMyyyy);

                var lista = objPlanificacion.PlanificacionSelAprobadoxPeriodo2(FechaInicio, FechaFin);

                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}