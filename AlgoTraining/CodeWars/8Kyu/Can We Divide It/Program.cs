using System;

namespace Can_We_Divide_It
{
    class Program
    {
        static void Main(string[] args)
        {
            string div = "*******";
            Console.WriteLine("Your task is to create the functionisDivideBy (or is_divide_by) to check if an integer number is divisible by both integers a and b.");
            int number, a, b;

            Console.WriteLine("tests");
            number = -12; a = 2;b = -6;
            Console.WriteLine("number = {0}, a = {1}, b = {2} -> {3}", number, a, b, is_divide_by(number, a, b)) ;
            Console.WriteLine(div);

            number = -12; a = 2;b = -5;
            Console.WriteLine("number = {0}, a = {1}, b = {2} -> {3}", number, a, b, is_divide_by(number, a, b)) ;
            Console.WriteLine(div);

            number = 45; a = 1;b = 6;
            Console.WriteLine("number = {0}, a = {1}, b = {2} -> {3}", number, a, b, is_divide_by(number, a, b)) ;
            Console.WriteLine(div);

            number = 45; a = 5;b = 15;
            Console.WriteLine("number = {0}, a = {1}, b = {2} -> {3}", number, a, b, is_divide_by(number, a, b)) ;
            Console.WriteLine(div);

            number = 4; a = 1;b = 4;
            Console.WriteLine("number = {0}, a = {1}, b = {2} -> {3}", number, a, b, is_divide_by(number, a, b)) ;
            Console.WriteLine(div);

            number = 15; a = -5;b = 3;
            Console.WriteLine("number = {0}, a = {1}, b = {2} -> {3}", number, a, b, is_divide_by(number, a, b)) ;
            Console.WriteLine(div);



            static bool is_divide_by(int number, int a, int b)
            {
                return (number % a == 0) && (number % b == 0) ? true : false;
            }

        }
    }
}
