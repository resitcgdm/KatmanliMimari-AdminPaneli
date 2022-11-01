using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(3);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Quantity).NotEmpty();
            RuleFor(p => p.CreateDate).NotEmpty();
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(10);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün ismi B ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("B");
        }
    }
}
