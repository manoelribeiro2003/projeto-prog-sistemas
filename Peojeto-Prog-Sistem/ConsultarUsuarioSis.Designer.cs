namespace Peojeto_Prog_Sistem
{
    partial class ConsultarUsuarioSis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuarioSis));
            this.dgvUsuariosPatri = new System.Windows.Forms.DataGridView();
            this.btnExcluirManut = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbxNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxRepitaSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxNomeDeUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelNF = new System.Windows.Forms.Label();
            this.cbxEAdm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPatri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosPatri
            // 
            this.dgvUsuariosPatri.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosPatri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuariosPatri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosPatri.EnableHeadersVisualStyles = false;
            this.dgvUsuariosPatri.Location = new System.Drawing.Point(564, 67);
            this.dgvUsuariosPatri.MultiSelect = false;
            this.dgvUsuariosPatri.Name = "dgvUsuariosPatri";
            this.dgvUsuariosPatri.ReadOnly = true;
            this.dgvUsuariosPatri.RowHeadersVisible = false;
            this.dgvUsuariosPatri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosPatri.Size = new System.Drawing.Size(445, 316);
            this.dgvUsuariosPatri.TabIndex = 145;
            this.dgvUsuariosPatri.DoubleClick += new System.EventHandler(this.dgvUsuariosPatri_DoubleClick);
            // 
            // btnExcluirManut
            // 
            this.btnExcluirManut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirManut.Location = new System.Drawing.Point(574, 456);
            this.btnExcluirManut.Name = "btnExcluirManut";
            this.btnExcluirManut.Size = new System.Drawing.Size(167, 38);
            this.btnExcluirManut.TabIndex = 157;
            this.btnExcluirManut.Text = "E&xcluir";
            this.btnExcluirManut.UseVisualStyleBackColor = true;
            this.btnExcluirManut.Click += new System.EventHandler(this.btnExcluirManut_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(294, 456);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 38);
            this.btnEditar.TabIndex = 156;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.tbxNome.Location = new System.Drawing.Point(198, 119);
            this.tbxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.PasswordChar = '\0';
            this.tbxNome.PlaceholderText = "";
            this.tbxNome.SelectedText = "";
            this.tbxNome.Size = new System.Drawing.Size(343, 28);
            this.tbxNome.TabIndex = 159;
            // 
            // tbxRepitaSenha
            // 
            this.tbxRepitaSenha.BorderColor = System.Drawing.Color.Black;
            this.tbxRepitaSenha.BorderRadius = 10;
            this.tbxRepitaSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxRepitaSenha.DefaultText = "";
            this.tbxRepitaSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxRepitaSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxRepitaSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRepitaSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRepitaSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRepitaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRepitaSenha.ForeColor = System.Drawing.Color.Black;
            this.tbxRepitaSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRepitaSenha.Location = new System.Drawing.Point(198, 223);
            this.tbxRepitaSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxRepitaSenha.Name = "tbxRepitaSenha";
            this.tbxRepitaSenha.PasswordChar = '*';
            this.tbxRepitaSenha.PlaceholderText = "";
            this.tbxRepitaSenha.SelectedText = "";
            this.tbxRepitaSenha.Size = new System.Drawing.Size(343, 28);
            this.tbxRepitaSenha.TabIndex = 161;
            // 
            // tbxSenha
            // 
            this.tbxSenha.BorderColor = System.Drawing.Color.Black;
            this.tbxSenha.BorderRadius = 10;
            this.tbxSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSenha.DefaultText = "";
            this.tbxSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.ForeColor = System.Drawing.Color.Black;
            this.tbxSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSenha.Location = new System.Drawing.Point(198, 171);
            this.tbxSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.PlaceholderText = "";
            this.tbxSenha.SelectedText = "";
            this.tbxSenha.Size = new System.Drawing.Size(343, 28);
            this.tbxSenha.TabIndex = 160;
            // 
            // tbxNomeDeUsuario
            // 
            this.tbxNomeDeUsuario.BorderColor = System.Drawing.Color.Black;
            this.tbxNomeDeUsuario.BorderRadius = 10;
            this.tbxNomeDeUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNomeDeUsuario.DefaultText = "";
            this.tbxNomeDeUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxNomeDeUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxNomeDeUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNomeDeUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNomeDeUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNomeDeUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomeDeUsuario.ForeColor = System.Drawing.Color.Black;
            this.tbxNomeDeUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNomeDeUsuario.Location = new System.Drawing.Point(198, 67);
            this.tbxNomeDeUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNomeDeUsuario.Name = "tbxNomeDeUsuario";
            this.tbxNomeDeUsuario.PasswordChar = '\0';
            this.tbxNomeDeUsuario.PlaceholderText = "";
            this.tbxNomeDeUsuario.SelectedText = "";
            this.tbxNomeDeUsuario.Size = new System.Drawing.Size(343, 28);
            this.tbxNomeDeUsuario.TabIndex = 158;
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCadastro.Location = new System.Drawing.Point(26, 71);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(142, 20);
            this.labelCadastro.TabIndex = 165;
            this.labelCadastro.Text = "Nome de Usuário*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(107, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 164;
            this.label2.Text = "Nome*:";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFornecedor.Location = new System.Drawing.Point(34, 227);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(134, 20);
            this.labelFornecedor.TabIndex = 163;
            this.labelFornecedor.Text = "Repita a Senha*: ";
            // 
            // labelNF
            // 
            this.labelNF.AutoSize = true;
            this.labelNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNF.Location = new System.Drawing.Point(98, 175);
            this.labelNF.Name = "labelNF";
            this.labelNF.Size = new System.Drawing.Size(70, 20);
            this.labelNF.TabIndex = 162;
            this.labelNF.Text = "Senha*: ";
            // 
            // cbxEAdm
            // 
            this.cbxEAdm.AutoSize = true;
            this.cbxEAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEAdm.Location = new System.Drawing.Point(209, 281);
            this.cbxEAdm.Name = "cbxEAdm";
            this.cbxEAdm.Size = new System.Drawing.Size(185, 24);
            this.cbxEAdm.TabIndex = 166;
            this.cbxEAdm.Text = "Usuário Administrador";
            this.cbxEAdm.UseVisualStyleBackColor = true;
            // 
            // ConsultarUsuarioSis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 560);
            this.Controls.Add(this.cbxEAdm);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.tbxRepitaSenha);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxNomeDeUsuario);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNF);
            this.Controls.Add(this.btnExcluirManut);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvUsuariosPatri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarUsuarioSis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuário do Sistema";
            this.Load += new System.EventHandler(this.ConsultarUsuarioSis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPatri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuariosPatri;
        private System.Windows.Forms.Button btnExcluirManut;
        private System.Windows.Forms.Button btnEditar;
        private Guna.UI2.WinForms.Guna2TextBox tbxNome;
        private Guna.UI2.WinForms.Guna2TextBox tbxRepitaSenha;
        private Guna.UI2.WinForms.Guna2TextBox tbxSenha;
        private Guna.UI2.WinForms.Guna2TextBox tbxNomeDeUsuario;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelNF;
        private System.Windows.Forms.CheckBox cbxEAdm;
    }
}