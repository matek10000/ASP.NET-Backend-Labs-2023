using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Lab3___Aplikacja.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly AppDbContext _dbContext;
        private readonly List<Kontakt> _kontakty;
        private Dictionary<int, Kontakt> _items = new Dictionary<int, Kontakt>();

        public MemoryContactService()
        {
            _kontakty = new List<Kontakt>();
        }



        public int Add(Kontakt item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Update(Kontakt item)
        {
            _items[item.Id] = item;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Kontakt> FindAll()
        {
            return new List<Kontakt>() { new Kontakt() { Id = 1 } };
        }

        public Kontakt? FindById(int id)
        {
            if (_items.ContainsKey(id))
            {
                return _items[id];
            }
            return null;
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return _dbContext.Organizations.ToList();
        }

        public PagingList<Kontakt> FindPage(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
