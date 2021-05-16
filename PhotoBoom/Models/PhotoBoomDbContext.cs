using Microsoft.EntityFrameworkCore;
using PhotoBoom.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoBoom.Models
{
  public class PhotoBoomDbContext:DbContext
  {
    public PhotoBoomDbContext()
    {


    }
    public PhotoBoomDbContext(DbContextOptions<PhotoBoomDbContext> options)
       : base(options)
    {
    }
    public virtual DbSet<Photo> Photos { get; set; }
    public virtual DbSet<Tag> Tags { get; set; }
  }
}
