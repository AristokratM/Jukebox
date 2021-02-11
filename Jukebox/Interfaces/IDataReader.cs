using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IDataReader
    {
        public String GetContainerName();

        public String GetContainerItemAuthor();

        public Single GetUserBalance();

        public String GetContainerItemGenre();

        public String GetContainerItemPerformer();
    }
}
