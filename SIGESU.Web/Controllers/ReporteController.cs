using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIGESU.Negocio.BL;

namespace SIGESU.Web.Controllers
{
    public class ReporteController : Controller
    {

        ProductoBL objProducto = new ProductoBL();
        ReporteBL objReporte = new ReporteBL();
        ObservacionBL objObservacion = new ObservacionBL();
        // GET: Reporte
        public ActionResult Index()
        {
            ViewBag.listaProductos = objProducto.GCPS_SP_ProductoSelTodo();
            return View();
        }

        public JsonResult ObtenerReporte(string cod_producto, string fecini, string fecfin)
        {
            var lista = objReporte.GCPS_SP_ReporteCampo(cod_producto, fecini, fecfin);
            var sugerencias = objObservacion.GCPS_SP_ObservacionesSugerenciasSel();
            var mensaje = "";
            var mensajesugerencia = "";

            if (lista.Count == 0)
            {
                mensaje = "Felicidades! Tienes 0 observaciones del producto";
            }

            mensajesugerencia = SugerenciaReporte(lista, sugerencias);

            return Json(new { lista = lista, mensaje = mensaje, rpta = mensajesugerencia }, JsonRequestBehavior.AllowGet);
        }

        public string SugerenciaReporte(List<Entidades.DTO_TP3.EReporte> lista, 
                                        List<Entidades.DTO_TP3.EObservacionSugerencia> sugerencias)
        {
            var mensaje = "";

            foreach (Entidades.DTO_TP3.EReporte reporte in lista)
            {
                foreach (Entidades.DTO_TP3.EObservacionSugerencia obs in sugerencias)
                {
                    if (reporte.name.Equals(obs.Descripcion))
                    {
                        if (reporte.y > obs.PorcentajeMin && reporte.y <= obs.PorcentajeMax)
                        {
                            mensaje = mensaje +  obs.Descripcion + "-" + obs.Sugerencia + System.Environment.NewLine;
                        }
                    }
                }
            }

            return mensaje;
        }
    }
}