using SIGESU_API.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace SIGESU_API.Controllers
{
    [EnableCors(origins: "http://localhost:55058", headers: "*", methods: "*")]
    public class PlanificacionDetalleController : ApiController
    {
        [System.Web.Http.Route("api/planificaciondet/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var planificaciones = PlanificacionRepository.GetPlanificacionDetallexIdPlanificacion(id);
            HttpResponseMessage response = Request.CreateResponse(System.Net.HttpStatusCode.OK, planificaciones);
            return response;
        }

        [System.Web.Http.Route("api/planificaciondet/{IdPlanificacion?}/{cod_producto?}/{IdObservacion?}/{resultado?}")]
        public HttpResponseMessage Get2(int IdPlanificacion, string cod_producto, int IdObservacion, string resultado)
        {
            var respuesta = PlanificacionRepository.InsertarDetallePlanificacion(IdPlanificacion, cod_producto
                                                                                ,IdObservacion, resultado);
            HttpResponseMessage response = Request.CreateResponse(System.Net.HttpStatusCode.OK, respuesta);
            return response;
        }
    }
}