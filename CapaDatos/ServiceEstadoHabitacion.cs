using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceEstadoHabitacion : AbstractService<ESTADOHABITACION>
    {
        public override void addEntity(ESTADOHABITACION entity)
        {
            throw new NotImplementedException();
        }

        public override void delEntity(object pk)
        {
            throw new NotImplementedException();
        }

        public override List<ESTADOHABITACION> getEntities()
        {
            return em.ESTADOHABITACION.ToList<ESTADOHABITACION>();
        }

        public override ESTADOHABITACION getEntity(object pk)
        {
            int estado = int.Parse(pk.ToString());
            ESTADOHABITACION eh = em.ESTADOHABITACION.Where(q => q.IDESTADO == estado).FirstOrDefault<ESTADOHABITACION>();
            return eh;
        }

        public ESTADOHABITACION getEntityDesc(object pk)
        {
            string estado = pk.ToString();
            ESTADOHABITACION eh = em.ESTADOHABITACION.Where(q => q.DESCRIPCION.Equals(estado)).FirstOrDefault<ESTADOHABITACION>();
            return eh;
        }

        public override void updEntity(ESTADOHABITACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
