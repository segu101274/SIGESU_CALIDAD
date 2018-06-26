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
    public class PlanificacionController : Controller
    {
        PlanificacionBL objPlanificacion = new PlanificacionBL();
        ProductoBL objProducto = new ProductoBL();
        LaboratorioBL objLaboratorio = new LaboratorioBL();
        EspecialistaBL objEspecialista = new EspecialistaBL();
        SucursalAlmacenBL objSucursalAlmacen = new SucursalAlmacenBL();
        ServidorBL objServidor = new ServidorBL();

        // GET: Planificacion
        public ActionResult Index()
        {
            ViewBag.listaProductos = objProducto.SIGESU_ProductoSelTodo();
            ViewBag.listaLaboratorios = objLaboratorio.SIGESU_LaboratorioSelTodo();
            ViewBag.listaEspecialistas = objEspecialista.SIGESU_EspecialistaSelTodo();
            ViewBag.listaSucursalAlmacenes = objSucursalAlmacen.SIGESU_SucursalAlmacenSelTodo();

            return View();
        }

        public ActionResult listarPlanificacion(string FechaInicio, string FechaFin)
        {
            try
            {
                var lista = objPlanificacion.SIGESU_PlanificacionSel(FechaInicio, FechaFin);

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
                var lista = objPlanificacion.PlanificacionSelHistoricoxPeriodo(FechaInicio, FechaFin);

                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult getProductoAtributo(int IdProducto)
        {
            try
            {
                EProducto entidadProducto = objProducto.SIGESU_ProductoSelAtributosxIdProducto(IdProducto);

                return Json(entidadProducto, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult PlanificacionCorrelativo()
        {
            string Correlativo = string.Empty;

            try
            {
                Correlativo = objPlanificacion.SIGESU_PlanificacionSelUltimoGenerado();

                return Json(Correlativo, JsonRequestBehavior.AllowGet);    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult getServidorConfiguracion()
        {
            try
            {
                EServidor entidadServidor = objServidor.SIGESU_ServidorSel();

                return Json(entidadServidor, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public JsonResult PlanificacionIns(EPlanificacion entidadPlanificacion)
        {
            string xml = string.Empty;

            foreach (EPlanificacionSucursalAlmacen eps in entidadPlanificacion.ListaPlanificacionSucursalAlmacen)
            {
                if (eps.IdSucursalAlmacen == 0)
                {
                    return Json(new ERespuesta { Estado = 0, Mensaje = "Seleccionar el sucursal-almacén" });
                }
            }

            if (entidadPlanificacion.FechaInicioWithFormat == "01/01/0001")
            {
                return Json(new ERespuesta { Estado = 0, Mensaje = "Completar la fecha de ejecucion" });
            }

            xml = ConvertToXML.Registrar_XML(entidadPlanificacion);

            ERespuesta objRespuesta = objPlanificacion.SIGESU_PlanificacionIns(xml);

            return Json(objRespuesta);
        }

        [HttpPost]
        public JsonResult PlanificacionActAprobado(int IdPlanificacion, string NumeroEstado)
        {
            EPlanificacion entidadPlanificacion = new EPlanificacion();

            entidadPlanificacion = objPlanificacion.SIGESU_PlanificacionSelxIdPlanificacion(IdPlanificacion);
            entidadPlanificacion.Estado = NumeroEstado;
            ERespuesta objRespuesta = objPlanificacion.SIGESU_PlanificacionAct(entidadPlanificacion);

            return Json(objRespuesta);
        }


        [HttpPost]
        public JsonResult PlanificacionActAnulado(int IdPlanificacion, string NumeroEstado, string obs)
        {
            EPlanificacion entidadPlanificacion = new EPlanificacion();

            entidadPlanificacion = objPlanificacion.SIGESU_PlanificacionSelxIdPlanificacion(IdPlanificacion);
            entidadPlanificacion.Estado = NumeroEstado;
            entidadPlanificacion.Observacion = obs;
            ERespuesta objRespuesta = objPlanificacion.SIGESU_PlanificacionAct(entidadPlanificacion);

            return Json(objRespuesta);
        }

        public ActionResult ListarPlanificacionxIdPlanificacion(int IdPlanificacion)
        {
            EPlanificacion entidadPlanificacion = new EPlanificacion();

            entidadPlanificacion = objPlanificacion.SIGESU_PlanificacionSelxIdPlanificacion(IdPlanificacion);

            return Json(entidadPlanificacion, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult PlanificacionAct(EPlanificacion entidadPlanificacion)
        {
            ERespuesta objRespuesta = objPlanificacion.SIGESU_PlanificacionAct(entidadPlanificacion);

            return Json(objRespuesta);
        }

    }
}