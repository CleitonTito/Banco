using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class contaInvestimento : Conta, Itributavel
    {
        public override void Deposita(double valor)
        {

            base.Saldo += valor;
        }

        public override void Saca(double valor)
        {

            base.Saldo -= valor;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }

    }
}
