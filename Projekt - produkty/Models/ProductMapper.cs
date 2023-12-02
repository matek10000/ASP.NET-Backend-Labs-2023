using ProductData.Entities;

namespace Projekt___produkty.Models
{
    public class ProductMapper
    {
        public static ProductEntity ToEntity(Product model)
        {
            return new ProductEntity()
            {
                Name = model.Name,
                Price = model.Price,
                Manufacturer = model.Manufacturer,
                ProductionDate = model.ProductionDate,
                Description = model.Description,
                Id = model.Id
            };
        }

        public static Product FromEntity(ProductEntity entity)
        {
            return new Product()
            {
                Name = entity.Name,
                Price = entity.Price,
                Manufacturer = entity.Manufacturer,
                ProductionDate = entity.ProductionDate,
                Description = entity.Description,
                Id = entity.Id
            };
        }
    }
}
