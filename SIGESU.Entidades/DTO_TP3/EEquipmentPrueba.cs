using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESU.Entidades.DTO_TP3
{
    public class EEquipmentPrueba
    {
        public int IdEqPru { get; set; }
        public int IdEquipment { get; set; }
        public int IdPrueba { get; set; }
        public string Estado { get; set; }

        #region "Adicionales"
        public string NombrePrueba { get; set; }

        #endregion
    }
}
