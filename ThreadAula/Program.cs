using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadAula
{
    internal class Program
    {
        // Meu software é um processo e o main é minha Thread principal.
        static void Main(string[] args)
        {

            Console.WriteLine("Thread principal iniciada!");

            ExcutarTarefaLonga();

            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine($"Thread principal - etapa {i}");
                Thread.Sleep(500);
            }

            Console.WriteLine("Thread principal concluída!");
            Console.ReadKey();


        }

        static void ExcutarTarefaLonga()
        {
            Console.WriteLine("Tarefa longa iniciada");

            for (int etapa = 1; etapa <= 5; etapa++)
            {
                // 1o: printar no Console.
                Console.WriteLine($"Tarefa longa - etapa {etapa}...");

                // 2o: dorme por mil ciclos (mt rápido)
                Thread.Sleep(1000);
            }

            Console.WriteLine("Tarefa longa finalizada!");
        }
    }
}
