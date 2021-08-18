using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colocando_abstract_class_como_tipo_específico
{
    class Tecnico : Usuario
    {
        public Tecnico(string nome, string matricula) : base(nome, matricula) { }
    }
}
