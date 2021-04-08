using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Contas
{
    public abstract class Conta
    {                
        public override bool Equals(object outro)
        {
            if (!(outro is Conta))
            {
                return false;
            }

            Conta outraConta = (Conta)outro;
            return this.Numero == outraConta.Numero;
        }
        public override string ToString()
        {
            return "titular: " + this.Titular.Nome;
        }

        public int Numero { get; internal set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; internal set; }
        public abstract void Deposita (double valor);   
        public abstract void Saca(double valor);
    }
    public class ContaPoupanca : Conta, Itributavel

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
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }
        

        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

    }
          public class SaldoInsuficienteException : Exception
        {

        }
}