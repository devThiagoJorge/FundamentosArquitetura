using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.Solução_Extension_Metodos
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string NumeroTransacao { get; set; }

        public string FormatarTransacao()
        {
            NumeroTransacao = NumeroTransacao.Remove(4);
            return NumeroTransacao;
        }
    }
}
