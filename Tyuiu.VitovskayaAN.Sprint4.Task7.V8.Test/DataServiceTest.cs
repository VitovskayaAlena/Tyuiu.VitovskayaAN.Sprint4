using Tyuiu.VitovskayaAN.Sprint4.Task7.V8.Lib;
namespace Tyuiu.VitovskayaAN.Sprint4.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int colums = 4;
            int[,] mtrx = new int[rows, colums];
            string str = "264795863157";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, colums, str);
            int wait = 37;
            Assert.AreEqual(wait, res);
        }
    }
}
