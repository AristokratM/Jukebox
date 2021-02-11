using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IDataReader
    {
        public String GetContainerName();

        public String GetContainerItemAuthor();

        public String GetUserBalance();

        public String GetContainerItemGenre();

        public String GetContainerItemPerformer();
    }
}
