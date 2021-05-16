using Microsoft.EntityFrameworkCore;
using PhotoBoom.Models.Base;
using PhotoBoom.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PhotoBoom.Models.Repository
{
  public class UnitOfWork:IUnitOfWork
  {
    private readonly PhotoBoomDbContext _dbContext;
    public UnitOfWork(PhotoBoomDbContext dbContext)
    {
      _dbContext = dbContext;
    }
    public T Add<T>(T entity) where T : Entity
    {
      _dbContext.Add(entity);
      return entity;
    }

    public IQueryable<T> All<T>() where T : Entity
    {
      return Query<T>();
    }

    public bool Delete<T>(T entity) where T : Entity
    {
      _dbContext.Remove(entity);

      return true;
    }

    public T FirstOrDefault<T>(Expression<Func<T, bool>> where) where T : Entity
    {
      return Query<T>().FirstOrDefault(where);
    }

    public T FirstOrDefaultInclude<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes) where T : Entity
    {
      if (includes.Length > 0)
        return Query<T>().IncludeMultiple(includes).FirstOrDefault(where);

      return Query<T>().FirstOrDefault(where);
    }

    public DbSet<T> Query<T>() where T : Entity
    {
      return _dbContext.Set<T>();
    }

    public void Save()
    {
      _dbContext.SaveChanges();
    }

    public bool Update<T>(T entity) where T : Entity
    {
      _dbContext.Update(entity);

      return true;
    }

    public IQueryable<T> WhereInclude<T>(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes) where T : Entity
    {
      return Query<T>().IncludeMultiple(includes).Where(where);
    }
  }
}
