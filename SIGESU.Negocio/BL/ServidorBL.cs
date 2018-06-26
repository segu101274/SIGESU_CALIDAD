using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.Servidor;
using SIGESU.Helpers;

namespace SIGESU.Negocio.BL
{
    public class ServidorBL
    {
        ServidorDAL objServidor = new ServidorDAL();

        public EServidor SIGESU_ServidorSel()
        {
            try
            {
                return objServidor.SIGESU_ServidorSel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
