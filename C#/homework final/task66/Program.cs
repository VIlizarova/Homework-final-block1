// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.


try
    {
        Console.WriteLine("Введите первое натуральное число");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе натуральное число");
        int n = Convert.ToInt32(Console.ReadLine());

        int min = m;
        int max = n;

        if (m > n)
            {
                min = n;
                max = m;
            }

        else if (m < 1 || n < 1)
            {
                Console.WriteLine("Программа принимает только натуральные числа");
                return;
            }
        int sum = max;
        result(max);

        void result(int i)
            {
                if (i == min) return;
                result(i - 1);
                sum = sum + (i-1);
            }

        Console.Write($"Сумма натуральных элементов в заданном диапазоне: {sum}");
    }

catch (FormatException)
    {
        Console.WriteLine("Программа принимает только натуральные числа");
        return;    
    }
catch (OverflowException)
    {
        Console.WriteLine("Слишком большое число");
        return;
    }