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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, Conta> dicionario;

        public List<Conta> contas;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dicionario = new Dictionary<string, Conta>();
            this.contas = new List<Conta>();

            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("Victor");
            this.AdicionaConta(c1);
            
            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Mauricio");
            this.AdicionaConta(c2);
            
            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("Osnir");
            this.AdicionaConta(c3);
            
        }

        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            comboContas.Items.Add(conta);

            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;

            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            
            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Depósito Realizado");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possivel depositar valor informado");
            }            
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;
            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);

            try
            {
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro liberado");
            }

            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possivel sacar um valor informado");
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImposto_Click(object sender, EventArgs e)
        {
            ContaCorrente c10 = new ContaCorrente();
            c10.Deposita(200);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Acumula(c10);
            MessageBox.Show("Total: " + totalizador.Total);
            totalizador.Acumula(sv);
            MessageBox.Show("Total: " + totalizador.Total);  
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscaTitular.Text;
            Conta conta = dicionario[nomeTitular];
            

            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            comboContas.SelectedItem = conta;
        }

        private void botaoRelatórios_Click(object sender, EventArgs e)
        {
            FormRFelatorios form = new FormRFelatorios(this.contas);
            form.ShowDialog();
        }
    }
}
