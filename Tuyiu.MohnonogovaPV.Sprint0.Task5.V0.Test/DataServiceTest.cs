using Tuyiu.MohnonogovaPV.Sprint0.Task5.V0.Lib;
namespace Tuyiu.MohnonogovaPV.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
                Assert.AreEqual(10, DataService.Addition(5, 5));
            }
            [TestMethod]
            public void TestMethod2()
            {
                Assert.AreEqual(5, DataService.Subtraction(10, 5));
            }
            [TestMethod]
            public void TestMethod3()
            {
                Assert.AreEqual(50, DataService.Multiplication(10, 5));
            }
            [TestMethod]
            public void TestMethod4()
            {
                Assert.AreEqual(3, DataService.Division(9, 3));
            }
        }
    }

}
