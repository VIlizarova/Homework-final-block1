// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1

try
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());

        result(1);
        
        if (num < 1)
        {
            Console.Write("Число не может быть меньше 1");
        }

        void result(int i)
            {
                if (i > num) return;
                result(i + 1);
                Console.Write(i + " ");
            }
    }

catch (FormatException)
    {
        Console.WriteLine("Программа принимает только одно целое число");
        return;    
    }
catch (OverflowException)
    {
        Console.WriteLine("Слишком большое число");
        return;
    }    