using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------------------
            Console.WriteLine("*********** ЗАДАНИЕ 1 **************");
            Console.WriteLine("ВВедите любой текст. В конце поставьте \".\"");
            int num = 0;
            ConsoleKeyInfo str;

            do
            {
                str = Console.ReadKey();
                if (str.KeyChar == ' ')
                    num++;
            } while (str.KeyChar != '.');


            Console.WriteLine();
            Console.WriteLine("Количество пробелов в предложении равно {0}", num);
            Console.WriteLine();




            //-------------------------------------------------------------------------------------------------------------
            Console.WriteLine("*********** ЗАДАНИЕ 2 **************");
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0; // n1 - цифра самого старшего разряда
            Console.WriteLine("Введите 6-значный номер билета");
            string st1 = Console.ReadLine();
            double number = Convert.ToDouble(st1);
            n1 = Convert.ToInt32(Math.Floor(number / 100000));
            number = number % 100000;
            n2 = Convert.ToInt32(Math.Floor(number / 10000));
            number = number % 10000;
            n3 = Convert.ToInt32(Math.Floor(number / 1000));
            number = number % 1000;
            n4 = Convert.ToInt32(Math.Floor(number / 100));
            number = number % 100;
            n5 = Convert.ToInt32(Math.Floor(number / 10));
            number = number % 10;
            n6 = Convert.ToInt32(Math.Floor(number / 1));
            number = number % 1;

            if ((n1 + n2 + n3) == (n4 + n5 + n6))
                Console.WriteLine("Поздравляем! У Вас счастливый билет!");
            else
                Console.Write("У Вас обычный билет.");
            Console.WriteLine();
            Console.WriteLine();



            //-------------------------------------------------------------------------------------------------------------
            Console.WriteLine("*********** ЗАДАНИЕ 3 **************");
            Console.WriteLine("Введите любую латинскую букву");
            char ch = Convert.ToChar(Console.Read());
            int c = Convert.ToInt32(ch);
            if (c >= 65 && c <= 90)
                c += 32;
            else if (c >= 97 && c <= 122)
                c += -32;
            Console.WriteLine("Меняю регистр введенной буквы {0} на {1}", ch, (char)c);
            Console.WriteLine();
            Console.WriteLine();



            //-------------------------------------------------------------------------------------------------------------
            Console.WriteLine("*********** ЗАДАНИЕ 4 **************");
            int A = 1;
            int B = 15;

            for(int i=A; i<=B;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

           

            //-------------------------------------------------------------------------------------------------------------
            Console.WriteLine("*********** ЗАДАНИЕ 5 **************");
            int nmb = 123456789;
            int number1 = nmb;
            int number2;
            string numberStr = "";
            int k = 10;

            while(number1 > 0)
            {
                number2 = number1 % k;
                number1 -= number2;
                number2 = number2 * 10 / k;
                numberStr = numberStr + Convert.ToString(number2);
                k *= 10;
            }

            Console.WriteLine("Число, обратное числу {0}: {1}", nmb, numberStr);
            Console.WriteLine();
        }
    }
}