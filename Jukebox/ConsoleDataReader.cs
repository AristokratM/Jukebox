using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Abstract;
using Jukebox.Domain.Filters;
using Jukebox.Domain.Abstract;
using Jukebox.Domain;

namespace Jukebox
{
    public class ConsoleDataReader : IDataReader
    {
        public IFiltrator<Album> GetContainerFilter()
        {
            return new ContainerFilter(GetUserBalance(), GetContainerName());
        }


        public IFiltrator<Song> GetContainerItemFilter()
        {
            return new ContainerItemFilter(GetContainerItemAuthor(), GetContainerItemGenre(), GetContainerItemPerformer());
        }

        private string GetContainerItemAuthor()
        {
            Console.WriteLine("Enter Song Author or Press Enter");
            return Console.ReadLine();
        }

        private string GetContainerItemGenre()
        {
            Console.WriteLine("Enter Song Genre or Press Enter");
            return Console.ReadLine();
        }

        private string GetContainerItemPerformer()
        {
            Console.WriteLine("Enter Song Performer or Press Enter");
            return Console.ReadLine();
        }

        private string GetContainerName()
        {
            Console.WriteLine("Enter Album Name or Press Enter");
            return Console.ReadLine();
        }

        private float GetUserBalance()
        {
            Console.WriteLine("Waiting user balance from system...");
            float balance;
            try
            {
               balance = Convert.ToSingle(Console.ReadLine());
            }
            catch(FormatException)
            {
                balance = 0;
            }
            return balance;

        }
    }
}
