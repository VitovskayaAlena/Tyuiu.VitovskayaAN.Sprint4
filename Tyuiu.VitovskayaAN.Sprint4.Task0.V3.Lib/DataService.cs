using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VitovskayaAN.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int p = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}
