using System;

class Program 
    {
        static void Main(string[] args)
        {
            // Valores a serem recebidos
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 = 0;

            // Notas
            Console.Write("Escreva o valor da primeira nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da segunda nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da terceira nota: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da quarta nota: ");
            n4 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da quinta nota: ");
            n5 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da sexta nota: ");
            n6 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da sétima nota: ");
            n7 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da oitava nota: ");
            n8 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da nona nota: ");
            n9 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o valor da décima nota: ");
            n10 = int.Parse(Console.ReadLine());
            
            int soma = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
            int media = soma / 10;

            Console.WriteLine($"Seu resultado é de {media}.");
            
        }
    }
