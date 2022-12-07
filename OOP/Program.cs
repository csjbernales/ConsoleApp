using OOP.Models;

namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            StartUp.Init();
        }

        public class StartUp
        {
            public static void Init()
            {
                IPerson patient = new Patient();
                IPerson doctor = new Doctor();

                doctor.GoToWork();
                patient.GoToWork();
            }
        }
    }
}