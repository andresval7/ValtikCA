﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Requests
{
    public class CreateAutorizacionRequest
    {
        public string UserName { get; set; } = null!;
        public string PasswordAuth { get; set; } = null!;
    }
}
