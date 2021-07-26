using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrever_um_método_herdado_de_superclasse
{
    class Class1
    {
        public string name { get; set; }
        public bool isUnderage { get; set; }

        public Class1(string name, bool isUnderage)
        {
            this.name = name;
            this.isUnderage = isUnderage;
        }

        public string toBeOverwritten()
        {
            return "Eu sou um método da classe 1";
        }
    }
}
