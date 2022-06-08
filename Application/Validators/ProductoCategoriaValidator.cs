using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;

namespace ValtikCA.Application.Validators
{
    public class ProductoCategoriaValidator : AbstractValidator<CreateProductoCategoriaRequest>
    {
        public ProductoCategoriaValidator()
        {
            RuleFor(x => x.IdProducto)
                .NotEmpty()
                    .WithMessage("El ID es requerido")
                .MinimumLength(5)
                    .WithMessage("El Id no es valido");
            RuleFor(x => x.IdProdCategoria).NotEqual(0)
                    .WithMessage("El ID es requerido");
            RuleFor(x => x.IdCategoria)
                .NotEmpty()
                    .WithMessage("La categoria es requerida");

        }

    }

    public class UpdateProductoCategoriumValidator : AbstractValidator<UpdateProductoCategoria>
    {
        public UpdateProductoCategoriumValidator()
        {
            RuleFor(x => x.IdProducto)
                .NotEmpty()
                    .WithMessage("El ID es requerido")
                .MinimumLength(5)
                    .WithMessage("El Id no es valido");
            RuleFor(x => x.IdProdCategoria).NotEqual(0)
                    .WithMessage("El ID es requerido");
            RuleFor(x => x.IdCategoria)
                .NotEmpty()
                    .WithMessage("La categoria es requerida");

        }

    }
}
