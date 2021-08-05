using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Montar_objeto_Artigo___DITEC_Ajuda.Builder.Base;
using Montar_objeto_Artigo___DITEC_Ajuda.Class;

namespace Montar_objeto_Artigo___DITEC_Ajuda.Builder
{
    class ArtigoVazioBuilder : IArtigoVazio
    {
        Artigo _artigo = new Artigo();

        public void Reset()
        {
            this._artigo = new Artigo();
        }
        public void inserirCorpo()
        {
            _artigo.corpo = "Corpo vazio";
        }

        public void inserirTitulo()
        {
            _artigo.titulo = "Titulo vazio";
        }

        public Artigo getArtigo()
        {
            var artigo = this._artigo;
            Reset();
            return artigo;
        }
    }
}
