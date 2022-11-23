﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIntroApp
{
    public class Photo
    {
        public Photo(string path)
        {
            Source = path;
        }

        public string Source { get; }

        public override string ToString() => Source;
    }
}
