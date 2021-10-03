using System;

namespace UsandoIfElseMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;

            Console.WriteLine("Digite o mês na qual deseja saber a quantidade de dias");
            mes = Convert.ToInt16(Console.ReadLine());

            if (mes == 1)
            { 
                 Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
            }

            if (mes == 3)
            {
                 Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
            }

            if (mes == 5)
            {
                 Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");  
            }

            if (mes == 7)
            {
                 Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
            }

            if (mes == 8)
            {
                 Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
            }

            if (mes == 10)
            {
                 Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
            }

            if (mes == 12)
            {
                 Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 31 dias!");
            }

            if (mes == 2)
            {
                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 28 dias, porém se for ano bissexto esse mês terá 29 dias!");
            }

            else 
            {
                Console.WriteLine($"Sua resposta foi: {mes}, esse mês tem 30 dias!");
            }

        }
    }
}