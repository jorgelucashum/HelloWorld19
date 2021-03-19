using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld19
{
    // foreach
    // Sintaxe opcional e simplificada para percorrer coleções (vetores, listas, etc) para criar o laço.
    class Program
    {
        static void Main(string[] args)
        {

            // Usando o laço comum: 'for'
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i< vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }



            // Usando o laço: 'foreach'

            foreach (string teste in vect) // vai repetir o laço pra cada elemento que contém no vetor 'vect', sem a necessidade de usar o 'for' com a variável 'i'.
            {
                Console.WriteLine(teste);
            }

        }
    }
}
