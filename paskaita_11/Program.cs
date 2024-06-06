using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace paskaita_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] Numbers = { 1, 2, 3, 4, 5, 5, 2 };
            //Console.WriteLine(Numbers.Length);

            //int[] naujas = Kvadratas();
            //Console.WriteLine(naujas);

            //SumaS();
            //Sumaex();

            Atbulai();

        }

        static void Atbulai()
        {
            //int A = 0;  
            int[] A = { 1, 5, 255, 2, 9 };
            //for (int i = NewNumbers.Length; i >= 0 ; i--)
            //{
            //    A = NewNumbers[i];
            //}

            Array.Reverse(A);
            Console.WriteLine(A);
        }







        static int[] Kvadratas()
        {
            int[] NewNumbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < NewNumbers.Length; i++)
            {
                Console.WriteLine(NewNumbers[i]);
                NewNumbers[i] = NewNumbers[i] * NewNumbers[i];
                Console.WriteLine(NewNumbers[i]);

            }
            return NewNumbers; 

        }

        static void SumaS()
        {
            int[] NewNumbers = { 1, 2, 3, 4, 5 };
            int Suma = 0;
            for (int i = 0; i < NewNumbers.Length; i++)
            {
                Suma += NewNumbers[i];
                NewNumbers[i] += NewNumbers[i];
                
                
            }
            Console.WriteLine(Suma);

        }








        static void Sumaex()
        {
            int[] NewNumbers = { 1, 5, 2555, 2, 9 };
            int maxValue = 0;
            for (int i = 0; i < NewNumbers.Length; i++)
            {

                maxValue = NewNumbers.Max();

            }
            Console.WriteLine(maxValue);

        }


    }
}
