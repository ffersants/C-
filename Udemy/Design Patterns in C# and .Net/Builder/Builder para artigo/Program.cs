using Builder_para_artigo.Builder;
using Builder_para_artigo.Builder.Base;
using Builder_para_artigo.Classes;
using System;

namespace Builder_para_artigo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ArticleBuilder();
            Director director = new Director(builder);

            director.novoArtigo("Fernando Santos Ferreira");
            Artigo artigo1 = builder.GetArtigo();

            Console.WriteLine(artigo1.ToString());

        }
    }
}
