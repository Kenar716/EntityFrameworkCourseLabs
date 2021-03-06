﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzy.Model
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Classification ClassificationType { get; set; }

        public enum Classification : byte
        {
            Silver = 1,
            Gold = 2,
            Platinum = 3
        }
    }
}
