using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;

namespace ValtikCA.Application.Validators
{
    public class ProductoValidator: AbstractValidator<CreateProductoRequest>
    {
        public ProductoValidator()
        {
            RuleFor(x => x.IdProducto)
                .NotEmpty()
                    .WithMessage("El ID es requerido")
                .MinimumLength(5)
                    .WithMessage("El Id no es valido");
            RuleFor(x => x.Precio).NotEqual(0)
                    .WithMessage("El precio es requerido");
            RuleFor(x => x.Sku)
                .NotEmpty()
                    .WithMessage("El SKU es requerido");
            RuleFor(x => x.Categoria)
                .NotEmpty()
                    .WithMessage("La categoria es requerida");
            RuleFor(x => x.Stock)
                .NotEmpty()
                    .WithMessage("El Stock es requerido");

        }
        
    }
}
