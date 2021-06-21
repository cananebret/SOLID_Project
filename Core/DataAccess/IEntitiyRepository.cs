using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess

{   //Generic Constraint
    //class : referans tip olabilir 
    //IEntity : IEntity olabilr yada IEntity implemente eden bir nesne olabilir
    //new() : newlenebir olmalı, IEntity newlenemeyeceği için koyarız 
    public interface IEntitiyRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Ürünleri şuna göre listele falan yapmak için
       
        T Get(Expression<Func<T, bool>> filter); //detaya girmek için
      
        //T GetById(int id);
       
        void Add(T entity);
       
        void Update(T entity);
       
        void Delete(T entity);

        
    }
}
