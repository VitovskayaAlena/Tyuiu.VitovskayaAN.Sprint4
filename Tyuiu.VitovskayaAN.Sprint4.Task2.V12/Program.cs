using Tyuiu.VitovskayaAN.Sprint4.Task2.V12.Lib;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы.(генератор случайных чисел)                    *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Подсчитать сумму нечетных элементов массива                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(5, 20);
        }
        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArray);

        Console.WriteLine("Сумма нечетных элементов = "+ res);
        Console.ReadKey();
    }
}
