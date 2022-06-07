using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Infrastructure.Filters
{
    public class GlobalExceptionFilter: IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            //Este se ejecuta cuando ocurre una excepcion no controlada
            var validation = new
            {
                Status = 500,
                Title = "System had a failure",
                Detail = context.Exception.Message
            };

            context.Result = new ObjectResult(validation);
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        }
    }
}

