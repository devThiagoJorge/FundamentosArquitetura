using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.Solução
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // regras de negócio
            return FormatarTransacao();
        }
    }
}
