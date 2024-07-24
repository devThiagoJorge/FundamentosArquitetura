using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.Solução
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta);

        public string FormatarTransacao()
        {
            NumeroTransacao = NumeroTransacao.Remove(4);
            return NumeroTransacao;
        }
    }
}
