using ProductData;
using ProductData.Entities;
using Projekt___produkty.Models; // Poprawiona przestrzeń nazw
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt___produkty.Models // Poprawiona przestrzeń nazw
{
    public class EFProductService : IProductService
    {
        private readonly AppDbContext _context;

        public EFProductService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Product product)
        {
            var entity = _context.Products.Add(ProductMapper.ToEntity(product));
            int id = entity.Entity.Id;
            _context.SaveChanges();
            return id;
        }

        public void Update(Product product)
        {
            ProductEntity entity = ProductMapper.ToEntity(product);
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            ProductEntity? find = _context.Products.Find(id);
            if (find != null)
            {
                _context.Products.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Product> FindAll()
        {
            return _context.Products.Select(e => ProductMapper.FromEntity(e)).ToList();
        }

        public Product? FindById(int id)
        {
            ProductEntity? find = _context.Products.Find(id);
            return find == null ? null : ProductMapper.FromEntity(find);
        }

        public PagingList<Product> FindPage(int page, int size)
        {
            var data = _context.Products
                .OrderBy(p => p.Name)
                .Skip((page - 1) * size)
                .Take(size)
                .Select(ProductMapper.FromEntity)
                .ToList();

            return PagingList<Product>.Create(data, _context.Products.Count(), page, size);
        }
    }
}
