using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.Violação
{
    public class DebitoConta
    {
        public void Debitar(decimal Valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Poupanca)
            {
                // regras de negócio da conta poupança
            }

            if(tipoConta == TipoConta.Corrente)
            {
                // regras de negócio da conta corrente
            }
        }
    }
}
