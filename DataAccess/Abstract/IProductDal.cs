using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal//"I" İNTERFACE olduğunu Product hangi tabloya dahil olduğunu DAL(Data Access Layer)Hangi katmana dahil olduğunu gösterir.
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAllByCategoryId(int categoryId);
    }
}
