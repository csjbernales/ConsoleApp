using Microsoft.VisualStudio.TestTools.UnitTesting;

using OOP.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models.Tests
{
    [TestClass()]
    public class PersonTests
    {
        private Person patient;

        [TestInitialize]
        public void Init()
        {
            patient = new Patient
            {
                Id = 1,
                Name = "Test",
                Description = "Test"
            };

            Assert.AreEqual(1, patient.Id);
            Assert.AreEqual("Test", patient.Name);
            Assert.AreEqual("Test", patient.Description);

            patient = new Doctor();
        }

        [TestMethod()]
        public void GoToWorkTest()
        {
            Init();
            patient.GoToWork();
        }
    }
}