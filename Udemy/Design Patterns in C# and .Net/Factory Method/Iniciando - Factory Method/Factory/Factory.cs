using Iniciando___Factory_Method.Classes;
using Iniciando___Factory_Method.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciando___Factory_Method.Factory
{
    class Factory
    {
        public Factory() { }
        public static PapelariaProduct createPaper()
        {
            return new Paper();
        }
    }
}
