﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Domain
{
    public class Album : IBase<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float ItemPlayPrice { get; set; }

        public override string ToString()
        {
            return $"{Name} {ItemPlayPrice} {ReleaseDate}";
        }
    }
}
