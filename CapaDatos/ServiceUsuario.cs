using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceUsuario : AbstractService<USUARIO>
    {
        public override void addEntity(USUARIO entity)
        {
            em.USUARIO.Add(entity);
            em.SaveChanges();
        }

        public override void delEntity(object pk)
        {
            USUARIO user = this.getEntity(pk);
            if (user == null)
            {
                throw new ArgumentException("Usuario no encontrado");

            }
            else
            {
                em.USUARIO.Remove(user);
                em.SaveChanges();
            }
        }

        public override List<USUARIO> getEntities()
        {
            return em.USUARIO.ToList<USUARIO>();
        }

        public override USUARIO getEntity(object pk)
        {
            string user = pk.ToString();
            USUARIO usuario = em.USUARIO.Where(q => q.USUARIO1.Equals(user)).FirstOrDefault<USUARIO>();
            return usuario;
        }

        public override void updEntity(USUARIO entity)
        {
            USUARIO usuario = getEntity(entity.USUARIO1);
            if (usuario == null)
            {
                throw new ArgumentException("Usuario no encontrado");
            }
            else
            {
                usuario.CONTRASEÑA = entity.CONTRASEÑA;
                usuario.NOMBRE = entity.NOMBRE;
                usuario.APELLIDO_PATERNO = entity.APELLIDO_PATERNO;
                usuario.APELLIDO_MATERNO = entity.APELLIDO_MATERNO;
                usuario.CORREO = entity.CORREO;
                em.SaveChanges();
            }
        }
        public Boolean login(string usuario, string password)
        {
            USUARIO user = em.USUARIO.Where(q => q.USUARIO1.ToString().Equals(usuario)).First<USUARIO>();
            if (user.CONTRASEÑA.Equals(password) && user.TIPOUSUARIO.Equals(1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int id()
        {
            USUARIO user = em.USUARIO.OrderByDescending(x=>x.IDUSUARIO).FirstOrDefault<USUARIO>();
            return (int)user.IDUSUARIO + 1;
        }
    }
}
