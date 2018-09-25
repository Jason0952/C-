using BizDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BizDataLibrary.Repositories
{
    public class BizRepository<T> where T : class
    {
        private BizModel _context;
        public BizRepository(BizModel context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            _context = context;
        }

        protected BizModel Context { get { return _context; } }

        public void Create(T value)
        {
            _context.Entry(value).State = System.Data.Entity.EntityState.Added;
        }

        public void Update(T value)
        {
            _context.Entry(value).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(T value)
        {
            _context.Entry(value).State = System.Data.Entity.EntityState.Deleted;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }
    }
}