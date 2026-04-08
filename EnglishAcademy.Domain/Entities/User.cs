
namespace EnglishAcademy.Domain.Entities;

public class User
{
    public Guid Id { get; init; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public ICollection<Exam> Exams { get; private set; } = new List<Exam>();

    public User(string userName, string password)
    {
        if (string.IsNullOrWhiteSpace(userName)) throw new ArgumentException("userName cannot be null or white space");
        if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("password cannot be null or white space");

        Id = Guid.CreateVersion7();
        UserName = userName;
        Password = password;
    }


}
