using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceServicioComedor : AbstractService<SERVICIOCOMEDOR>
    {
        public override void addEntity(SERVICIOCOMEDOR entity)
        {
            try
            {
                em.SERVICIOCOMEDOR.Add(entity);
                em.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No se pudo agregar el servicio.");
            }
        }

        public override void delEntity(object pk)
        {
            SERVICIOCOMEDOR sc = this.getEntity(pk);
            if (sc == null)
            {
                throw new ArgumentException("Habitacion no encontrada");

            }
            else
            {
                em.SERVICIOCOMEDOR.Remove(sc);
                em.SaveChanges();
            }
        }

        public override List<SERVICIOCOMEDOR> getEntities()
        {
            return em.SERVICIOCOMEDOR.ToList<SERVICIOCOMEDOR>();
        }

        public override SERVICIOCOMEDOR getEntity(object pk)
        {
            int idservicio = int.Parse(pk.ToString());
            SERVICIOCOMEDOR sc = em.SERVICIOCOMEDOR.Where(q => q.IDSERVICIO == idservicio).FirstOrDefault<SERVICIOCOMEDOR>();
            return sc;
        }

        public override void updEntity(SERVICIOCOMEDOR entity)
        {
            SERVICIOCOMEDOR sc = this.getEntity(entity.IDSERVICIO);
            if (sc == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                sc.PLATO = entity.PLATO;
                sc.PRECIO = entity.PRECIO;
                sc.TIPOSERVICIO = entity.TIPOSERVICIO;

                em.SaveChanges();
            }
        }

        public int id()
        {
            SERVICIOCOMEDOR sc = em.SERVICIOCOMEDOR.OrderByDescending(x => x.IDSERVICIO).FirstOrDefault<SERVICIOCOMEDOR>();
            int id = 1;
            if (sc == null)
            {
                return id;
            }
            else
            {
                return (int)sc.IDSERVICIO + 1;
            }

        }






    }
}
