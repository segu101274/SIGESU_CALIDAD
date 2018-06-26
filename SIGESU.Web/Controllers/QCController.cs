using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIGESU.Negocio.BL;

namespace SIGESU.Web.Controllers
{
    public class QCController : Controller
    {
        EquipmentBL objEquipment = new EquipmentBL();
        EquipmentPruebaBL objEquipmentPrueba = new EquipmentPruebaBL();
        LeveyJenningsBL objLeveyJennings = new LeveyJenningsBL();

        // GET: QC
        public ActionResult Index()
        {
            ViewBag.listaAnalizadores = objEquipment.GCPS_SP_EQUIPMENTSEL();
            return View();
        }

        public JsonResult ListarPruebasxAnalizador(int IdEquipment)
        {
            var lista = objEquipmentPrueba.GCPS_SP_QCEquipmentPruebaSelxIdEquipment(IdEquipment);

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult obtenerLeveyJennings(int IdPrueba, int IdEquipment)
        {
            var lista = objLeveyJennings.GCPS_SP_QC_LEVEY_JENNINGS(IdPrueba, IdEquipment);
            double media = CalcularMedia(lista);
            double dev = CalcularDev(lista, media);

            List<double> limites = Limites(media, Math.Round(dev, 2));

            //return Json(lista, JsonRequestBehavior.AllowGet);
            return Json(new { lista = lista, limites = limites, media = media, dev = Math.Round(dev, 2) }, JsonRequestBehavior.AllowGet);
        }

        public double CalcularMedia(List<Entidades.DTO_TP3.ELeveyJennings> lista)
        {
            int count = lista.Count;
            double suma = 0;

            foreach (Entidades.DTO_TP3.ELeveyJennings lj in lista)
            {
                suma = suma + Convert.ToDouble(lj.Resultado);        
            }

            return suma / count;
        }

        public double CalcularDev(List<Entidades.DTO_TP3.ELeveyJennings> lista, double media)
        {
            double M = 0.0;
            double S = 0.0;
            int k = 1;
            foreach (Entidades.DTO_TP3.ELeveyJennings lj in lista)
            {
                double tmpM = M;
                M += (Convert.ToDouble(lj.Resultado) - tmpM) / k;
                S += (Convert.ToDouble(lj.Resultado) - tmpM) * (Convert.ToDouble(lj.Resultado) - M);
                k++;
            }
            return Math.Sqrt(S / (k - 2));
        }

        public List<double> Limites(double media, double dev)
        {
            List<double> lista = new List<double>();

            var menos1s = media  - (dev *  1);
            var mas1s = media + (dev * 1);

            var menos2s = media - (dev * 2);
            var mas2s = media + (dev * 2);

            var menos3s = media - (dev * 3);
            var mas3s = media + (dev * 3);

            lista.Add(media);
            lista.Add(Math.Round(menos1s,2));
            lista.Add(Math.Round(mas1s,2));
            lista.Add(Math.Round(menos2s,2));
            lista.Add(Math.Round(mas2s, 2));
            lista.Add(Math.Round(menos3s,2));
            lista.Add(Math.Round(mas3s,2));

            return lista;
        }
    }
}