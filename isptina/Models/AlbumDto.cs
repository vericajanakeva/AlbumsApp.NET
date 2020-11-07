﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isptina.Models
{
    public class AlbumDto
    {
        public int Id { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }
       
        public string Title { get; set; }

        public decimal Price { get; set; }
      
        public string AlbumArtUrl { get; set; }

        public Genre genre { get; set; }

        public Artist artist { get; set; }

        public string Name { get; set; }
    }
}