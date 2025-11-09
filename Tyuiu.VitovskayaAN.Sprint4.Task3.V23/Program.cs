using Tyuiu.VitovskayaAN.Sprint4.Task3.V23.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Подсчитайте количество четных элементов во всем массиве                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[5, 5]    { { 5, 7, 7, 6, 3 },
                                          { 8, 7, 8, 4, 3 },
                                          { 5, 6, 7, 8, 3 },
                                          { 4, 2, 3, 6, 4 },
                                          { 5, 2, 4, 2, 3 } };

        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;

        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        int count = ds.Calculate(array);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество чётных элементов в массиве = " + count);


        Console.ReadKey();
    }
}
