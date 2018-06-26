using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Datos.DAL.Reporte
{
    public interface IReporte
    {
        List<Entidades.DTO_TP3.EReporte> GCPS_SP_ReporteCampo(string cod_producto, string fecini, string fecfin);
    }
}
