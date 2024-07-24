using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.Solução
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return FormatarTransacao();
        }
    }
}
