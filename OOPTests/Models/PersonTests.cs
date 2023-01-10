using FakeItEasy;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OOP.Models;

namespace OOPTests.Models
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

        [TestMethod()]
        public void GoToWorkTest2()
        {
            IPerson person = A.Fake<IPerson>();
            person.Name = "Name";
            person.Id = 0;
            person.Description = "Desc";

            A.CallTo(() => person.GoToWork()).Returns(false);

            var result = person.GoToWork();

            A.CallTo(person.GoToWork()).MustHaveHappened();
        }
    }
}