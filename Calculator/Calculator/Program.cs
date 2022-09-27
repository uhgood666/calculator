using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод первого значения
            Console.Write("Enter first value: ");
            int no1 = int.Parse(Console.ReadLine());

            // Ввод второго значения
            Console.Write("Enter second value: ");
            int no2 = int.Parse(Console.ReadLine());

            // Вывод информации для операции сложение
            Console.WriteLine("Enter 1 for addition");

            // Вывод информации для операции вычитание
            Console.WriteLine("Enter 2 for subtraction");

            // Вывод информации для операции умножение
            Console.WriteLine("Enter 3 for multiplication");

            // Вывод информации для операции деление
            Console.WriteLine("Enter 4 for division");

            // Выбор операции
            Console.Write("Enter an operation to perform: ");
            int op = int.Parse(Console.ReadLine());

            // Операция сложение
            if (op == 1)
            {
                int sum = no1 + no2;
                Console.WriteLine("Value = " + sum);
            }

            // Операция Вычитание
            else if (op == 2)
            {
                int sub = no1 - no2;
                Console.WriteLine("Value = " + sub);
            }

            // Операция умножение
            else if (op == 3)
            {
                int mul = no1 * no2;
                Console.WriteLine("Value = " + mul);
            }

            // Операция деление
            else if (op == 4)
            {
                int div = no1 / no2;
                Console.WriteLine("Value = " + div);
            }

            // Вывод при неправильной операции
            else
            {
                Console.WriteLine("Invalid operation!");
            }

            Console.WriteLine("Operation completed!");

            Console.ReadLine();
        }
    }
}
