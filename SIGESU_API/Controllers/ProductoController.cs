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
    public class ProductoController : ApiController
    {
        [System.Web.Http.Route("api/producto/{codigobarra?}")]
        public HttpResponseMessage Get(string codigobarra)
        {
            var planificaciones = PlanificacionRepository.GetProductoxCodigoBarra(codigobarra);
            HttpResponseMessage response = Request.CreateResponse(System.Net.HttpStatusCode.OK, planificaciones);
            return response;
        }

        [System.Web.Http.Route("api/observaciones/{codproducto?}")]
        public HttpResponseMessage Get2(string codproducto)
        {
            var observaciones = PlanificacionRepository.GetProductoObservacionesxProducto(codproducto);
            HttpResponseMessage response = Request.CreateResponse(System.Net.HttpStatusCode.OK, observaciones);
            return response;
        }
    }
}
