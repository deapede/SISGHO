using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceHabitacion : AbstractService<HABITACION>
    {
        public override void addEntity(HABITACION entity)
        {
            try
            {
                em.HABITACION.Add(entity);
                em.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new ArgumentException("No se pudo agregar la habitacion.");
            }
            
        }

        public override void delEntity(object pk)
        {
            HABITACION hb = this.getEntity(pk);
            if (hb == null)
            {
                throw new ArgumentException("Habitacion no encontrada");

            }
            else
            {
                em.HABITACION.Remove(hb);
                em.SaveChanges();
            }
        }

        public override List<HABITACION> getEntities()
        {
            return em.HABITACION.ToList<HABITACION>();
        }

        public override HABITACION getEntity(object pk)
        {
            int numeroHabitacion = int.Parse(pk.ToString());
            HABITACION hb = em.HABITACION.Where(q => q.IDHABITACION == numeroHabitacion).FirstOrDefault<HABITACION>();
            return hb;
        }

        public override void updEntity(HABITACION entity)
        {
            HABITACION hb = this.getEntity(entity.IDHABITACION);
            if (hb == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                hb.NUMERO = entity.NUMERO;
                hb.TIPO_CAMA = entity.TIPO_CAMA;
                hb.ACCESORIOS = entity.ACCESORIOS;
                hb.PRECIO = entity.PRECIO;
                hb.ESTADOHABITACION = entity.ESTADOHABITACION;
                em.SaveChanges();
            }
        }

        public int id()
        {
            HABITACION h = em.HABITACION.OrderByDescending(x => x.IDHABITACION).FirstOrDefault<HABITACION>();
            int id = 1;
            if (h == null)
            {
                return id;
            }
            else
            {
                return (int)h.IDHABITACION + 1;
            }

        }
    }
}
