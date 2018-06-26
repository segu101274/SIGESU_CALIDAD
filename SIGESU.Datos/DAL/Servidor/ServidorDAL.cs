using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;
using SIGESU.Helpers;


namespace SIGESU.Datos.DAL.Servidor
{
    public class ServidorDAL : IServidor
    {
        public EServidor SIGESU_ServidorSel()
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_ServidorSel().FirstOrDefault();

                    EServidor objServidor =
                        Mapper.Map<EServidor>(result);

                    return objServidor;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
