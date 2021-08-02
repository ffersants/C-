using System;
using Montar_objeto_Artigo___DITEC_Ajuda.Builder;
using Montar_objeto_Artigo___DITEC_Ajuda.Director;
namespace Montar_objeto_Artigo___DITEC_Ajuda
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtigoVazioBuilder builder = new ArtigoVazioBuilder();
            DirectorService a = new DirectorService(builder);

            
        }
    }
}
