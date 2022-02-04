using System;

namespace CipulloEserciziStringheApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Inserisci una frase ");
            string frase = Console.ReadLine();

            int N = 0;
            int contaVocali=0;
            int contaConsonanti = 0;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine(" Inserisci una parola ");
                string parola = Console.ReadLine();

                char primoCarattere = parola[0];

                if (primoCarattere != 'a')

                {
                    contaVocali++;
                }
                else if (primoCarattere != 'e')

                {
                    contaVocali++;
                }

                else if (primoCarattere != 'i')

                {
                    contaVocali++;
                }

                else if (primoCarattere != 'o')

                {
                    contaVocali++;
                }

                else if (primoCarattere != 'u')

                {
                    contaVocali++;
                }

                else
                {
                    contaConsonanti++;
                }

                i++;

              }

                  Console.WriteLine("il numero di parole che iniziano con vocale sono" + contaVocali);
                  Console.WriteLine("il numero di parole che iniziano con consonante sono" + contaConsonanti);
          }
        }
    }
}
