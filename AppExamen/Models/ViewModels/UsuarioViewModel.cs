using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppExamen.Models.ViewModels
{
    public class UsuarioViewModel
    {
        public int usu_id { get; set; }
        public string usu_nombre { get; set; }
        public string usu_apellido { get; set; }

        public string usu_email { get; set; }
        public int cod_rol { get; set; }
        public int usu_estado { get; set; }
        public DateTime fec_ins { get; set; }
        public DateTime fec_upd { get; set; }
    }
}
