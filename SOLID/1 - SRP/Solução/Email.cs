﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.Solução
{
    public class Email
    {
        public string Endereco { get; set; }
        
        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}
