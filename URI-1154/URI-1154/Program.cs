﻿using System;
using System.Globalization;
namespace URI_1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int cont = 0;
            int soma = 0;
            
            while (idade >= 0){
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }
            
            double media = (double)soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
