
namespace EnglishAcademy.Domain.Entities;

public class Question
{
    public Guid Id { get; init; }
    public string Description { get; set; }

    public Question(string description)
    {
        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("description cannot be null or white space");

        Id = Guid.CreateVersion7();
        Description = description;
    }

}
