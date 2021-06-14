﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{ 
    //categoriyle ilgili dış dünyaya neyi servis etmek istiyorsam o operasyonları yazıyorum
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int CategoryId);
    }
}
