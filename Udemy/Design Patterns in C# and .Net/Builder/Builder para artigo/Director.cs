using Builder_para_artigo.Builder.Base;
using Builder_para_artigo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_para_artigo
{
    class Director
    {
        public IArticleBuilder builder;

        public Director(IArticleBuilder b)
        {
            this.builder = b;
        }

        public void novoArtigo(string autor)
        {
            builder.setCorpo();
            builder.setTitulo();
            builder.setAutor(autor);
            builder.setStatus(StatusDoArtigo.EmDesenvolvimento);
        }
    }
}
