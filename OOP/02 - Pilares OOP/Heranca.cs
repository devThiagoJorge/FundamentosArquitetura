
namespace OOP._02___Pilares_OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo{
        public void Execucao()
        {
            var funcionario = new Funcionario
            {
                Nome = "Funcionário 1",
                DataAdmissao = DateTime.Now,
                DataNascimento = Convert.ToDateTime("2000/03/04"),
                Registro = "321421"
            };

            funcionario.CalcularIdade();
        }
    }
}
