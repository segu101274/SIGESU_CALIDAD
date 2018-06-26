using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;
using AutoMapper;
using SIGESU.Datos.EntityFramework;

namespace SIGESU.Datos.DAL.LeveyJennings
{
    public class LeveyJenningsDAL : ILeveyJennings
    {
        public List<ELeveyJennings> GCPS_SP_QC_LEVEY_JENNINGS(int IdPrueba, int IdEquipment)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_QC_LEVEY_JENNINGS(IdPrueba, IdEquipment).ToList();

                    List<ELeveyJennings> lista =
                        Mapper.Map<List<ELeveyJennings>>(result);

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
