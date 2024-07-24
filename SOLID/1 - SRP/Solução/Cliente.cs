using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.Solução
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public CPF Cpf { get; set; }
        public Email Email { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
