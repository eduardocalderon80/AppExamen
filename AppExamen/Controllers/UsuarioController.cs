using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppExamen.Models;
using AppExamen.Models.Response;
using AppExamen.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NuGet.Frameworks;

namespace AppExamen.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private Models.MyDBContext db;

        public UsuarioController(Models.MyDBContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public IEnumerable<UsuarioViewModel> Usuarios()
        {
            List<UsuarioViewModel> lst = (from d in db.Usuario
                                          select new UsuarioViewModel
                                          {
                                            usu_id = d.usu_id,
                                            usu_nombre = d.usu_nombre,
                                            usu_apellido = d.usu_apellido,
                                            usu_email = d.usu_email,
                                            usu_estado = d.usu_estado
                                          }).ToList();

            return lst;
        }

        [HttpPost("[action]")]
        public MyResponse Add([FromBody]UsuarioViewModel model)
        {
            MyResponse oR = new MyResponse();

            try
            {
                Models.tbl_usuario oUsuario = new Models.tbl_usuario();
                oUsuario.usu_nombre = model.usu_nombre;
                oUsuario.usu_apellido = model.usu_apellido;
                oUsuario.usu_email = model.usu_email;
                oUsuario.usu_estado = model.usu_estado;
                
                db.Usuario.Add(oUsuario);
                db.SaveChanges();

                oR.Success = 1;
            }
            catch (Exception ex)
            {
                oR.Success = 0;
                oR.Message = ex.Message;
            }

            return oR;
        }
    }
}