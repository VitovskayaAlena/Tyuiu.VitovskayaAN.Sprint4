using Tyuiu.VitovskayaAN.Sprint4.Task6.V17.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* подсчитайте количество элементов, длина которых равна 6                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        var progr = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < progr.Length; i++)
        {
            Console.WriteLine(progr[i]);
        }

        Console.WriteLine("###########################################################################");
        Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
        Console.WriteLine("###########################################################################");

        Console.WriteLine("Количество элементов длина которых = 6: " + ds.Calculate(progr));
        Console.ReadKey();
    }
}
