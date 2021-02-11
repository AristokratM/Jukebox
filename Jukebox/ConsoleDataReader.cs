using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Interfaces;
namespace Jukebox
{
    public class ConsoleDataReader : IDataReader
    {
        public string GetContainerItemAuthor()
        {
            Console.WriteLine("Enter Song Author or Press Enter");
            return Console.ReadLine();
        }

        public string GetContainerItemGenre()
        {
            Console.WriteLine("Enter Song Genre or Press Enter");
            return Console.ReadLine();
        }

        public string GetContainerItemPerformer()
        {
            Console.WriteLine("Enter Song Performer or Press Enter");
            return Console.ReadLine();
        }

        public string GetContainerName()
        {
            Console.WriteLine("Enter Album Name or Press Enter");
            return Console.ReadLine();
        }

        public String GetUserBalance()
        {
            Console.WriteLine("Waiting user balance from system...");
            return Console.ReadLine();

        }
    }
}
