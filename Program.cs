using System;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void task_1()
        {
            Console.WriteLine("Введите значение x:");
            int x = int.Parse(Console.ReadLine());
            int y = 7 * x * x + 3 * x + 6;  // операторы: *-+/% - знаки операций; операнды: числа - объекты, участвующие в операции
            Console.Write("x равен ");
            Console.WriteLine(y);
        }
        static void task_2()
        {
            Console.WriteLine("\nВведите значение a:"); // "\nВведите значение а:"
            int a = int.Parse(Console.ReadLine());
            int x = 12 * a * a + 7 * a + 12;
            Console.Write("a равно ");
            Console.WriteLine(x);
        }
        static void task_3()
        {
            int a = 5;
            int P = 4 * a;
            Console.WriteLine("Периметр равен " + P); 
        }
        static void task_4()
        {
            Console.WriteLine("Введите радиус окружности:");
            int r = int.Parse(Console.ReadLine());
            int d = 2 * r;
            Console.WriteLine("Диаметр равен " + d);
        }
        static void task_array_5()
        {
            int[] numbers = { 10, 50 };
            //for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine(numbers[i]);
                Console.WriteLine(numbers[^1]);
                Console.WriteLine(numbers[^2]);
            }
        }
        static void arithmetic_6()
        {
            Console.WriteLine("Введите расстояние в сантиметрах: ");
            int x = int.Parse(Console.ReadLine());  //расстояние в см
            int y = x / 100;
            Console.WriteLine("Число полных метров: " + y);

        }
        static void arithmetic_7()
        {
            Console.WriteLine("Введите массу в кг: ");
            int x = int.Parse(Console.ReadLine());
            int y = x/1000;
            Console.WriteLine("Число полных тонн равно: " + y);
        }
        static void arithmetic_8()
        {
            int x = 234;
            Console.WriteLine($"Прошло: {x} дней");
            int y = x / 7;
            Console.WriteLine("Прошло полных недель: " + y);
        }
        static void arithmetic_9()
        {
            Console.WriteLine("Введите кол-во секунд: ");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"С начала суток прошло {n} секунд");

            int a = n / 3600;  // кол-во полных часов, прошедших с начала суток
            Console.WriteLine($"{a} полных часов прошло с начала суток");

            int b = a * 60;  // кол-во полных минут, прошедших с начала очередного часа
            Console.WriteLine($"{b} полных минут прошло с начала очередного часа");

            int c = b * 60; // кол-во полных секунд, прошедших с начала очередной минуты
            Console.WriteLine($"{c} полных секунд прошло с начала очередной минуты");
        }
        static void arithmetic_10()
        {
            int a = 543;
            int b = 130; // стороны прямоугольника

            int c = 130; // стороны квадрата

            int x = a / c;
           
            Console.WriteLine($"{x} квадрата(ов) можно отрезать от прямоугольника");
        }

        /* Примеры для закрепления материала */

        static void name_1()
        {
            Console.WriteLine("Введите ваше имя: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
        static void name_2()
        {
            Console.WriteLine("Введите ваше имя: ");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Привет, {0}! ", name);
        }
        static void array_1()
        {
            int[] numbers1 = { 45, 56, 67, 78 };
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
            }
        }
        static void array_2()
        {
            string[] names = { "Jonathan", "Joseph", "Jotaro", "Josuke", "Giorno" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static void max_v()
        {
            Console.WriteLine(int.MaxValue);
        }
        static void money()
        {
            var eurosCount = 100;

            var dollarsPerEuro = 1.25;
            var rublesPerDollar = 60;

            var dollarsCount = eurosCount * dollarsPerEuro;
            Console.WriteLine("The prise is " + dollarsCount + " dollars");

            var rublesCount = dollarsCount * rublesPerDollar;
            Console.WriteLine("The prise is " + rublesCount + " rubles");
        }
        static void logicalOperation ()
        {
            int num1 = 4;
            int num2 = 10;

            //if (num1 < num2 && num1!=num2)

            if (num1 < num2)
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            else
                Console.WriteLine($"Число {num1} больше числа {num2}");
        }
        static void yourName()
        {
            string name = "Jotaro";

            if (name == "Joseph")
                Console.WriteLine("Your name is Joseph");

            else if (name == "Jonathan")
                Console.WriteLine("Your name is Jonathan");

            else if (name == "Josuke")
                Console.WriteLine("Your name is Josuke");

            else 
                Console.WriteLine("Your name is Giorno");
        }
        static void ternaryOperation ()
        {
            int x = 12;
            int y = 5;

            int z = x > y ? (x - y) : (x + y);
            Console.WriteLine(z);
        }
        static void appropriation()
        {
            int a = 3;
            int b = 4 * 2;
            int c = a -= b; // b = a - b = 3 - 8 = -5
            Console.WriteLine($"Число: {c}"); // Число: -5
        }
    }
}

