using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.Solução_Extension_Metodos
{
    public static class DebitarContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            return debitoConta.FormatarTransacao();
        }
    }
}
