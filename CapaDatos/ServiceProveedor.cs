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
            PROVEEDOR prov = this.getEntity(pk);
            if (prov == null)
            {
                throw new ArgumentException("Cliente no encontrado");

            }
            else
            {
                em.PROVEEDOR.Remove(prov);
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
            PROVEEDOR prov = em.PROVEEDOR.Where(q => q.IDPROVEEDOR == user).FirstOrDefault<PROVEEDOR>();

            return prov;
        }

        public override void updEntity(PROVEEDOR entity)
        {
            PROVEEDOR prov = this.getEntity(entity.IDPROVEEDOR);
            if (prov == null)
            {
                throw new ArgumentException("Cliente no encontrado");
            }
            else
            {
                prov.RUBRO = entity.RUBRO;
                prov.TELEFONO = entity.TELEFONO;
                prov.DESCRIPCION = entity.DESCRIPCION;
                prov.SITIOWEB = entity.SITIOWEB;
                em.SaveChanges();
            }
        }

        public int id()
        {
            PROVEEDOR prov = em.PROVEEDOR.OrderByDescending(x => x.IDPROVEEDOR).FirstOrDefault<PROVEEDOR>();
            int id = 1;
            if (prov == null)
            {
                return id;
            }
            else
            {
                return (int)prov.IDPROVEEDOR + 1;
            }

        }


    }
}
