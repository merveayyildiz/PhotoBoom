using Microsoft.EntityFrameworkCore;
using PhotoBoom.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PhotoBoom.Models.Repository
{
  public interface IUnitOfWork
  {
    DbSet<T> Query<T>() where T : Entity;

    T Add<T>(T entity) where T : Entity;

    bool Update<T>(T entity) where T : Entity;

    bool Delete<T>(T entity) where T : Entity;

    void Save();

    IQueryable<T> All<T>() where T : Entity;

    T FirstOrDefault<T>(Expression<Func<T, bool>> where) where T : Entity;
  }
}
