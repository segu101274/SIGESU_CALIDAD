using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Datos.DAL.Observacion
{
    public interface IObservacion
    {
        List<Entidades.DTO_TP3.EObservacionSugerencia> GCPS_SP_ObservacionesSugerenciasSel();
    }
}
