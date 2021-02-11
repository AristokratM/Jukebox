using System;
using Jukebox.Models;
namespace Jukebox
{
    class Jukebox
    {
        private Single Balance { get; set; }

        static void Main(string[] args)
        {
            Album al = new Album("Cool", DateTime.Now, 5);
            Console.WriteLine(al);
        }
    }
}
