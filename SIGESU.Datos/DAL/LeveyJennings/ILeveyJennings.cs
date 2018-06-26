using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Datos.DAL.LeveyJennings
{
    public interface ILeveyJennings
    {
        List<Entidades.DTO_TP3.ELeveyJennings> GCPS_SP_QC_LEVEY_JENNINGS(int IdPrueba, int IdEquipment);
    }
}
