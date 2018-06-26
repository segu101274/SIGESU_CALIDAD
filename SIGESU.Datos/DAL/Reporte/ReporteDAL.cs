using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;
using AutoMapper;
using SIGESU.Datos.EntityFramework;
using SIGESU.Helpers;

namespace SIGESU.Datos.DAL.Reporte
{
    public class ReporteDAL : IReporte
    {
        public List<EReporte> GCPS_SP_ReporteCampo(string cod_producto, string fecini, string fecfin)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_ReporteCampo(cod_producto, fecini, fecfin).ToList();

                    List<EReporte> lista =
                        Mapper.Map<List<EReporte>>(result);

                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
