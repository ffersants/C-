using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___Agora_vai
{
    class Director
    {
        public IBuilder builder { get; set; }

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void make()
        {
            builder.setarTitulo();
        }

        
    }
}
