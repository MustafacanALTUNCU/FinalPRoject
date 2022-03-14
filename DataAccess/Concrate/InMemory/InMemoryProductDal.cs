using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//global değişken tanımladığımız için _ ile yazılır
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {//Sanki bir veri tabanından geliyormuş gibi simüle ettik sistemi
                new Product{ProductId = 1, CategoryId = 1,  ProductName ="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId = 2, CategoryId = 1,  ProductName ="Kamera", UnitPrice=500 ,UnitsInStock=3},
                new Product{ProductId = 3, CategoryId = 2,  ProductName ="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId = 4, CategoryId = 2,  ProductName ="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId = 5, CategoryId = 2,  ProductName ="Fare", UnitPrice=85, UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {//LINQ Language integrated query;Aşağıdaki kodu linq ile yazabiliyoruz
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);//bu kod yukarıdaki foreach i yapar
            //_products.SingleOrDefault:ForEACH YAPAR.    (p=>p.ProductId==product.ProductId):kURALINI DA BURAYA YAZIYORSUN
            _products.Remove(productToDelete);
           // foreach (var p in _products)
           // {
               // if(product.ProductId == p.ProductId)
              //  {
                   // productToDelete = p;
                //}

           // }
            
            
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
        }
      
    }
}
