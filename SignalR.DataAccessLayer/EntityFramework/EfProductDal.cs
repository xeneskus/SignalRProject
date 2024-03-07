using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }
        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public decimal ProductAvgPriceByHamburger()
        {
            throw new NotImplementedException();
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }

        public int ProductCountByCategoryNameDrink()
        {
            throw new NotImplementedException();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            throw new NotImplementedException();
        }

        public string ProductNameByMaxPrice()
        {
            throw new NotImplementedException();
        }

        public string ProductNameByMinPrice()
        {
            throw new NotImplementedException();
        }

        public decimal ProductPriceAvg()
        {
            throw new NotImplementedException();
        }

        public decimal ProductPriceBySteakBurger()
        {
            throw new NotImplementedException();
        }

        public decimal TotalPriceByDrinkCategory()
        {
            throw new NotImplementedException();
        }

        public decimal TotalPriceBySaladCategory()
        {
            throw new NotImplementedException();
        }
    }
}
