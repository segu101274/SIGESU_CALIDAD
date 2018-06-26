using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.DAL.LeveyJennings;

namespace SIGESU.Negocio.BL
{
    public class LeveyJenningsBL
    {
        LeveyJenningsDAL objLeveyJennings = new LeveyJenningsDAL();

        public List<Entidades.DTO_TP3.ELeveyJennings> GCPS_SP_QC_LEVEY_JENNINGS(int IdPrueba, int IdEquipment)
        {
            try
            {
                return objLeveyJennings.GCPS_SP_QC_LEVEY_JENNINGS(IdPrueba, IdEquipment);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
