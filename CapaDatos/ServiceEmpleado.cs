using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceEmpleado : AbstractService<EMPLEADO>
    {
        public override void addEntity(EMPLEADO entity)
        {
            em.EMPLEADO.Add(entity);
            em.SaveChanges();
        }

        public override void delEntity(object pk)
        {
            EMPLEADO empleado = this.getEntity(pk);
            if (empleado == null)
            {
                throw new ArgumentException("Empleado no encontrado");
            }
            else
            {
                em.EMPLEADO.Remove(empleado);
                em.SaveChanges();
            }
        }

        public override List<EMPLEADO> getEntities()
        {
            return em.EMPLEADO.ToList<EMPLEADO>();
        }

        public override EMPLEADO getEntity(object pk)
        {
            int user = int.Parse(pk.ToString());
            EMPLEADO empleado = em.EMPLEADO.Where(q => q.IDEMPLEADO == user).FirstOrDefault<EMPLEADO>();
            return empleado;
        }

        public override void updEntity(EMPLEADO entity)
        {
            EMPLEADO empleado = this.getEntity(entity.IDEMPLEADO);
            if (empleado == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                empleado.USUARIO = entity.USUARIO;
                em.SaveChanges();
            }
            
        }

        public int id()
        {
            EMPLEADO empleado = em.EMPLEADO.OrderBy(x => x.IDEMPLEADO).FirstOrDefault<EMPLEADO>();
            int id = 1;
            if (empleado == null)
            {
                return id;
            }
            else
            {
                return (int)empleado.IDEMPLEADO + 1;
            }
        }
    }
}
