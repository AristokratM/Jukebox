using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data
{
    public class BaseClass
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id == null ? new Guid() : _id; }
        }
    }
}
