namespace OOP.Models
{
    public class Doctor : Person
    {
        public string Type { get; set; } = String.Empty;

        public override void GoToWork()
        {
            Console.WriteLine("Doctor to go to work");
            LunchTime();
            TakeDinner();
        }


        private static void LunchTime()
        {
            Console.WriteLine("Doctor takes lunch");
        }
    }
}
