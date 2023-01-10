namespace OOP.Models
{
    public class Doctor : Person
    {
        public string Type { get; set; } = String.Empty;

        public override bool GoToWork()
        {
            Console.WriteLine("Doctor to go to work");
            LunchTime();
            TakeDinner();
            return true;
        }

        private static void LunchTime()
        {
            Console.WriteLine("Doctor takes lunch");
        }

        public void Tasks()
        {

        }
    }
}