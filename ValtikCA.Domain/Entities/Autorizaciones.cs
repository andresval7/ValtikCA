using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Domain.Entities
{
    public partial class Autorizaciones
    {
        
        public string UserName { get; set; } = null!;
        public string PasswordAuth { get; set; } = null!;
    }
}