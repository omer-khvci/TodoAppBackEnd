using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete
{
    public class TodoRepository<TodoContext> : IGenericRepository<TodoContext>
         where TodoContext : class, IEntity, new()
    {
        public bool Add(TodoContext entity, long userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TodoContext entity, long userId)
        {
            throw new NotImplementedException();
        }

        public TodoContext Get(Expression<Func<TodoContext, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TodoContext> GetAll(Expression<Func<TodoContext, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(TodoContext entity, long userId)
        {
            throw new NotImplementedException();
        }
    }
}
