using Lab3___Aplikacja.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
public interface IContactService
{
    int Add(Kontakt book);
    void Delete(int id);
    void Update(Kontakt book);
    List<Kontakt> FindAll();
    Kontakt? FindById(int id);
}