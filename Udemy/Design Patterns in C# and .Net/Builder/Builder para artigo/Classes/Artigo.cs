using Builder_para_artigo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_para_artigo.Classes
{
    class Artigo
    {
        public string titulo, corpo, publicador, autor, removedor;
        public StatusDoArtigo status;
        public DateTime dataPublicacao;

        public override string ToString()
        {
            return (
                $"{titulo.ToUpper()} " +
                $"\n {corpo}" +
                $"\n\n Autor: {autor}\n Status: {status}"
                );
        }
    }
}
