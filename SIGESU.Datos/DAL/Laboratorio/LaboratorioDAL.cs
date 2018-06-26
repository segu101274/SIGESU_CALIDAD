using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGESU.Entidades.DTO;
using AutoMapper;
using SIGESU.Datos.EntityFramework;

namespace SIGESU.Datos.DAL.Laboratorio
{
    public class LaboratorioDAL : ILaboratorio
    {
        public List<Entidades.DTO_TP3.ELaboratorio> GCPS_SP_LaboratorioSelTodo()
        {
            try
            {
                using (var db = new TP3UPCEntities())
                {
                    var result = db.GCPS_SP_LaboratorioSelTodo().ToList();

                    List<Entidades.DTO_TP3.ELaboratorio> listaLaboratorio =
                        Mapper.Map<List<Entidades.DTO_TP3.ELaboratorio>>(result);

                    var data = listaLaboratorio.ToList();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ELaboratorio> SIGESU_LaboratorioSelTodo()
        {
            try
            {
                using (var db = new SIGESUEntities())
                {
                    var result = db.SIGESU_LaboratorioSelTodo().ToList();

                    List<ELaboratorio> listaLaboratorio =
                            Mapper.Map<List<ELaboratorio>>(result);

                    var data = listaLaboratorio.ToList();

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
