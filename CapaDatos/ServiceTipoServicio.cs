using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceTipoServicio : AbstractService<TIPOSERVICIO>
    {
        public override void addEntity(TIPOSERVICIO entity)
        {
            throw new NotImplementedException();
        }

        public override void delEntity(object pk)
        {
            throw new NotImplementedException();
        }

        public override List<TIPOSERVICIO> getEntities()
        {
            return em.TIPOSERVICIO.ToList<TIPOSERVICIO>();
        }

        public override TIPOSERVICIO getEntity(object pk)
        {
            int tipo = int.Parse(pk.ToString());
            TIPOSERVICIO ts = em.TIPOSERVICIO.Where(q => q.IDTIPO == tipo).FirstOrDefault<TIPOSERVICIO>();
            return ts;
        }

        public TIPOSERVICIO getEntityDesc(object pk)
        {
            string tipo = pk.ToString();
            TIPOSERVICIO ts = em.TIPOSERVICIO.Where(q => q.DESCRIPCION.Equals(tipo)).FirstOrDefault<TIPOSERVICIO>();
            return ts;
        }

        public override void updEntity(TIPOSERVICIO entity)
        {
            throw new NotImplementedException();
        }
    }
}
