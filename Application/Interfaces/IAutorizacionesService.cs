using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Interfaces
{
    public interface IAutorizacionesService
    {
        AutorizacionResponse GetAutorizacionByUser(string user);

        IEnumerable<AutorizacionResponse> GetAutorizacion();

        void InsertAutorizacionById(CreateAutorizacionRequest request);

        void UpdateAutorizacionById(UpdateAutorizacionRequest request);

        void DeleteAutorizacionByUser(string user);
    }
}
