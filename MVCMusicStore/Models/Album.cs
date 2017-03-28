using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public Genre GenreId { get; set; }
        public string Genre { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtURL { get; set; }
        public Artist Artist { get; set; }

    }
}