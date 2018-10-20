﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzy.Model
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }
    }
}