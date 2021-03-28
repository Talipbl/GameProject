using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IEntityRepository<TContext>
    {
        //db operations
        void Add(TContext context);
        void Delete(TContext context);
        void Update(TContext context);
    }
}
