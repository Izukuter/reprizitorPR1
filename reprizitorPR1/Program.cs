using System;

namespace reprizitorPR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("строки с преобладанием положительных элементов ");

            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());

            
            double[,] matrix = new double[n, m];
            Random rand = new Random();

            // Автоматически заполняем матрицу 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Генерируем случайное целое число от -9 до 9
                    matrix[i, j] = rand.Next(-9, 10); 
                }
            }

            // Выводим сгенерированную матрицу для наглядности
            Console.WriteLine("\nСгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],4} "); // 4 символа на число для выравнивания
                }
                Console.WriteLine(); // Переход на новую строку 
            }

            Console.WriteLine("\n=== Результат анализа ===");
            int strociCount = 0; // Счётчик строк
            // Проходимся по матрице
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
                // положительных элементов больше чем отрицательных
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