using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.Solução
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos.";

            var repo = new ClienteRepository();

            repo.AdicionarCliente(cliente);

            EmailService.Enviar("aa@a.com", cliente.Email.Endereco, "Bem vindo!");

            return "Cliente cadastrado com sucesso.";
        }
    }
}
