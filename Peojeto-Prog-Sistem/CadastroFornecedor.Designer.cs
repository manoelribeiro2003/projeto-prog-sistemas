namespace Peojeto_Prog_Sistem
{
    partial class CadastroFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelNF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxObs = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxRazaoSocial = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxEnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxcnpj = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxContato = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(126, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 69;
            this.label1.Text = "CNPJ*:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(100, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Contato*:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFornecedor.Location = new System.Drawing.Point(70, 107);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(118, 21);
            this.labelFornecedor.TabIndex = 67;
            this.labelFornecedor.Text = "Razão Social*:";
            this.labelFornecedor.Click += new System.EventHandler(this.labelFornecedor_Click);
            // 
            // labelNF
            // 
            this.labelNF.AutoSize = true;
            this.labelNF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNF.Location = new System.Drawing.Point(93, 170);
            this.labelNF.Name = "labelNF";
            this.labelNF.Size = new System.Drawing.Size(95, 21);
            this.labelNF.TabIndex = 66;
            this.labelNF.Text = "Endereço*:";
            this.labelNF.Click += new System.EventHandler(this.labelNF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(71, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "Observações:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxObs
            // 
            this.tbxObs.BorderRadius = 10;
            this.tbxObs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxObs.DefaultText = "";
            this.tbxObs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxObs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxObs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxObs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxObs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxObs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxObs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxObs.Location = new System.Drawing.Point(210, 296);
            this.tbxObs.Multiline = true;
            this.tbxObs.Name = "tbxObs";
            this.tbxObs.PasswordChar = '\0';
            this.tbxObs.PlaceholderText = "";
            this.tbxObs.SelectedText = "";
            this.tbxObs.Size = new System.Drawing.Size(343, 110);
            this.tbxObs.TabIndex = 98;
            // 
            // tbxRazaoSocial
            // 
            this.tbxRazaoSocial.BorderRadius = 10;
            this.tbxRazaoSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxRazaoSocial.DefaultText = "";
            this.tbxRazaoSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxRazaoSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxRazaoSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRazaoSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRazaoSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxRazaoSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRazaoSocial.Location = new System.Drawing.Point(210, 103);
            this.tbxRazaoSocial.Name = "tbxRazaoSocial";
            this.tbxRazaoSocial.PasswordChar = '\0';
            this.tbxRazaoSocial.PlaceholderText = "";
            this.tbxRazaoSocial.SelectedText = "";
            this.tbxRazaoSocial.Size = new System.Drawing.Size(343, 28);
            this.tbxRazaoSocial.TabIndex = 97;
            // 
            // tbxEnd
            // 
            this.tbxEnd.BorderRadius = 10;
            this.tbxEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEnd.DefaultText = "";
            this.tbxEnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxEnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxEnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxEnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxEnd.Location = new System.Drawing.Point(210, 166);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.PasswordChar = '\0';
            this.tbxEnd.PlaceholderText = "";
            this.tbxEnd.SelectedText = "";
            this.tbxEnd.Size = new System.Drawing.Size(343, 28);
            this.tbxEnd.TabIndex = 96;
            // 
            // tbxcnpj
            // 
            this.tbxcnpj.BorderRadius = 10;
            this.tbxcnpj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxcnpj.DefaultText = "";
            this.tbxcnpj.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxcnpj.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxcnpj.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxcnpj.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxcnpj.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxcnpj.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxcnpj.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxcnpj.Location = new System.Drawing.Point(210, 40);
            this.tbxcnpj.Name = "tbxcnpj";
            this.tbxcnpj.PasswordChar = '\0';
            this.tbxcnpj.PlaceholderText = "";
            this.tbxcnpj.SelectedText = "";
            this.tbxcnpj.Size = new System.Drawing.Size(343, 28);
            this.tbxcnpj.TabIndex = 95;
            // 
            // tbxContato
            // 
            this.tbxContato.BorderRadius = 10;
            this.tbxContato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxContato.DefaultText = "";
            this.tbxContato.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxContato.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxContato.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxContato.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxContato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxContato.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxContato.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxContato.Location = new System.Drawing.Point(210, 229);
            this.tbxContato.Name = "tbxContato";
            this.tbxContato.PasswordChar = '\0';
            this.tbxContato.PlaceholderText = "";
            this.tbxContato.SelectedText = "";
            this.tbxContato.Size = new System.Drawing.Size(343, 28);
            this.tbxContato.TabIndex = 99;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(267, 426);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(161, 41);
            this.btnConfirmar.TabIndex = 102;
            this.btnConfirmar.Text = "Con&firmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 500);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbxContato);
            this.Controls.Add(this.tbxObs);
            this.Controls.Add(this.tbxRazaoSocial);
            this.Controls.Add(this.tbxEnd);
            this.Controls.Add(this.tbxcnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNF);
            this.Name = "CadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelNF;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbxObs;
        private Guna.UI2.WinForms.Guna2TextBox tbxRazaoSocial;
        private Guna.UI2.WinForms.Guna2TextBox tbxEnd;
        private Guna.UI2.WinForms.Guna2TextBox tbxcnpj;
        private Guna.UI2.WinForms.Guna2TextBox tbxContato;
        private System.Windows.Forms.Button btnConfirmar;
    }
}