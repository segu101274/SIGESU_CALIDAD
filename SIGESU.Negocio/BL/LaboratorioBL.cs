using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using SIGESU.Datos.DAL.Laboratorio;

namespace SIGESU.Negocio.BL
{
    public class LaboratorioBL
    {
        LaboratorioDAL objLaboratorio = new LaboratorioDAL();

        public List<ELaboratorio> SIGESU_LaboratorioSelTodo()
        {
            try
            {
                return objLaboratorio.SIGESU_LaboratorioSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Entidades.DTO_TP3.ELaboratorio> GCPS_SP_LaboratorioSelTodo()
        {
            try
            {
                return objLaboratorio.GCPS_SP_LaboratorioSelTodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
