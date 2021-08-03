using Builder_para_artigo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_para_artigo.Builder.Base
{
    interface IArticleBuilder
    {
        public void setTitulo();
        public void setCorpo();
        public void setAutor(string tecnicoNome);
        public void setStatus(StatusDoArtigo status);
        public void setDataPublicacao();
        public void setPublicadoPor(string administradorNome);
        public void setRemovidoPor(string administradorNome);
    }
}
