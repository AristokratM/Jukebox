﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Models.Abstract;
namespace Jukebox.Models
{
    public class SongModel : IContainerItemModel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Performer { get; set; }
        public String Genre { get; set; }
        public String Author { get; set; }
        public Single Duration { get; set; }
        public Int32 ContainerId { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", Name, Genre, Author, Performer, Duration);
        }
    }
}
