using Tyuiu.MohnonogovaPV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Полина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Полина", res);

        }
    }
}