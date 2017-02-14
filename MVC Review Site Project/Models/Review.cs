using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Review_Site_Project.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Artist { get; set; }
        public string Album {get; set;}
        public string AlbumReview { get; set; }
        public double Rating { get; set; }
        public string QuickReview { get; set; }

        [ForeignKey("Genre")]
        public int GenreID { get; set; }
        public virtual GenreType Genre { get; set; }

    }
}