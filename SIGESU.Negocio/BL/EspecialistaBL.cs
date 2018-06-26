using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.Especialista;

namespace SIGESU.Negocio.BL
{
    public class EspecialistaBL
    {
        EspecialistaDAL objEspecialista = new EspecialistaDAL();

        public List<EEspecialista> SIGESU_EspecialistaSelTodo()
        {
            try
            {
                return objEspecialista.SIGESU_EspecialistaSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO_TP3.EEspecialista> GCPS_SP_EspecialistaSelTodo()
        {
            try
            {
                return objEspecialista.GCPS_SP_EspecialistaSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
