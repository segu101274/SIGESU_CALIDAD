using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Datos.EntityFramework;
using SIGESU.Entidades.DTO;

namespace SIGESU.Datos.DAL.Especialista
{
    public interface IEspecialista
    {
        List<EEspecialista> SIGESU_EspecialistaSelTodo();
        List<Entidades.DTO_TP3.EEspecialista> GCPS_SP_EspecialistaSelTodo();

    }
}
