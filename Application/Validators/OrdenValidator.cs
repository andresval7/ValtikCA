using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;

namespace ValtikCA.Application.Validators
{
    public class OrdenValidator : AbstractValidator<CreateOrdenRequest>
    {
        public OrdenValidator()
        {
            RuleFor(x => x.IdCliente).NotEqual(0)
                    .WithMessage("El Id del cliente es requerido");

        }

    }

    public class UpdateTblOrdeneValidator : AbstractValidator<UpdateOrdenRequest>
    {
        public UpdateTblOrdeneValidator()
        {
            RuleFor(x => x.IdOrden)
                .NotEmpty()
                    .WithMessage("El ID es requerido");
            RuleFor(x => x.IdCliente).NotEqual(0)
                    .WithMessage("El Id del cliente es requerido");

        }

    }
}
