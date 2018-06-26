using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Datos.DAL.EquipmentPrueba
{
    public interface IEquipmentPrueba
    {
        List<Entidades.DTO_TP3.EEquipmentPrueba> GCPS_SP_QCEquipmentPruebaSelxIdEquipment(int IdEquipment);
    }
}
