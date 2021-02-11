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
            return Console.ReadLine();
        }

        public string GetContainerItemGenre()
        {
            return Console.ReadLine();
        }

        public string GetContainerItemPerformer()
        {
            return Console.ReadLine();
        }

        public string GetContainerName()
        {
            return Console.ReadLine();
        }

        public Single GetUserBalance()
        {
            return Convert.ToSingle(Console.ReadLine());

        }
    }
}
