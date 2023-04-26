using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_10
{
    internal class ahven : eläin, icanswim
    {
        public string name { get; set; }
        public int swimspeed { get ; set ; }
        public string sound { get ; set ; }

        public ahven(string _name, int _speed, string _sound)
        {
            name = _name;
            swimspeed = _speed;
            sound = _sound;
        
        }
            

        public void swim()
        {
            Console.WriteLine("kala ui {0} nopeudella{1} ", name, swimspeed);
        }

        public override void teeääni()
        {
            Console.WriteLine("burb ");
        }
    }
}
