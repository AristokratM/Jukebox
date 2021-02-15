using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Interfaces;
using Jukebox.Filters;
namespace Jukebox
{
    public class ConsoleDataReader : IDataReader
    {
        public IFiltrator<IContainer> GetContainerFilter()
        {
            return new ContainerFilter(GetUserBalance(), GetContainerName());
        }


        public IFiltrator<IContainerItem> GetContainerItemFilter()
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

        private Single GetUserBalance()
        {
            Console.WriteLine("Waiting user balance from system...");
            return Convert.ToSingle(Console.ReadLine());

        }
    }
}
