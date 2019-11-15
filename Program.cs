using System;

namespace chatbot
{
    class Program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá humano, tudo bem?");
            Console.WriteLine("\ts - Sim");
            Console.WriteLine("\tn - Não");
            Console.Write("Qual é a sua opçao? ");

            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine("Fico feliz, qual é a tua linguagem de programação favorita?");                                      
                    break;
                case "n":
                    Console.WriteLine("É lidar!");
                    break;

            }

        }
    }
}
