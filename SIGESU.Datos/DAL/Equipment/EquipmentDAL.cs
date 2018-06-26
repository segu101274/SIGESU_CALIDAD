using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;
using SIGESU.Datos.EntityFramework;
using AutoMapper;

namespace SIGESU.Datos.DAL.Equipment
{
    public class EquipmentDAL : IEquipment
    {
        public List<EEquipment> GCPS_SP_EQUIPMENTSEL()
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_EquipmentSel().ToList();

                    List<Entidades.DTO_TP3.EEquipment> listaEquipment =
                        Mapper.Map<List<Entidades.DTO_TP3.EEquipment>>(result);

                    return listaEquipment;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
