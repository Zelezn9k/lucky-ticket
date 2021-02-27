using System;
using System.Linq;

namespace LT
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Введите номер трамвайного билета:  ");
                string str = Console.ReadLine();
                char[] ch = new char[str.Length];
                ch = str.ToCharArray();
                int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
                if (ch.Length > 3 && ch.Length < 9)
                {
                    int leftNumber = 0;
                    int rightNumber = 0;
                    for (int i = 0; i < ch.Length; i++)
                    {
                        if (i < ch.Length / 2)
                        {
                            leftNumber += ticketNumber[i];
                        }

                        else rightNumber += ticketNumber[i];
                    }

                    if (leftNumber == rightNumber)
                    {
                        Console.WriteLine("У вас счастливый билет: {0} = {1}", leftNumber, rightNumber);
                    }

                    else Console.WriteLine("У вас не счастливый билет: {0} != {1}", leftNumber, rightNumber);
                }

                else
                {
                    Console.WriteLine("Число введено не правильно!");
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Если желаете выйти нажмите  Y ");
                Console.WriteLine("Если желаете продолжить нажмите любую другую кнопку ");
            } while (Console.ReadLine() != "Y");
        }
    }
}
