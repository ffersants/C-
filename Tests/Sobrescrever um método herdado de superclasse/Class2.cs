using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrever_um_método_herdado_de_superclasse
{
    class Class2 : Class1 
    {
      
        public Class2(string name, bool isUnderage) : base(name, isUnderage)
        {
            
        }
        /*
            Ao trabalhar com herança, é possível sobrescrever um método tranquilamente no C#.
            Caso este já possua uma implementação na classe pai (logo não podendo ser abstrato), ele pode ser
            tipado como virtual:

                public virtual string toBeOverwritten()

            No entanto, caso não seja implementado como virtual, basta sobrescrever o método na classe filha
            fazendo uso da palavra chave new
                
                new public string toBeOverwritten()

            Válido ressaltar que, caso o método na classe pai seja virtual, ainda assim é possível executá-lo normalmente
        */
        new public string toBeOverwritten()
        {
            return "Eu sou um método sobrescrito da classe 2";
        }
    }
}
