using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;

namespace SIGESU.Datos.DAL.Especialista
{
    public class EspecialistaDAL : IEspecialista
    {
        public List<Entidades.DTO_TP3.EEspecialista> GCPS_SP_EspecialistaSelTodo()
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_EspecialistaSelTodo().ToList();

                    List<Entidades.DTO_TP3.EEspecialista> listaEspecialista =
                        Mapper.Map<List<Entidades.DTO_TP3.EEspecialista>>(result);

                    var data = listaEspecialista.ToList();

                    return data;
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public List<EEspecialista> SIGESU_EspecialistaSelTodo()
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_EspecialistaSelTodo().ToList();
                    
                    List<EEspecialista> listaEspecialista =
                            Mapper.Map<List<EEspecialista>>(result);

                    var data = listaEspecialista.ToList();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
