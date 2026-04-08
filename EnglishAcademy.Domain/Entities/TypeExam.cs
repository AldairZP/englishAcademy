namespace EnglishAcademy.Domain.Entities;

public class TypeExam
{
    public Guid Id { get; init; }
    public string Type { get; init; }

    public ICollection<Exam> Exams = new List<Exam>();

    public TypeExam(string type)
    {
        if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("type cannot be null or white space");

        Id = Guid.CreateVersion7();
        Type = type;
    }
}
