using Microsoft.VisualStudio.TestTools.UnitTesting;
using Experience1;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // ≤‚ ‘”√¿˝1
            Program.A = 1;
            Program.B = 1;
            Program.X = 1;
            Program p = new Program();
            p.InputTest();
            Assert.IsTrue(Program.X == 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // ≤‚ ‘”√¿˝2
            Program.A = 1;
            Program.B = 1;
            Program.X = 2;
            Program p = new Program();
            p.InputTest();
            Assert.IsTrue(Program.X == 3);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // ≤‚ ‘”√¿˝3
            Program.A = 3;
            Program.B = 1;
            Program.X = 2;
            Program p = new Program();
            p.InputTest();
            Assert.IsTrue(Program.X == 3);
        }
        [TestMethod]
        public void TestMethod4()
        {
            // ≤‚ ‘”√¿˝4
            Program.A = 2;
            Program.B = 1;
            Program.X = 2;
            Program p = new Program();
            p.InputTest();
            Assert.IsTrue(Program.X == 3);
        }
        [TestMethod]
        public void TestMethod5()
        {
            // ≤‚ ‘”√¿˝5
            Program.A = 2;
            Program.B = 0;
            Program.X = 4;
            Program p = new Program();
            p.InputTest();
            Assert.IsTrue(Program.X == 3);
        }
    }
}
