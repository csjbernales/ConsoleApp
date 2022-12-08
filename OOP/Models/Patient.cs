namespace OOP.Models
{
    public class Patient : Person
    {
        public string Type { get; set; } = string.Empty;
        public Doctor Doctor { get; set; } = new Doctor();

        public override void GoToWork()
        {
            Console.WriteLine("Patient to go to work");
            LunchTime();
            TakeDinner();
            TakeDinner("Pasta");
        }

        private static void LunchTime()
        {
            Console.WriteLine("Patient takes lunch");
        }

        public override void TakeDinner()
        {
            Console.WriteLine("Patient takes dinner");
        }

        public static void TakeDinner(string food)
        {
            Console.WriteLine($"Patient takes dinner with {food}");
        }
    }
}