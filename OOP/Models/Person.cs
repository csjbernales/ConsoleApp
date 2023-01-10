namespace OOP.Models
{
    public abstract class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public abstract bool GoToWork();

        public virtual void TakeDinner()
        {
            Console.WriteLine("Person virtual dinner");
        }
    }
}