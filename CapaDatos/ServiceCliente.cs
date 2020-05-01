using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceCliente : AbstractService<CLIENTE>
    {
        public override void addEntity(CLIENTE entity)
        {
            em.CLIENTE.Add(entity);
            em.SaveChanges();
        }

        public override void delEntity(object pk)
        {
            CLIENTE cliente = this.getEntity(pk);
            if (cliente == null)
            {
                throw new ArgumentException("Cliente no encontrado");

            }
            else
            {
                em.CLIENTE.Remove(cliente);
                em.SaveChanges();
            }
        }

        public override List<CLIENTE> getEntities()
        {
            return em.CLIENTE.ToList<CLIENTE>();
        }

        public override CLIENTE getEntity(object pk)
        {
            int user = int.Parse(pk.ToString());
            CLIENTE cliente = em.CLIENTE.Where(q => q.IDCLIENTE == user).FirstOrDefault<CLIENTE>();

            return cliente;
        }

        public override void updEntity(CLIENTE entity)
        {
            CLIENTE cliente = this.getEntity(entity.IDCLIENTE);
            if (cliente == null)
            {
                throw new ArgumentException("Cliente no encontrado");
            }
            else
            {
                cliente.RUT = entity.RUT;
                cliente.NOMBRE = entity.NOMBRE;
                cliente.RUBRO = entity.RUBRO;
                cliente.DIRECCION = entity.DIRECCION;
                cliente.TELEFONO = entity.TELEFONO;
                em.SaveChanges();
            }
        }
        public int id()
        {
            CLIENTE cliente = em.CLIENTE.OrderByDescending(x => x.IDCLIENTE).FirstOrDefault<CLIENTE>();
            int id = 1;
            if (cliente == null)
            {
                return id;
            }
            else
            {
                return (int)cliente.IDCLIENTE + 1;
            }
            
        }
    }
}
