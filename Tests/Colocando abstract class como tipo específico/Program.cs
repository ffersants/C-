using System;

namespace Colocando_abstract_class_como_tipo_específico
{
    class Program
    {
        static void Main(string[] args)
        {
            Tecnico fernando = new Tecnico("Fernando", "0022985");
            Artigo artigo1 = new Artigo(fernando, "OASIDFJ");
        }
        public class Artigo
           
        {
            public Usuario autor { get; set; }
            public string titulo { get; set; }
            public Artigo(Usuario autor, string titulo)
            {
                this.autor = autor;
                this.titulo = titulo;
            }
        }
    }
}
