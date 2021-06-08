using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_exercise
{
    class Employe
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public double salaray { get; private set; }

        public Employe(int id, string name, double salaray)
        {
            this.id = id;
            this.name = name;
            this.salaray = salaray;
        }
    }
}
