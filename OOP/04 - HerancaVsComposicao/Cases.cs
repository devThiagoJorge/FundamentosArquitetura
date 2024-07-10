using OOP._02___Pilares_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._04___HerancaVsComposicao
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Cpf = "3124141412",
                DataNascimento = DateTime.Now,
                Nome = "Herança!"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Composição!",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "392183198"
            };
        }
    }
}
