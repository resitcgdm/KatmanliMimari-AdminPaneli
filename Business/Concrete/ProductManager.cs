using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal product)
        {
            _productDal = product;
        }
        //[ProductValidator]
        public void Ekle(Product product)
        {
            _productDal.Add(product);
        }

        public void Guncelle(Product product)
        {
            _productDal.Update(product);
        }

        public List<Product> ListGetir()
        {
          return  _productDal.GetAll(); // x=>x.Price>100 kural koyabiliriz.
        }

        public Product ProductGetirWithId(int id)
        {
            return _productDal.GetById(x => x.Id == id);
        }

        public void Sil(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
