﻿using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; //código unicode
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 213213123;
            long n4 = 21374836248L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maggie May";
            sbyte nx = sbyte.MinValue;
            decimal nz = decimal.MaxValue;
            
            Console.WriteLine(completo);
            System.Console.WriteLine(letra);
            System.Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            System.Console.WriteLine(n5);
            System.Console.WriteLine(n6);
            System.Console.WriteLine(nome);
            System.Console.WriteLine(nx);
            System.Console.WriteLine(nz);
            System.Console.WriteLine("\n\n");

            System.Console.WriteLine("Teste");
            System.Console.Write("Bom dia");
        } 
    }

}