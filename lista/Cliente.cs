using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_6
{
    class Cliente
    {

        private int saldo;
        private int conta;
        private int cobranca_total;
        private int credito_total;
        private int limite_credito;


        public Cliente()

        {
            saldo = 0;
            conta = 0;
            cobranca_total = 0;
            credito_total = 0;
            limite_credito = 0;

        }



        public Cliente(int saldo, int conta, int cobranca_total, int credito_total, int limite_credito)

        {
            this.saldo = saldo;
            this.conta = conta;
            this.cobranca_total = cobranca_total;
            this.credito_total = credito_total;
            this.limite_credito = limite_credito;

        }

     
        public int NovoSaldo()
        {
            return this.saldo + this.cobranca_total - this.credito_total;
        }

        public void AtualizaSaldo()
        {
            this.saldo = NovoSaldo();
        }

        public bool Limiteestourado()
        {
            return this.saldo > this.limite_credito;
        }





    }
}
