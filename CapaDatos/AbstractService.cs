using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public abstract class AbstractService<T>
    {
        protected SisghoEntities em = new SisghoEntities();
        public abstract void addEntity(T entity);
        public abstract void updEntity(T entity);
        public abstract void delEntity(Object pk);
        public abstract List<T> getEntities();
        public abstract T getEntity(Object pk);
    }
}
