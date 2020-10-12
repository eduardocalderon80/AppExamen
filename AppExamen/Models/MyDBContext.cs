using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppExamen.Models
{
    public class MyDBContext : DbContext
    {
        //// APLICANDO INYECCION DE DEPENDENCIA
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        public DbSet<tbl_usuario> Usuario { get; set; }
    }

    public class tbl_usuario
    {
        [Key]
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
