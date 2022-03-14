using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()//BİR İŞ SINIFI BAŞKA CLASSLARI NEW LEMEZ İNJECTİON KULLANILIR
        {
            //İş KODLARI
            return _productDal.GetAll();
            
        }
    }
}
