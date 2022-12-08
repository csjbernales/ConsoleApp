using Microsoft.VisualStudio.TestTools.UnitTesting;

using OOP.Models;

namespace OOPTests.Models
{
    [TestClass()]
    public class DoctorTests
    {
        private Doctor doctor;

        [TestInitialize]
        public void Init()
        {
            doctor = new Doctor();
        }

        [TestMethod()]
        public void GoToWorkTest()
        {
            Init();
            doctor.Id = 1;
            doctor.Name = "Test";
            doctor.Description = "Test";
            doctor.Type = "Test";

            Assert.AreEqual(1, doctor.Id);
            Assert.AreEqual("Test", doctor.Name);
            Assert.AreEqual("Test", doctor.Description);
            Assert.AreEqual("Test", doctor.Type);

            doctor.TakeDinner();
            doctor.GoToWork();
        }
    }
}