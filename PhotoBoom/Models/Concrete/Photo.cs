using Microsoft.AspNetCore.Http;
using PhotoBoom.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoBoom.Models.Concrete
{
  public class Photo:Entity
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Title { get; set; }

    [Required]
    public string Tags { get; set; }
    
    [Column(TypeName = "nvarchar(100)")]
    [DisplayName("Image Name")]
    public string ImageName { get; set; }

    [Required]
    [NotMapped]
    [DisplayName("Upload File")]
    public IFormFile ImageFile { get; set; }
  }
}
