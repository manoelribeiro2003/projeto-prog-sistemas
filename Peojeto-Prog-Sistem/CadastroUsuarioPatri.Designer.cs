﻿namespace Peojeto_Prog_Sistem
{
    partial class CadastroUsuarioPatri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuarioPatri));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxCargo = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelNF = new System.Windows.Forms.Label();
            this.tbxNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSetor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxSubdivisao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxEGerente = new System.Windows.Forms.CheckBox();
            this.tbxEGerente = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxResponsável = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(266, 364);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 34);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbxCargo
            // 
            this.tbxCargo.BorderColor = System.Drawing.Color.Black;
            this.tbxCargo.BorderRadius = 10;
            this.tbxCargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCargo.DefaultText = "";
            this.tbxCargo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxCargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxCargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCargo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCargo.ForeColor = System.Drawing.Color.Black;
            this.tbxCargo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCargo.Location = new System.Drawing.Point(219, 176);
            this.tbxCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCargo.Name = "tbxCargo";
            this.tbxCargo.PasswordChar = '\0';
            this.tbxCargo.PlaceholderText = "";
            this.tbxCargo.SelectedText = "";
            this.tbxCargo.Size = new System.Drawing.Size(343, 28);
            this.tbxCargo.TabIndex = 3;
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCadastro.Location = new System.Drawing.Point(119, 34);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(61, 20);
            this.labelCadastro.TabIndex = 125;
            this.labelCadastro.Text = "Nome*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(69, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 124;
            this.label2.Text = "Responsável*:";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFornecedor.Location = new System.Drawing.Point(118, 236);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(62, 20);
            this.labelFornecedor.TabIndex = 123;
            this.labelFornecedor.Text = "Setor*: ";
            // 
            // labelNF
            // 
            this.labelNF.AutoSize = true;
            this.labelNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNF.Location = new System.Drawing.Point(114, 180);
            this.labelNF.Name = "labelNF";
            this.labelNF.Size = new System.Drawing.Size(66, 20);
            this.labelNF.TabIndex = 122;
            this.labelNF.Text = "Cargo*: ";
            // 
            // tbxNome
            // 
            this.tbxNome.BorderColor = System.Drawing.Color.Black;
            this.tbxNome.BorderRadius = 10;
            this.tbxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNome.DefaultText = "";
            this.tbxNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.ForeColor = System.Drawing.Color.Black;
            this.tbxNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNome.Location = new System.Drawing.Point(219, 30);
            this.tbxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.PasswordChar = '\0';
            this.tbxNome.PlaceholderText = "";
            this.tbxNome.SelectedText = "";
            this.tbxNome.Size = new System.Drawing.Size(343, 28);
            this.tbxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(80, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 132;
            this.label1.Text = "Subdivisão*: ";
            // 
            // cbxSetor
            // 
            this.cbxSetor.BackColor = System.Drawing.Color.Transparent;
            this.cbxSetor.BorderRadius = 10;
            this.cbxSetor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSetor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSetor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSetor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSetor.ForeColor = System.Drawing.Color.Black;
            this.cbxSetor.ItemHeight = 30;
            this.cbxSetor.Location = new System.Drawing.Point(219, 228);
            this.cbxSetor.Name = "cbxSetor";
            this.cbxSetor.Size = new System.Drawing.Size(343, 36);
            this.cbxSetor.TabIndex = 4;
            this.cbxSetor.SelectionChangeCommitted += new System.EventHandler(this.cbxSetor_SelectionChangeCommitted);
            // 
            // cbxSubdivisao
            // 
            this.cbxSubdivisao.BackColor = System.Drawing.Color.Transparent;
            this.cbxSubdivisao.BorderRadius = 10;
            this.cbxSubdivisao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSubdivisao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubdivisao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSubdivisao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSubdivisao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubdivisao.ForeColor = System.Drawing.Color.Black;
            this.cbxSubdivisao.ItemHeight = 30;
            this.cbxSubdivisao.Location = new System.Drawing.Point(219, 288);
            this.cbxSubdivisao.Name = "cbxSubdivisao";
            this.cbxSubdivisao.Size = new System.Drawing.Size(343, 36);
            this.cbxSubdivisao.TabIndex = 5;
            // 
            // cbxEGerente
            // 
            this.cbxEGerente.AutoSize = true;
            this.cbxEGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEGerente.Location = new System.Drawing.Point(84, 82);
            this.cbxEGerente.Name = "cbxEGerente";
            this.cbxEGerente.Size = new System.Drawing.Size(96, 24);
            this.cbxEGerente.TabIndex = 134;
            this.cbxEGerente.Text = "Gerente?";
            this.cbxEGerente.UseVisualStyleBackColor = true;
            this.cbxEGerente.CheckedChanged += new System.EventHandler(this.cbxEGerente_CheckedChanged);
            // 
            // tbxEGerente
            // 
            this.tbxEGerente.BorderColor = System.Drawing.Color.Black;
            this.tbxEGerente.BorderRadius = 10;
            this.tbxEGerente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEGerente.DefaultText = "";
            this.tbxEGerente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxEGerente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxEGerente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxEGerente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxEGerente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxEGerente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEGerente.ForeColor = System.Drawing.Color.Black;
            this.tbxEGerente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxEGerente.Location = new System.Drawing.Point(219, 80);
            this.tbxEGerente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEGerente.Name = "tbxEGerente";
            this.tbxEGerente.PasswordChar = '\0';
            this.tbxEGerente.PlaceholderText = "";
            this.tbxEGerente.SelectedText = "";
            this.tbxEGerente.Size = new System.Drawing.Size(343, 28);
            this.tbxEGerente.TabIndex = 135;
            // 
            // cbxResponsável
            // 
            this.cbxResponsável.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxResponsável.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxResponsável.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxResponsável.FormattingEnabled = true;
            this.cbxResponsável.Location = new System.Drawing.Point(219, 126);
            this.cbxResponsável.Name = "cbxResponsável";
            this.cbxResponsável.Size = new System.Drawing.Size(343, 29);
            this.cbxResponsável.TabIndex = 136;
            // 
            // CadastroUsuarioPatri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 520);
            this.Controls.Add(this.cbxResponsável);
            this.Controls.Add(this.tbxEGerente);
            this.Controls.Add(this.cbxEGerente);
            this.Controls.Add(this.cbxSubdivisao);
            this.Controls.Add(this.cbxSetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbxCargo);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroUsuarioPatri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário de Patrimônio";
            this.Load += new System.EventHandler(this.CadastroUsuarioPatri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private Guna.UI2.WinForms.Guna2TextBox tbxCargo;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelNF;
        private Guna.UI2.WinForms.Guna2TextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSetor;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSubdivisao;
        private System.Windows.Forms.CheckBox cbxEGerente;
        private Guna.UI2.WinForms.Guna2TextBox tbxEGerente;
        private System.Windows.Forms.ComboBox cbxResponsável;
    }
}