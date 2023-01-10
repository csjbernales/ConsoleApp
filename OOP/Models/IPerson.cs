namespace OOP.Models
{
    public interface IPerson
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }

        bool GoToWork();
    }
}