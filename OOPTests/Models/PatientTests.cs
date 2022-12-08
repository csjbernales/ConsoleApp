using Microsoft.VisualStudio.TestTools.UnitTesting;

using OOP.Models;

namespace OOPTests.Models
{
    [TestClass()]
    public class PatientTests
    {
        private Patient patient;

        [TestInitialize]
        public void Init()
        {
            patient = new Patient();
        }

        [TestMethod()]
        public void GoToWorkTest()
        {
            Init();
            patient.Id = 1;
            patient.Name = "Test";
            patient.Description = "Test";
            patient.Type = "Test";
            patient.Doctor = new Doctor() { Name = "", Type = "", Description = "", Id = 0 };

            Assert.AreEqual(1, patient.Id);
            Assert.AreEqual("Test", patient.Name);
            Assert.AreEqual("Test", patient.Description);
            Assert.AreEqual("Test", patient.Type);
            Assert.IsNotNull(patient.Doctor);
            patient.GoToWork();
        }

        [TestMethod()]
        public void TakeDinnerTest()
        {
            patient.TakeDinner();
        }

        [TestMethod()]
        public void TakeDinnerWithParamTest()
        {
            Patient.TakeDinner("Sushi");
        }
    }
}