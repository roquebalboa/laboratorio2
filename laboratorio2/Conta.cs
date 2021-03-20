using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    class Conta
    {
        
        string correntista;
        int numeroId;
        float saldoatual;

        public Conta(string correntista, int numeroId, float saldoatual)
        {
            this.correntista = correntista;
            this.numeroId = numeroId;
            this.saldoatual = saldoatual;
        }

        public string NomeCorrentista { get => correntista; }
        public int NumeroIdentificacao { get => numeroId; }
        public float SaldoAtual { get => saldoatual; set => saldoatual = value; }



    }
}
