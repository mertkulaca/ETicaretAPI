using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator() { 
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Lütfen kullanıcı adını boş geçmeyiniz!").MaximumLength(100).MinimumLength(5).WithMessage("Ürün adını maksimum 100, minimum 5 karakter arasında giriniz!");
            RuleFor(x => x.Stock).NotEmpty().NotNull().WithMessage("Lütfen stok bilgisini boş geçmeyiniz!").Must(x => x >=0).WithMessage("Stok bilgisini negatif sayı olarak girmeyiniz!");
            RuleFor(x => x.Price).NotEmpty().NotNull().WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz!").Must(x => x >= 0).WithMessage("Fiyat bilgisni negatif sayı olarak girmeyiniz1");

        }
    }
}
