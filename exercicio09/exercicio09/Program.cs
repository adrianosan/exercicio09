using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0;
            int resultado = 0;
            Console.Write("Digite o Primeiro Número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("A soma é {0}", resultado);



        }

    }
}
