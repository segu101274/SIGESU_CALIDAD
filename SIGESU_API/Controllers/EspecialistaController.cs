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
    public class EspecialistaController : ApiController
    {
        [System.Web.Http.Route("api/especialista/{Usuario?}/{Pwd?}")]
        public HttpResponseMessage Get(string Usuario, string Pwd)
        {
            var especialista = PlanificacionRepository.GetEspecialistaLogin(Usuario, Pwd);
            HttpResponseMessage response = Request.CreateResponse(System.Net.HttpStatusCode.OK, especialista);
            return response;
        }
    }
}