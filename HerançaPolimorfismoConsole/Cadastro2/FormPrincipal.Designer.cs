namespace Cadastro2
{
    partial class FormPrincipal
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
            this.btnCadastrarPF = new System.Windows.Forms.Button();
            this.btnCadastrarPJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarPF
            // 
            this.btnCadastrarPF.Location = new System.Drawing.Point(58, 49);
            this.btnCadastrarPF.Name = "btnCadastrarPF";
            this.btnCadastrarPF.Size = new System.Drawing.Size(166, 52);
            this.btnCadastrarPF.TabIndex = 0;
            this.btnCadastrarPF.Text = "Cadastro de Pessoa Física";
            this.btnCadastrarPF.UseVisualStyleBackColor = true;
            this.btnCadastrarPF.Click += new System.EventHandler(this.btnCadastrarPF_Click);
            // 
            // btnCadastrarPJ
            // 
            this.btnCadastrarPJ.Location = new System.Drawing.Point(58, 120);
            this.btnCadastrarPJ.Name = "btnCadastrarPJ";
            this.btnCadastrarPJ.Size = new System.Drawing.Size(166, 54);
            this.btnCadastrarPJ.TabIndex = 1;
            this.btnCadastrarPJ.Text = "Cadastro de Pessoa Jurídica";
            this.btnCadastrarPJ.UseVisualStyleBackColor = true;
            this.btnCadastrarPJ.Click += new System.EventHandler(this.btnCadastrarPJ_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCadastrarPJ);
            this.Controls.Add(this.btnCadastrarPF);
            this.Name = "FormPrincipal";
            this.Text = "Cadastro de Pessoas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarPF;
        private System.Windows.Forms.Button btnCadastrarPJ;

    }
}

