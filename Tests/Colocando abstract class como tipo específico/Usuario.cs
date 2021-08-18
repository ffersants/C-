using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colocando_abstract_class_como_tipo_específico
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }

        protected Usuario(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }

}
