using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.DAL.EquipmentPrueba;

namespace SIGESU.Negocio.BL
{
    public class EquipmentPruebaBL
    {
        EquipmentPruebaDAL objEquipmentPrueba = new EquipmentPruebaDAL();

        public List<Entidades.DTO_TP3.EEquipmentPrueba> GCPS_SP_QCEquipmentPruebaSelxIdEquipment(int IdEquipment)
        {
            try
            {
                return objEquipmentPrueba.GCPS_SP_QCEquipmentPruebaSelxIdEquipment(IdEquipment);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
