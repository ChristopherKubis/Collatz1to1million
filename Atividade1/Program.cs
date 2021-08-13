using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tamanho da maior sequência encontrada
            int tamMaiorSequencia = 0;

            //Declaração da variável que servirá para encontrar o número inicial que produz maior a sequência dentre 1 e 1.000.000
            int numInicialMaiorSequencia = 0;
            
            //Laço para testar qual valor de 1 a 1.000.000 gera a maior sequência de números
            for (int i = 1; i<=13; i++)
            {
                
                //Variável que armazena o tamanho da sequência que está passando pelo problema de collatz.
                int tamDestaSequencia = 1;

                //Atribui i como número inicial da sequência.
                int numInicialDestaSequencia = i;

                //Atribui a variável anterior à outra variável para manter o valor inicial da sequência em memória.
                int numDaSequencia = numInicialDestaSequencia;

                //Exibição do número inicial da sequência que está passando pelo problema de collatz
                Console.WriteLine("===================================================================");
                Console.WriteLine("Número inicial desta sequência: " + numInicialDestaSequencia + "\n\n");
                Console.WriteLine("Número: " + numDaSequencia + " Posição: " + tamDestaSequencia);

                //Laço para aplicar o problema de Collatz para cada valor dentre 1 e 1.000.000
                while (numDaSequencia > 1)
                {
                    //Realiza a adição de + 1 à varíavel tamDestaSequencia para saber o tamanho total da sequência ao final do laço
                    tamDestaSequencia++;

                    //Se n é par, o próximo valor é n/ 2
                    if (numDaSequencia % 2 == 0)
                        numDaSequencia /= 2;
                    
                    //Se n é ímpar, o próximo valor é 3n + 1
                    else
                        numDaSequencia = (3 * numDaSequencia) + 1;

                    Console.WriteLine("Número: " + numDaSequencia + " Posição: " + tamDestaSequencia);
                }
                //Se o tamanho da maior sequência for menor que o tamanho desta sequência
                
                if (tamMaiorSequencia < tamDestaSequencia)
                {
                    //Atribui esta sequência como a maior sequência
                    tamMaiorSequencia = tamDestaSequencia;

                    //Atribui o número inicial desta sequência como o número inicial da maior sequência
                    numInicialMaiorSequencia = numInicialDestaSequencia;
                }
                //Exibição dos resultados encontrados
                Console.WriteLine("===================================================================");


            }
            //Exibição dos resultados encontrados
            Console.WriteLine("===================================================================");
            Console.WriteLine("\nTamanho da maior sequência encontrada: " + tamMaiorSequencia);
            Console.Write("\nNumero inicial que produz a maior sequência encontrada: " + numInicialMaiorSequencia + "\n\n");
            Console.WriteLine("===================================================================");
            Console.ReadLine();

        }
    }
}
