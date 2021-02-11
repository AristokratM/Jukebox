using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Models
{
    public class BaseClass<T> where T : BaseClass<T>
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public BaseClass()
        {
            _id = new Guid();
        }
        public BaseClass(String name): this()
        {
            this.Name = name;
        }

    }
}
