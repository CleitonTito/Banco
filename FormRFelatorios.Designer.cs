namespace Banco
{
    partial class FormRFelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.botaoAntigas = new System.Windows.Forms.Button();
            this.Resumo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.Resumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 2);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(393, 212);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(12, 375);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(191, 40);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo maior que 5000";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // botaoAntigas
            // 
            this.botaoAntigas.Location = new System.Drawing.Point(253, 375);
            this.botaoAntigas.Name = "botaoAntigas";
            this.botaoAntigas.Size = new System.Drawing.Size(124, 40);
            this.botaoAntigas.TabIndex = 2;
            this.botaoAntigas.Text = "Antigas";
            this.botaoAntigas.UseVisualStyleBackColor = true;
            this.botaoAntigas.Click += new System.EventHandler(this.botaoAntigas_Click);
            // 
            // Resumo
            // 
            this.Resumo.Controls.Add(this.labelMaiorSaldo);
            this.Resumo.Controls.Add(this.label3);
            this.Resumo.Controls.Add(this.labelSaldoTotal);
            this.Resumo.Controls.Add(this.label1);
            this.Resumo.Location = new System.Drawing.Point(12, 220);
            this.Resumo.Name = "Resumo";
            this.Resumo.Size = new System.Drawing.Size(393, 134);
            this.Resumo.TabIndex = 3;
            this.Resumo.TabStop = false;
            this.Resumo.Text = "Resumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Total";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(238, 36);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(80, 13);
            this.labelSaldoTotal.TabIndex = 1;
            this.labelSaldoTotal.Text = "labelSaldoTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maior Saldo";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(239, 84);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(82, 13);
            this.labelMaiorSaldo.TabIndex = 3;
            this.labelMaiorSaldo.Text = "labelMaiorSaldo";
            // 
            // FormRFelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 445);
            this.Controls.Add(this.Resumo);
            this.Controls.Add(this.botaoAntigas);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRFelatorios";
            this.Text = "FormRFelatorios";
            this.Resumo.ResumeLayout(false);
            this.Resumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.Button botaoAntigas;
        private System.Windows.Forms.GroupBox Resumo;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label label1;
    }
}