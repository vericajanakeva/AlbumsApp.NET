using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace isptina.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        [Required]
        public string Title { get; set; }
        public decimal Price { get; set; }
        [Display(Name = "Image")]
        public string AlbumArtUrl { get; set; }
        public Genre genre { get; set; }
        public Artist artist { get; set; }
        public string Name { get; set; }
        public virtual List<Store> stores { get; set; }

        public Album()
        {
            stores = new List<Store>();
        }
    }
}