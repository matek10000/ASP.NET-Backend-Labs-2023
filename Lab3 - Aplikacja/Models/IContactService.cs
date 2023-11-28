using Data.Entities;
using Lab3___Aplikacja.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
public interface IContactService
{
    public int Add(Kontakt book);
    public void Delete(int id);
    public void Update(Kontakt book);
    List<Kontakt> FindAll();
    Kontakt? FindById(int id);
    List<OrganizationEntity> FindAllOrganizations();
    PagingList<Kontakt> FindPage(int page, int size);
}