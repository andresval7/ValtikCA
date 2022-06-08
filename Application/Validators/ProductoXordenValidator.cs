using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;

namespace ValtikCA.Application.Validators
{
    public class ProductoXordenValidator : AbstractValidator<CreateProductoXordenRequest>
    {
        public ProductoXordenValidator()
        {
            RuleFor(x => x.IdProdOrden)
                .NotEmpty()
                    .WithMessage("El ID de la orden requerida");
            RuleFor(x => x.IdOrden).NotEqual(0)
                    .WithMessage("El ID de la orden es requerida");
            RuleFor(x => x.IdProducto)
                .NotEmpty()
                    .WithMessage("El ID del producto es requerido");

        }

    }
    public class UpdateProductoXordenValidator : AbstractValidator<UpdateProductoXordenRequest>
    {
        public UpdateProductoXordenValidator()
        {
            RuleFor(x => x.IdProdOrden)
                .NotEmpty()
                    .WithMessage("El ID de la orden requerida");
            RuleFor(x => x.IdOrden).NotEqual(0)
                    .WithMessage("El ID de la orden es requerida");
            RuleFor(x => x.IdProducto)
                .NotEmpty()
                    .WithMessage("El ID del producto es requerido");

        }

    }
}
