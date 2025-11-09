using Tyuiu.VitovskayaAN.Sprint4.Task5.V30.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.Title = "Спринт #4 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти сумму положительных элементов                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите кол-во строк в массиве: ");
        int[,] matrix = new int[5, 5];
        Console.WriteLine("Случайно сгенеррированная матрица 5 на 5:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(-2, 5);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        int res = ds.Calculate(matrix);

        Console.WriteLine("###########################################################################");
        Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
        Console.WriteLine("###########################################################################");

        Console.WriteLine("Сумма положительных элементов матрицы = " + res);
        Console.ReadKey();
    }
}
