using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IBase<T>
    {

        public Guid Id
        {
            get;
        }
    }
}
