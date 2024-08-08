using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Missile
    {
        public Missile() { }

        public string Name { get; set; }
        public double Speed { get; set; }
        public double Mass { get; set; }
        public double Time { get; set; }
        public Dictionary<string, int> Origin { get; set; }
        public Dictionary<string, int> Angle { get; set; }
        public int Demage { get; set; }

    }
}
