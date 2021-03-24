using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Domain
{
    public class Song : IBase<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Performer { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public float Duration { get; set; }
        public int ContainerId { get; set; }


        public override string ToString()
        {
            return $"{Name} {Performer} {Genre} {Author} {Duration}";
        }

    }
}
