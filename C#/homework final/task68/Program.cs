// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n

class AkkRecursion
    {
        static bool MaxDepth = false;
        static void Main(string[] args)
            {
                try
                    {
                        Console.WriteLine("Задайте первое число");
                        int m = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Задайте второе число");
                        int n = Convert.ToInt32(Console.ReadLine());

                        if (m < 0 || n < 0)
                            {
                                Console.WriteLine ("Отрицательные числа недопустимы");
                                return;
                            }

                        Console.WriteLine($"Результат вычислений: {Akk(m, n, 0)}");
                    }
                
                catch (FormatException)
                    {
                        Console.WriteLine("Допустимы только натуральные числа");
                    }
                
                catch (OverflowException)
                    {
                        Console.WriteLine("Введено слишком большое число");
                    }
            }

        static int Akk(int m, int n, int depth)
            {
                if (depth >= 15000)
                    {
                        if (!MaxDepth)
                            {
                                Console.WriteLine("Достигнута максимальная глубина рекурсии");
                                MaxDepth = true;
                                Environment.Exit(3);
                            }
                    }

                if (m == 0)
                    {
                        return n + 1;
                    }
                else if (n == 0)
                    {
                        return Akk(m - 1, 1, depth + 1);
                    }
                else
                    {
                        return Akk(m - 1, Akk(m, n - 1, depth + 1), depth + 1);
                    }
            }
    }