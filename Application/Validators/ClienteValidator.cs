using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;

namespace ValtikCA.Application.Validators
{
    public class ClienteValidator : AbstractValidator<CreateClienteRequest>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.IdCliente).NotEmpty()
                    .WithMessage("El ID es requerido")
                    .LessThan(1000001)
                    .WithMessage("El ID no es valido");
            RuleFor(x => x.Nombre1).NotEmpty()
                    .WithMessage("El Nombre 1 es requerido");
            RuleFor(x => x.Apellido1)
                .NotEmpty()
                    .WithMessage("El Apellido 1 es requerido");
            RuleFor(x => x.Email)
                .NotEmpty()
                    .WithMessage("El email es requerida");
            RuleFor(x => x.Password1)
                .NotEmpty()
                    .WithMessage("El password es requerido");
            RuleFor(x => x.Telefono)
                .NotEmpty()
                    .WithMessage("El telefono es requerido");
            RuleFor(x => x.Direccion)
                .NotEmpty()
                    .WithMessage("La direccion es requerida");
            RuleFor(x => x.Ciudad)
                .NotEmpty()
                    .WithMessage("La ciudad es requerida");
            RuleFor(x => x.Provincia)
                .NotEmpty()
                    .WithMessage("El Departamento es requerido");
            RuleFor(x => x.CodigoPostal)
                .NotEmpty()
                    .WithMessage("El Codigo Postal es requerido");

        }
    }
}
