using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;
using AutoMapper;
using SIGESU.Datos.EntityFramework;
using SIGESU.Helpers;

namespace SIGESU.Datos.DAL.Observacion
{
    public class ObservacionDAL : IObservacion
    {
        public List<EObservacionSugerencia> GCPS_SP_ObservacionesSugerenciasSel()
        {
            try
            {
                using (var db = new TP3UPCEntities()) 
                {
                    var result = db.GCPS_SP_ObservacionesSugerenciasSel().ToList();

                    List<Entidades.DTO_TP3.EObservacionSugerencia> lista =
                        Mapper.Map<List<Entidades.DTO_TP3.EObservacionSugerencia>>(result);

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
