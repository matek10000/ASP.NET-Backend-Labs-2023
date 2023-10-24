namespace Lab3___Aplikacja.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, Kontakt> _items = new Dictionary<int, Kontakt>();
        public int Add(Kontakt item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Kontakt> FindAll()
        {
            return _items.Values.ToList();
        }

        public Kontakt? FindById(int id)
        {
            return _items[id];
        }

        public void Update(Kontakt item)
        {
            _items[item.Id] = item;
        }
    }
}
