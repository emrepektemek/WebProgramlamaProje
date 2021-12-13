﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeBox.Models
{
    public class AnimeKategori
    {
        public int Id { get; set; }

        public int? AnimeId { get; set; }
        [ForeignKey("AnimeId")]
        public Studyo Anime { get; set; }

        public int? KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Studyo Kategori { get; set; }

        public int? OnemSirasi { get; set; }
    }
}
