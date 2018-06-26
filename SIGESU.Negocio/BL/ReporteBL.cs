using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.DAL.Reporte;

namespace SIGESU.Negocio.BL
{
    public class ReporteBL
    {
        ReporteDAL objReporte = new ReporteDAL();

        public List<Entidades.DTO_TP3.EReporte> GCPS_SP_ReporteCampo(string cod_producto, string fecini, string fecfin)
        {
            try
            {
                return objReporte.GCPS_SP_ReporteCampo(cod_producto, fecini, fecfin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
