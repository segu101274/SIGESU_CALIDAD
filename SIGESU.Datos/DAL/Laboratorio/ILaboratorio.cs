using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO;

namespace SIGESU.Datos.DAL.Laboratorio
{
    public interface ILaboratorio
    {
        List<ELaboratorio> SIGESU_LaboratorioSelTodo();

        List<Entidades.DTO_TP3.ELaboratorio> GCPS_SP_LaboratorioSelTodo();
    }
}
