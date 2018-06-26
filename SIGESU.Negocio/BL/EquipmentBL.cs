using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.DAL.Equipment;

namespace SIGESU.Negocio.BL
{
    public class EquipmentBL
    {
        EquipmentDAL objEquipment = new EquipmentDAL();

        public List<Entidades.DTO_TP3.EEquipment> GCPS_SP_EQUIPMENTSEL()
        {
            try
            {
                return objEquipment.GCPS_SP_EQUIPMENTSEL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
