using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class GenericRepository<InterviewContext> : IGenericRepository<InterviewContext>
         where InterviewContext : class, IEntity, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<InterviewContext> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<InterviewContext>();
        }

        public bool Add(InterviewContext entity, long userId)
        {
            entity.CreatedBy = userId;
            entity.CreatedDate = DateTime.Now;
            _entities.Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(InterviewContext entity, long userId)
        {
            entity.DeleteBy = userId;
            entity.DeleteDate = DateTime.Now;
            entity.IsDeleted = true;
            return _context.SaveChanges() > 0;
        }

        public InterviewContext Get(Expression<Func<InterviewContext, bool>> filter)
        {
            return _entities.FirstOrDefault(filter);
        }

        public List<InterviewContext> GetAll(Expression<Func<InterviewContext, bool>> filter = null)
        {
            return filter == null ? _entities.ToList() : _entities.Where(filter).ToList();

        }

        public bool Update(InterviewContext entity, long userId)
        {
            entity.UpdateBy = userId;
            entity.UpdateDate = DateTime.Now;
            return _context.SaveChanges() > 0;
        }
    }
}
