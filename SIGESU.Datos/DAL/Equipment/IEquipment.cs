using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Datos.DAL.Equipment
{
    public interface IEquipment
    {
        List<Entidades.DTO_TP3.EEquipment> GCPS_SP_EQUIPMENTSEL();
    }
}
