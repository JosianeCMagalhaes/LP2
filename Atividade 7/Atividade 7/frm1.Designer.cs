namespace Atividade7
{
    partial class frm1
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
            this.btnQtdPares = new System.Windows.Forms.Button();
            this.btnQtdR = new System.Windows.Forms.Button();
            this.btEspaco = new System.Windows.Forms.Button();
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnQtdPares
            // 
            this.btnQtdPares.Location = new System.Drawing.Point(494, 276);
            this.btnQtdPares.Name = "btnQtdPares";
            this.btnQtdPares.Size = new System.Drawing.Size(112, 85);
            this.btnQtdPares.TabIndex = 7;
            this.btnQtdPares.Text = "Quantidade pares de letras";
            this.btnQtdPares.UseVisualStyleBackColor = true;
            this.btnQtdPares.Click += new System.EventHandler(this.btnQtdPares_Click);
            // 
            // btnQtdR
            // 
            this.btnQtdR.Location = new System.Drawing.Point(312, 276);
            this.btnQtdR.Name = "btnQtdR";
            this.btnQtdR.Size = new System.Drawing.Size(112, 85);
            this.btnQtdR.TabIndex = 6;
            this.btnQtdR.Text = "Quantidade letra R";
            this.btnQtdR.UseVisualStyleBackColor = true;
            this.btnQtdR.Click += new System.EventHandler(this.btnQtdR_Click);
            // 
            // btEspaco
            // 
            this.btEspaco.Location = new System.Drawing.Point(126, 276);
            this.btEspaco.Name = "btEspaco";
            this.btEspaco.Size = new System.Drawing.Size(112, 85);
            this.btEspaco.TabIndex = 5;
            this.btEspaco.Text = "Espaços em branco";
            this.btEspaco.UseVisualStyleBackColor = true;
            this.btEspaco.Click += new System.EventHandler(this.btEspaco_Click);
            // 
            // rchTxt
            // 
            this.rchTxt.Location = new System.Drawing.Point(126, 49);
            this.rchTxt.MaxLength = 100;
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(480, 185);
            this.rchTxt.TabIndex = 4;
            this.rchTxt.Text = "";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQtdPares);
            this.Controls.Add(this.btnQtdR);
            this.Controls.Add(this.btEspaco);
            this.Controls.Add(this.rchTxt);
            this.Name = "frm1";
            this.Text = "frm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQtdPares;
        private System.Windows.Forms.Button btnQtdR;
        private System.Windows.Forms.Button btEspaco;
        private System.Windows.Forms.RichTextBox rchTxt;
    }
}