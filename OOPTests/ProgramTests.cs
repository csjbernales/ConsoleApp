using Microsoft.VisualStudio.TestTools.UnitTesting;

using OOP;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static OOP.Program;

namespace OOP.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Program.Main();
            _ = new StartUp();
            StartUp.Init();
        }
    }
}