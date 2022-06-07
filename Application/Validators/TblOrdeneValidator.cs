using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;

namespace ValtikCA.Application.Validators
{
    public class TblOrdeneValidator : AbstractValidator<CreateTblOrdeneRequest>
    {
        public TblOrdeneValidator()
        {
            RuleFor(x => x.IdOrden)
                .NotEmpty()
                    .WithMessage("El ID es requerido");
            RuleFor(x => x.IdCliente).NotEqual(0)
                    .WithMessage("El Id del cliente es requerido");

        }

    }
}
