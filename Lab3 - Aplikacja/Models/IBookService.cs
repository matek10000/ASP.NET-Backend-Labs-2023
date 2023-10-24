using Lab3___Aplikacja.Models;

public interface IContactService
{
    int Add(Kontakt book);
    void Delete(int id);
    void Update(Kontakt book);
    List<Kontakt> FindAll();
    Kontakt? FindById(int id);
}