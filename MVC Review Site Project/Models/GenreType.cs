using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Review_Site_Project.Models
{
    public class GenreType
    {
        [Key]
        public int ID { get; set; }
        public string Genre { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}