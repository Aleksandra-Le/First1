using System;

namespace FirstGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число ");

            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("введите второе число ");

            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("введите действие");

            string c = Console.ReadLine();

            float d;

            switch (c)

            {

                case "+":

                    d = a + b;

                    Console.WriteLine("Вы выбрали сложение. Рузультат сложения будет равен " + d);

                    break;

                case "-":

                    d = a - b;

                    Console.WriteLine("Вы выбрали вычистение. Результат вычитания a-b будет равен " + d);

                    break;

                case "/":

                    d = a / b;

                    Console.WriteLine("Вы выбрали деление. Результат деления a/b будет равен" + d);

                    break;

                case "*":

                    d = a * b;

                    Console.WriteLine("Вы выбрали умножение. Результат умножения переменной a на b будет равен" + d);

                    break;


                default:

                    Console.WriteLine("Введенное действие не поддерживается.");

                    break;

            }
        }
    }
}
