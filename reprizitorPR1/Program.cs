using System;

namespace reprizitorPR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("строки с преобладанием положительных элементов ");
            int n, m;
            do
            {
                Console.Write("Введите количество строк (n, от 1 до 999): ");
                string inputN = Console.ReadLine();
                if (!int.TryParse(inputN, out n) || n < 1 || n > 999)
                {
                    Console.WriteLine("❌ Ошибка: введите целое число от 1 до 999.");
                    n = 0;
                }
            } while (n < 1 || n > 999);

            do
            {
                Console.Write("Введите количество столбцов (m, от 1 до 999): ");
                string inputM = Console.ReadLine();

                if (!int.TryParse(inputM, out m) || m < 1 || m > 999)
                {
                    Console.WriteLine("Ошибка: введите целое число от 1 до 999.");
                    m = 0;
                }
            }while (m < 1 || m > 999);

         
            double[,] matrix = new double[n, m];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-9, 10); 
                }
            }
            Console.WriteLine("\nСгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],4} "); // 4 символа на число для выравнивания
                }
                Console.WriteLine(); 
            }

            Console.WriteLine("\n=== Результат анализа ===");
            int strociCount = 0; 
            for (int i = 0; i < n; i++)
            {
                int polCount = 0;     
                int otrizCount = 0;  
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > 0)
                        polCount++;
                    else if (matrix[i, j] < 0)
                        otrizCount++;
                }
                if (polCount > otrizCount)
                {
                    Console.WriteLine($"Строка {i + 1} (индекс {i}): положительных = {polCount}, отрицательных = {otrizCount}");
                    strociCount++; 
                }
            }
            if (strociCount == 0)
            {
                Console.WriteLine("Нет строк, где положительных элементов больше, чем отрицательных.");
            }
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}