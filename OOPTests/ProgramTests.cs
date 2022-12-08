using Microsoft.VisualStudio.TestTools.UnitTesting;

using static OOP.Program;

namespace OOPTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Main();
            _ = new StartUp();
            StartUp.Init();
        }
    }
}