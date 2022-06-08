using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;

namespace ValtikCA.Application.Validators
{
    public class CategoriaValidator : AbstractValidator<CreateCategoriaRequest>
    {
        public CategoriaValidator()
        {
            RuleFor(x => x.IdCategoria)
                .NotEmpty()
                    .WithMessage("El ID es requerido");
            RuleFor(x => x.Nombre).NotEmpty()
                    .WithMessage("El nombre es requerido");

        }
    }

    public class UpdateCategoriaValidator : AbstractValidator<UpdateCategoriaRequest>
    {
        public UpdateCategoriaValidator()
        {
            RuleFor(x => x.IdCategoria)
                .NotEmpty()
                    .WithMessage("El ID es requerido");
            RuleFor(x => x.Nombre).NotEmpty()
                    .WithMessage("El nombre es requerido");

        }
    }
}
