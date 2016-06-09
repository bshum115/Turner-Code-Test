using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class DesignPattern
    {
        private String Name = "";

        public String globalName
        {
            get { return Name; }
            set { Name = globalName; }
        }
    }
}
