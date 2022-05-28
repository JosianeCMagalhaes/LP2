namespace Imposto
{
    partial class Form1
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
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnSexo2 = new System.Windows.Forms.RadioButton();
            this.rbtnSexo1 = new System.Windows.Forms.RadioButton();
            this.gbxEstaCivil = new System.Windows.Forms.GroupBox();
            this.ckbxEstaCivil = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblAliqIRRF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAliqINSS = new System.Windows.Forms.TextBox();
            this.txtAliqIRRF = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtDescIRRF = new System.Windows.Forms.TextBox();
            this.btnVerificarDesc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.txtFilho = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.gbxEstaCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnSexo2);
            this.gbxSexo.Controls.Add(this.rbtnSexo1);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(549, 67);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(166, 100);
            this.gbxSexo.TabIndex = 0;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnSexo2
            // 
            this.rbtnSexo2.AutoSize = true;
            this.rbtnSexo2.Location = new System.Drawing.Point(29, 62);
            this.rbtnSexo2.Name = "rbtnSexo2";
            this.rbtnSexo2.Size = new System.Drawing.Size(106, 24);
            this.rbtnSexo2.TabIndex = 1;
            this.rbtnSexo2.TabStop = true;
            this.rbtnSexo2.Text = "Masculino";
            this.rbtnSexo2.UseVisualStyleBackColor = true;
            // 
            // rbtnSexo1
            // 
            this.rbtnSexo1.AutoSize = true;
            this.rbtnSexo1.Checked = true;
            this.rbtnSexo1.Location = new System.Drawing.Point(29, 32);
            this.rbtnSexo1.Name = "rbtnSexo1";
            this.rbtnSexo1.Size = new System.Drawing.Size(98, 24);
            this.rbtnSexo1.TabIndex = 0;
            this.rbtnSexo1.TabStop = true;
            this.rbtnSexo1.Text = "Feminino";
            this.rbtnSexo1.UseVisualStyleBackColor = true;
            // 
            // gbxEstaCivil
            // 
            this.gbxEstaCivil.Controls.Add(this.ckbxEstaCivil);
            this.gbxEstaCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstaCivil.Location = new System.Drawing.Point(549, 173);
            this.gbxEstaCivil.Name = "gbxEstaCivil";
            this.gbxEstaCivil.Size = new System.Drawing.Size(166, 84);
            this.gbxEstaCivil.TabIndex = 1;
            this.gbxEstaCivil.TabStop = false;
            this.gbxEstaCivil.Text = "Estado Cívil";
            // 
            // ckbxEstaCivil
            // 
            this.ckbxEstaCivil.AutoSize = true;
            this.ckbxEstaCivil.Location = new System.Drawing.Point(29, 36);
            this.ckbxEstaCivil.Name = "ckbxEstaCivil";
            this.ckbxEstaCivil.Size = new System.Drawing.Size(88, 24);
            this.ckbxEstaCivil.TabIndex = 0;
            this.ckbxEstaCivil.Text = "Casado";
            this.ckbxEstaCivil.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(57, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(57, 104);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(107, 20);
            this.lblSalBruto.TabIndex = 3;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.Location = new System.Drawing.Point(57, 145);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(95, 20);
            this.lblFilhos.TabIndex = 4;
            this.lblFilhos.Text = "Nº de filhos";
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliqINSS.Location = new System.Drawing.Point(65, 458);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(112, 20);
            this.lblAliqINSS.TabIndex = 5;
            this.lblAliqINSS.Text = "Aliquota INSS";
            // 
            // lblAliqIRRF
            // 
            this.lblAliqIRRF.AutoSize = true;
            this.lblAliqIRRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliqIRRF.Location = new System.Drawing.Point(65, 496);
            this.lblAliqIRRF.Name = "lblAliqIRRF";
            this.lblAliqIRRF.Size = new System.Drawing.Size(112, 20);
            this.lblAliqIRRF.TabIndex = 6;
            this.lblAliqIRRF.Text = "Aliquota IRRF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFamilia.Location = new System.Drawing.Point(65, 534);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(120, 20);
            this.lblSalFamilia.TabIndex = 7;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiq.Location = new System.Drawing.Point(414, 456);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(120, 20);
            this.lblSalLiq.TabIndex = 8;
            this.lblSalLiq.Text = "Salário Liquido";
            this.lblSalLiq.Click += new System.EventHandler(this.lblSalLiq_Click);
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(414, 496);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(124, 20);
            this.lblDescINSS.TabIndex = 9;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRPF.Location = new System.Drawing.Point(414, 534);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(124, 20);
            this.lblDescIRPF.TabIndex = 10;
            this.lblDescIRPF.Text = "Desconto IRRF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(205, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 22);
            this.txtNome.TabIndex = 11;
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Location = new System.Drawing.Point(213, 456);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.Size = new System.Drawing.Size(154, 22);
            this.txtAliqINSS.TabIndex = 12;
            // 
            // txtAliqIRRF
            // 
            this.txtAliqIRRF.Location = new System.Drawing.Point(213, 494);
            this.txtAliqIRRF.Name = "txtAliqIRRF";
            this.txtAliqIRRF.Size = new System.Drawing.Size(154, 22);
            this.txtAliqIRRF.TabIndex = 13;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Location = new System.Drawing.Point(213, 532);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(154, 22);
            this.txtSalFamilia.TabIndex = 14;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Location = new System.Drawing.Point(561, 454);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(154, 22);
            this.txtSalLiq.TabIndex = 15;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Location = new System.Drawing.Point(561, 492);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(154, 22);
            this.txtDescINSS.TabIndex = 16;
            // 
            // txtDescIRRF
            // 
            this.txtDescIRRF.Location = new System.Drawing.Point(561, 528);
            this.txtDescIRRF.Name = "txtDescIRRF";
            this.txtDescIRRF.Size = new System.Drawing.Size(154, 22);
            this.txtDescIRRF.TabIndex = 17;
            // 
            // btnVerificarDesc
            // 
            this.btnVerificarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarDesc.Location = new System.Drawing.Point(61, 209);
            this.btnVerificarDesc.Name = "btnVerificarDesc";
            this.btnVerificarDesc.Size = new System.Drawing.Size(298, 48);
            this.btnVerificarDesc.TabIndex = 20;
            this.btnVerificarDesc.Text = "Verificar Desconto";
            this.btnVerificarDesc.UseVisualStyleBackColor = true;
            this.btnVerificarDesc.Click += new System.EventHandler(this.btnVerificarDesc_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(202, 595);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(165, 46);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(373, 595);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 46);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(161, 319);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(477, 90);
            this.txtMsg.TabIndex = 23;
            this.txtMsg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(205, 102);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(117, 22);
            this.txtSalBruto.TabIndex = 24;
            // 
            // txtFilho
            // 
            this.txtFilho.Location = new System.Drawing.Point(205, 143);
            this.txtFilho.Name = "txtFilho";
            this.txtFilho.Size = new System.Drawing.Size(35, 22);
            this.txtFilho.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(767, 677);
            this.Controls.Add(this.txtFilho);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVerificarDesc);
            this.Controls.Add(this.txtDescIRRF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAliqIRRF);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAliqIRRF);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gbxEstaCivil);
            this.Controls.Add(this.gbxSexo);
            this.Name = "Form1";
            this.Text = "Imposto";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstaCivil.ResumeLayout(false);
            this.gbxEstaCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnSexo2;
        private System.Windows.Forms.RadioButton rbtnSexo1;
        private System.Windows.Forms.GroupBox gbxEstaCivil;
        private System.Windows.Forms.CheckBox ckbxEstaCivil;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblAliqIRRF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAliqINSS;
        private System.Windows.Forms.TextBox txtAliqIRRF;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtDescIRRF;
        private System.Windows.Forms.Button btnVerificarDesc;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.TextBox txtFilho;
    }
}

