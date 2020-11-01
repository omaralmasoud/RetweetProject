using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retweet_Done.Classes
{
    class SystemOP
    {
        private int id;
        private int ready;
        private int prioud_end;
        private string noti;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Ready
        {
            get { return ready; }
            set { ready = value; }
        }

        public int Prioud_end
        {
            get { return prioud_end; }
            set { prioud_end = value; }
        }

        public string  Noti
        {
            get { return noti; }
            set { noti = value; }
        }


    }
}
