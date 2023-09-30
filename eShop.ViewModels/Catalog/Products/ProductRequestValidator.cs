using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace eShop.ViewModels.Catalog.Products
{
    public class ProductRequestValidator : AbstractValidator<ProductCreateRequest>
    {
        public ProductRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name can not over 200 characters");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Price is required")
                .GreaterThan(0).WithMessage("Number of Price must be greater than 0");

            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage("OriginalPrice is required")
                .GreaterThan(0).WithMessage("Number of OriginalPrice must be greater than 0"); ;

            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stock is required");

            RuleFor(x => x.ThumbnailImage).NotEmpty().WithMessage("Thumbnail Image is required");
        }
    }
}