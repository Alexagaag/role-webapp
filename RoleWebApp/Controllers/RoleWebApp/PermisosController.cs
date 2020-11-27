using ContrBase = Microsoft.AspNetCore.Mvc.ControllerBase;
using RoleWebApp.DataBase.DataAccesInterface;
using RoleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleWebApp.DataBase.DataAcces;
using IHR = System.Web.Http.IHttpActionResult;
using Microsoft.AspNetCore.Cors;

namespace RoleWebApp.Controllers.RoleWebApp
{
    [ApiController]
    [Route("[controller]")]
    public class PermisosController : ContrBase
    {
        //IPermisosDA permisosDA;
        //public PermisosController (IPermisosDA permisosDA)
        //{
        //    //this.permisosDA = permisosDA;
        //}
        [Route("Save"), HttpPost]
        public bool Save([FromBody]Permiso value)
        {
            new PermisosDA().Save(value);
            return true;
        }
        [Route("GetAll"), HttpGet]
        public List<Permiso> GetAll()
        {
            return new PermisosDA().GetAll();
        }
        [Route("GetAllTipoPermiso"), HttpGet]
        public List<VmSelectList> GetAllTipoPermiso()   
        {
            return new TipoPermisoDA().GetAll();
        }
        [Route("Delete"), HttpPost]
        public bool Delete(Permiso value)
        {
            new PermisosDA().Delete(value);
            return true;
        }
    }
}
