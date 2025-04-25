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
            Console.ReadKey();
        }

        static void ExcutarTarefaLonga()
        {
            Console.WriteLine("Tarefa longa iniciada");

            for (int etapa = 1; etapa <= 5; etapa++)
            {
                Console.WriteLine($"Tarefa longa - etapa {etapa}...");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Tarefa longa finalizada!");
        }
    }
}
