

using System;

namespace Implementando_interface_IComparable
{
    class Servidor : IComparable
    {
        public string name;
        public double salario;

        public Servidor(string geral)
        {
            string[] result = geral.Split(",");
            this.name = result[0];
            this.salario = double.Parse(result[1]);
        }

        public override string ToString()
        {
            return $"Servidor: {name} || Salario: {salario}";
        }
        //definição do "comparador" a ser utilizado pelo método sort
        public int CompareTo(object obj)
        {
            try
            {
                if(!(obj is Servidor))
                {
                    throw new ArgumentException("Esperado objeto com tipo Servidor.");
                }
                Servidor otheServidor = obj as Servidor;
                //ordernar por salário
                //return salario.CompareTo(otheServidor.salario);
                //ordernar por nome
                return name.CompareTo(otheServidor.name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new NotImplementedException();
            }
        }
    }
}
