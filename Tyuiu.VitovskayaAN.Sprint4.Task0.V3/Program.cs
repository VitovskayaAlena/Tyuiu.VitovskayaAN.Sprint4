using Tyuiu.VitovskayaAN.Sprint4.Task0.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Подсчитать произведение нечетных элементов массива                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.WriteLine(numsArray[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Результат = " + ds.GetMultOddArrEl(numsArray));

        Console.WriteLine();
        Console.ReadKey();
    }
}
