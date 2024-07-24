using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.VIolação
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public void AdicionarCliente()
        {
            // Faz validação dos atributos, se tem @ no EMAIL, se é um CPF VÁLIDO

            // Faz Conexão com o banco de dados

            // Faz o disparo de e-mail
        }
    }
}
