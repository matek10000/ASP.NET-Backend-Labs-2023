using Projekt___produkty.Models;
using System.Collections.Generic;

public interface IProductService
{
    int Add(Product product);
    void Delete(int id);
    void Update(Product product);
    List<Product> FindAll();
    Product? FindById(int id);
    PagingList<Product> FindPage(int page, int size);
}
