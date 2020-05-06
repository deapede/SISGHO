using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceProveedor : AbstractService<PROVEEDOR>
    {
        public override void addEntity(PROVEEDOR entity)
        {
            em.PROVEEDOR.Add(entity);
            em.SaveChanges();
        }

        public override void delEntity(object pk)
        {
            PROVEEDOR proveedor = this.getEntity(pk);
            if (proveedor == null)
            {
                throw new ArgumentException("Proveedor no encontrado");
            }
            else
            {
                em.PROVEEDOR.Remove(proveedor);
                em.SaveChanges();
            }
        }

        public override List<PROVEEDOR> getEntities()
        {
            return em.PROVEEDOR.ToList<PROVEEDOR>();
        }

        public override PROVEEDOR getEntity(object pk)
        {
            int user = int.Parse(pk.ToString());
            PROVEEDOR proveedor = em.PROVEEDOR.Where(q => q.IDPROVEEDOR == user).FirstOrDefault<PROVEEDOR>();
            return proveedor;
        }

        public override void updEntity(PROVEEDOR entity)
        {
            PROVEEDOR proveedor = this.getEntity(entity.IDPROVEEDOR);
            if (proveedor == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                proveedor.IDPROVEEDOR = entity.IDPROVEEDOR;
                em.SaveChanges();
            }
        }

        public int id()
        {
            PROVEEDOR proveedor = em.PROVEEDOR.OrderBy(x => x.IDPROVEEDOR).FirstOrDefault<PROVEEDOR>();
            int id = 1;
            if (proveedor == null)
            {
                return id;
            }
            else
            {
                return (int)proveedor.IDPROVEEDOR + 1;
            }
        }
    }
}
