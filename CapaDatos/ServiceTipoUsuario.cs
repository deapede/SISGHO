using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ServiceTipoUsuario : AbstractService<TIPOUSUARIO>
    {
        public override void addEntity(TIPOUSUARIO entity)
        {
            throw new NotImplementedException();
        }

        public override void delEntity(object pk)
        {
            throw new NotImplementedException();
        }

        public override List<TIPOUSUARIO> getEntities()
        {
            throw new NotImplementedException();
        }

        public override TIPOUSUARIO getEntity(object pk)
        {
            int user = int.Parse(pk.ToString());
            TIPOUSUARIO tipo = em.TIPOUSUARIO.Where(q => q.IDTIPOUSUARIO.Equals(user)).FirstOrDefault<TIPOUSUARIO>();
            return tipo;
        }

        public override void updEntity(TIPOUSUARIO entity)
        {
            throw new NotImplementedException();
        }
    }
}
