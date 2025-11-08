using Tyuiu.VitovskayaAN.Sprint4.Task2.V12.Lib;
namespace Tyuiu.VitovskayaAN.Sprint4.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
            int res = ds.Calculate(numsArray);
            int wait = 79;
            Assert.AreEqual(wait, res);
        }
    }
}
