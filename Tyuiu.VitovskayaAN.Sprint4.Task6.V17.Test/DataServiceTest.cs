using Tyuiu.VitovskayaAN.Sprint4.Task6.V17.Lib;
namespace Tyuiu.VitovskayaAN.Sprint4.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var progr = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(progr);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
