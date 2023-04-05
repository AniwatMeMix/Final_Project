using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Personnel
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Worker { get; set; }
        public string Time { get; set; }

        public Personnel(string name, string lastname, string worker, string time)
        {

            Name = name;
            Lastname = lastname;
            Worker = worker;
            Time = time;
        }
    }
}
