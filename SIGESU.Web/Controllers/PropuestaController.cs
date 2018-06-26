using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIGESU.Negocio.BL;
using SIGESU.Helpers;
using SIGESU.Entidades.DTO_TP3;

namespace SIGESU.Web.Controllers
{
    public class PropuestaController : Controller
    {
        SucursalService objSucursal = new SucursalService();
        ProductoBL objProducto = new ProductoBL();
        PlanificacionBL objPlanificacion = new PlanificacionBL();
        EspecialistaBL objEspecialista = new EspecialistaBL();
        LaboratorioBL objLaboratorio = new LaboratorioBL();

        // GET: Propuesta
        public ActionResult Index()
        {
            ViewBag.listaSucursalAlmacenes = objSucursal.GCPS_SP_SucursalSelTodo();
            ViewBag.listaLaboratorios = objLaboratorio.GCPS_SP_LaboratorioSelTodo();
            ViewBag.listaEspecialistas = objEspecialista.GCPS_SP_EspecialistaSelTodo();
            //ViewBag.listaProductos = objProducto.GCPS_SP_ProductoEnPlanificacionSel();

            return View();
        }

        public ActionResult listarPlanificacion(string FechaInicio, string FechaFin)
        {
            try
            {
                var lista = objPlanificacion.GCPS_SP_PlanificacionSel(FechaInicio, FechaFin);

                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult listarPlanificacionDetalle(int IdPlanificacion)
        {
            try
            {
                var lista = objProducto.GCPS_SP_PlanificacionSelDetalle(IdPlanificacion);

                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public JsonResult PlanificacionActAnulado(int IdPlanificacion, string NumeroEstado, string obs)
        {
            Entidades.DTO_TP3.EPlanificacion entidadPlanificacion = new Entidades.DTO_TP3.EPlanificacion();

            entidadPlanificacion = objPlanificacion.GCPS_SP_PlanificionSelxIdPlanificacion(IdPlanificacion);
            entidadPlanificacion.Estado = NumeroEstado;
            entidadPlanificacion.Observacion = obs;
            Entidades.DTO_TP3.ERespuesta objRespuesta = objPlanificacion.GCPS_SP_PlanificacionAct(entidadPlanificacion);

            return Json(objRespuesta);
        }


        public ActionResult ListarPlanificacionxIdPlanificacion(int IdPlanificacion)
        {
            Entidades.DTO_TP3.EPlanificacion entidadPlanificacion = new Entidades.DTO_TP3.EPlanificacion();

            entidadPlanificacion = objPlanificacion.GCPS_SP_PlanificionSelxIdPlanificacion(IdPlanificacion);

            return Json(entidadPlanificacion, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GrabarPropuesta(EPlanificacion entidadPlanificacion)
        {
            string xml = string.Empty;
            List<EProducto> listaProductosPropuestos = new List<EProducto>();

            foreach (EPlanificacionSucursal eps in entidadPlanificacion.ListaPlanificacionSucursal)
            {
                if (eps.COD_SUCURSAL == null)
                {
                    return Json(new Entidades.DTO_TP3.ERespuesta { Estado = 0, Mensaje = "Seleccionar el sucursal" });
                }
            }

            if (entidadPlanificacion.FechaInicioWithFormat == "01/01/0001")
            {
                return Json(new ERespuesta { Estado = 0, Mensaje = "Completar la fecha inicio de ejecucion" });
            }

            if (entidadPlanificacion.FechaFinWithFormat == "01/01/0001")
            {
                return Json(new ERespuesta { Estado = 0, Mensaje = "Completar la fecha fin de ejecucion" });
            }

            //Obtener lista de productos propuestos.
            //En base a estas listas, se crearán dos tipos de planificaciones: Laboratorio y Campo

            listaProductosPropuestos = objProducto.GCPS_SP_ProductoEnPlanificacionSel();

            //PLANIFICACION TIPO LABORATORIO
            entidadPlanificacion.TipoPlanificacion = Constantes.TipoPlanificacion.LABORATORIO;
            entidadPlanificacion.detalleProductos = listaProductosPropuestos.Where(x => x.TIPOPLAN.Equals(Constantes.TipoPlanificacion.LABORATORIO)).ToList();

            xml = ConvertToXML.Registrar_XML(entidadPlanificacion);

            objPlanificacion.GCPS_SP_PlanificacionIns(xml);


            //PLANIFICACION TIPO CAMPO
            entidadPlanificacion.TipoPlanificacion = Constantes.TipoPlanificacion.CAMPO;
            entidadPlanificacion.detalleProductos = listaProductosPropuestos.Where(x => x.TIPOPLAN.Equals(Constantes.TipoPlanificacion.CAMPO)).ToList(); ;

            xml = ConvertToXML.Registrar_XML(entidadPlanificacion);

            ERespuesta objRespuesta = objPlanificacion.GCPS_SP_PlanificacionIns(xml);

            return Json(objRespuesta);
        }
    }
}