using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public class ContaCorrente: Conta, Itributavel

    {
        public override void Deposita(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo += valor;
            }
        }

        public override void Saca(double valor)
        {
            if (valor <= 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.50 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.50;
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }

    }
}
    
