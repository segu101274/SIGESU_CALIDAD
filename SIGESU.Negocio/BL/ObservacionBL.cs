using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.DAL.Observacion;

namespace SIGESU.Negocio.BL
{
    public class ObservacionBL
    {
        ObservacionDAL objObservacion = new ObservacionDAL();

        public List<Entidades.DTO_TP3.EObservacionSugerencia> GCPS_SP_ObservacionesSugerenciasSel()
        {
            try
            {
                return objObservacion.GCPS_SP_ObservacionesSugerenciasSel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
