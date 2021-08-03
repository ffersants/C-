using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_para_artigo.Builder.Base;
using Builder_para_artigo.Classes;
using Builder_para_artigo.Enums;

namespace Builder_para_artigo.Builder
{
    class ArticleBuilder : IArticleBuilder
    {
        Artigo _artigo = new Artigo();

        public Artigo GetArtigo()
        {
            return this._artigo;
            this.Restart();
        }

        public void Restart()
        {
            this._artigo = new Artigo();
        }
        public void setAutor(string tecnicoNome)
        {
            this._artigo.autor = tecnicoNome;
        }
        public void setTitulo()
        {
            this._artigo.titulo = "Novo artigo";
        }

        public void setCorpo()
        {
            this._artigo.corpo = "Digite aqui o corpo do artigo.";
        }

        public void setDataPublicacao()
        {
            this._artigo.dataPublicacao = DateTime.Today;
        }

        public void setPublicadoPor(string administradorNome)
        {
            this._artigo.publicador = administradorNome;
        }

        public void setRemovidoPor(string administradorNome)
        {
            this._artigo.removedor = administradorNome;
        }

        public void setStatus(StatusDoArtigo status)
        {
            this._artigo.status = status;
        }
    }
}
