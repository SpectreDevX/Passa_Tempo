using System;
using System.Collections.Generic;

namespace CShp_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> pato = new Dictionary<string, int>();

            pato.Add("pato", 1);
            pato.Add("coelho", 2);
            pato.Add("galinha", 3);

            Dictionary<string, int> pato2 = new Dictionary<string, int>();
            {
                pato2.Add("pato", 1);
                pato2.Add("coelho", 2);
                pato2.Add("galinha", 3);
            }
            ;
            foreach (KeyValuePair<string, int> item in pato)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            Console.WriteLine("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Você escolheu o pato");
            }
            else if (numero == 2)
            {
                Console.WriteLine("Você escolheu o coelho");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Você escolheu a galinha");
            }
            else
            {
                Console.WriteLine("Número inválido");



            }
        }
    }
}



