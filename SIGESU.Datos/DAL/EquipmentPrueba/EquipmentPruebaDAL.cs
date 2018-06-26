using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO_TP3;
using AutoMapper;
using SIGESU.Datos.EntityFramework;


namespace SIGESU.Datos.DAL.EquipmentPrueba
{
    public class EquipmentPruebaDAL : IEquipmentPrueba
    {
        public List<EEquipmentPrueba> GCPS_SP_QCEquipmentPruebaSelxIdEquipment(int IdEquipment)
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_QCEquipmentPruebaSelxIdEquipment(IdEquipment).ToList();

                    List<EEquipmentPrueba> lista =
                        Mapper.Map<List<EEquipmentPrueba>>(result);

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
