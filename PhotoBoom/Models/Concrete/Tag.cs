using PhotoBoom.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoBoom.Models.Concrete
{
  public class Tag:Entity
  {

    [ForeignKey("Tag")]
    public int? TagId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; }

    [ForeignKey("Photo")]
    public int? PhotoId { get; set; }
    public virtual Photo Photo { get; set; }

   
    

    


  }
}
