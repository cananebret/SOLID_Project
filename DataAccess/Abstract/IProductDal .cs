using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{

   public interface IProductDal:IEntitiyRepository<Product>
    {
        //sadece producta özel kod yazıyorum o yüzden bu katmana yazdım

        List<ProductDetailDto> GetProductDetails();
    }
}
