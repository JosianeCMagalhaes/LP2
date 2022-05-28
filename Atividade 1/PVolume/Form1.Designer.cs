namespace PVolume
{
    partial class frPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.brCalcular = new System.Windows.Forms.Button();
            this.tbRaio = new System.Windows.Forms.TextBox();
            this.lbEntrada = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.rbDiametro = new System.Windows.Forms.RadioButton();
            this.rbRaio = new System.Windows.Forms.RadioButton();
            this.lbSaida = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(303, 139);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(173, 38);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(303, 93);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(173, 38);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // brCalcular
            // 
            this.brCalcular.Location = new System.Drawing.Point(303, 47);
            this.brCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brCalcular.Name = "brCalcular";
            this.brCalcular.Size = new System.Drawing.Size(173, 38);
            this.brCalcular.TabIndex = 2;
            this.brCalcular.Text = "Calcular";
            this.brCalcular.UseVisualStyleBackColor = true;
            this.brCalcular.Click += new System.EventHandler(this.brCalcular_Click);
            // 
            // tbRaio
            // 
            this.tbRaio.Location = new System.Drawing.Point(103, 63);
            this.tbRaio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRaio.Name = "tbRaio";
            this.tbRaio.Size = new System.Drawing.Size(155, 22);
            this.tbRaio.TabIndex = 3;
            this.tbRaio.TextChanged += new System.EventHandler(this.tbRaio_TextChanged);
            this.tbRaio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRaio_KeyDown);
            // 
            // lbEntrada
            // 
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Location = new System.Drawing.Point(19, 68);
            this.lbEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(41, 17);
            this.lbEntrada.TabIndex = 4;
            this.lbEntrada.Text = "Raio:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(19, 163);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(76, 17);
            this.lbResultado.TabIndex = 7;
            this.lbResultado.Text = "Resultado:";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Enabled = false;
            this.tbResultado.Location = new System.Drawing.Point(103, 158);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(155, 22);
            this.tbResultado.TabIndex = 8;
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbDiametro);
            this.gbEntrada.Controls.Add(this.rbRaio);
            this.gbEntrada.Location = new System.Drawing.Point(14, 13);
            this.gbEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEntrada.Size = new System.Drawing.Size(281, 42);
            this.gbEntrada.TabIndex = 9;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Dado de Entrada:";
            // 
            // rbDiametro
            // 
            this.rbDiametro.AutoSize = true;
            this.rbDiametro.Location = new System.Drawing.Point(109, 15);
            this.rbDiametro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDiametro.Name = "rbDiametro";
            this.rbDiametro.Size = new System.Drawing.Size(86, 21);
            this.rbDiametro.TabIndex = 1;
            this.rbDiametro.Text = "Diametro";
            this.rbDiametro.UseVisualStyleBackColor = true;
            this.rbDiametro.CheckedChanged += new System.EventHandler(this.rbDiametro_CheckedChanged);
            // 
            // rbRaio
            // 
            this.rbRaio.AutoSize = true;
            this.rbRaio.Checked = true;
            this.rbRaio.Location = new System.Drawing.Point(8, 16);
            this.rbRaio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbRaio.Name = "rbRaio";
            this.rbRaio.Size = new System.Drawing.Size(58, 21);
            this.rbRaio.TabIndex = 0;
            this.rbRaio.TabStop = true;
            this.rbRaio.Text = "Raio";
            this.rbRaio.UseVisualStyleBackColor = true;
            this.rbRaio.CheckedChanged += new System.EventHandler(this.rbRaio_CheckedChanged);
            this.rbRaio.Click += new System.EventHandler(this.rbRaio_Click);
            // 
            // lbSaida
            // 
            this.lbSaida.AutoSize = true;
            this.lbSaida.Location = new System.Drawing.Point(19, 117);
            this.lbSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(41, 17);
            this.lbSaida.TabIndex = 10;
            this.lbSaida.Text = "Raio:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(103, 109);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 11;
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 202);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbSaida);
            this.Controls.Add(this.gbEntrada);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbEntrada);
            this.Controls.Add(this.tbRaio);
            this.Controls.Add(this.brCalcular);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSair);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frPrincipal";
            this.Text = "Calculadora de Volume";
            this.Load += new System.EventHandler(this.frPrincipal_Load);
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button brCalcular;
        private System.Windows.Forms.TextBox tbRaio;
        private System.Windows.Forms.Label lbEntrada;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.RadioButton rbRaio;
        private System.Windows.Forms.RadioButton rbDiametro;
        private System.Windows.Forms.Label lbSaida;
        private System.Windows.Forms.TextBox textBox1;
    }
}

