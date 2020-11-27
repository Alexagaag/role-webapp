using RoleWebApp.DataBase.DataAccesInterface;
using RoleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace RoleWebApp.DataBase.DataAcces
{
    public class PermisosDA : BaseDA/*, IPermisosDA*/
    {
        public Permiso Get(int Id)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    Permiso result = ctx.Permiso.FirstOrDefault(x => x.Id == Id);
                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public List<Permiso> GetAll()
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    List<Permiso> result = ctx.Permiso.ToList();
                    foreach(var res in result)
                    {
                        res.FkTipoPermiso = ctx.TipoPermiso.First(x => x.Id == res.TipoPermiso);
                    }
                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


        }
        public void Delete(Permiso value)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    Permiso prevValue = ctx.Permiso.Find(value.Id);
                    if(prevValue != null)
                    {
                        ctx.Permiso.Remove(prevValue);
                        ctx.SaveChanges();
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void Edit(Permiso value)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    ctx.Entry(value).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void Save(Permiso value)
        {
            using (RWAEntities ctx = new RWAEntities(GetConnection()))
            {
                try
                {
                    if (ctx.Permiso.FirstOrDefault(x => x.Id == value.Id) != null)
                    {
                        Permiso prevValue = ctx.Permiso.FirstOrDefault(x => x.Id == value.Id);
                        prevValue.NombreEmpleado = value.NombreEmpleado;
                        prevValue.ApellidosEmpleado = value.ApellidosEmpleado;
                        prevValue.TipoPermiso = value.TipoPermiso;
                        prevValue.FechaPermiso = value.FechaPermiso;
                        ctx.SaveChanges();
                        return;
                    }
                    else
                    {
                        ctx.Permiso.Add(value);
                        ctx.SaveChanges();
                    }


                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
