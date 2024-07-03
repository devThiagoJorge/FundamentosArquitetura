using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classe_X_Objeto
{
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa
            {
                Andares = 1,
                Valor = 1000,
                NumeroVagas = 2,
                TamanhoM2 = 15
            };
        }
    }
}


