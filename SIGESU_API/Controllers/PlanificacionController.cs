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
    public class PlanificacionController : ApiController
    {
        [System.Web.Http.Route("api/planificacion/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var planificaciones = PlanificacionRepository.GetAllPlanificacionxEspecialista(id);
            HttpResponseMessage response = Request.CreateResponse(System.Net.HttpStatusCode.OK, planificaciones);
            return response;
        }

    }
}