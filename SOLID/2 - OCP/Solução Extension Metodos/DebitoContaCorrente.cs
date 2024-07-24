using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.Solução_Extension_Metodos
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            return debitoConta.FormatarTransacao();
        }
    }
}
