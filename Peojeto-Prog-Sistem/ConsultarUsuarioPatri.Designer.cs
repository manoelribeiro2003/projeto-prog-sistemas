namespace Peojeto_Prog_Sistem
{
    partial class ConsultarUsuarioPatri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuarioPatri));
            this.btnExcluirManut = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvUsuariosPatri = new System.Windows.Forms.DataGridView();
            this.labelNF = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.tbxNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxCargo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxResponsavel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSetor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxSubdivisao = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPatri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirManut
            // 
            this.btnExcluirManut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirManut.Location = new System.Drawing.Point(629, 553);
            this.btnExcluirManut.Name = "btnExcluirManut";
            this.btnExcluirManut.Size = new System.Drawing.Size(167, 38);
            this.btnExcluirManut.TabIndex = 116;
            this.btnExcluirManut.Text = "E&xcluir";
            this.btnExcluirManut.UseVisualStyleBackColor = true;
            this.btnExcluirManut.Click += new System.EventHandler(this.btnExcluirManut_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(349, 553);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 38);
            this.btnEditar.TabIndex = 115;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.dgvUsuariosPatri.Location = new System.Drawing.Point(548, 31);
            this.dgvUsuariosPatri.MultiSelect = false;
            this.dgvUsuariosPatri.Name = "dgvUsuariosPatri";
            this.dgvUsuariosPatri.ReadOnly = true;
            this.dgvUsuariosPatri.RowHeadersVisible = false;
            this.dgvUsuariosPatri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosPatri.Size = new System.Drawing.Size(541, 316);
            this.dgvUsuariosPatri.TabIndex = 114;
            this.dgvUsuariosPatri.DoubleClick += new System.EventHandler(this.dgvUsuariosPatri_DoubleClick);
            // 
            // labelNF
            // 
            this.labelNF.AutoSize = true;
            this.labelNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNF.Location = new System.Drawing.Point(56, 139);
            this.labelNF.Name = "labelNF";
            this.labelNF.Size = new System.Drawing.Size(66, 20);
            this.labelNF.TabIndex = 135;
            this.labelNF.Text = "Cargo*: ";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFornecedor.Location = new System.Drawing.Point(60, 195);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(62, 20);
            this.labelFornecedor.TabIndex = 136;
            this.labelFornecedor.Text = "Setor*: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 137;
            this.label2.Text = "Responsável*:";
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCadastro.Location = new System.Drawing.Point(61, 35);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(61, 20);
            this.labelCadastro.TabIndex = 138;
            this.labelCadastro.Text = "Nome*:";
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
            this.tbxNome.Location = new System.Drawing.Point(161, 31);
            this.tbxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.PasswordChar = '\0';
            this.tbxNome.PlaceholderText = "";
            this.tbxNome.SelectedText = "";
            this.tbxNome.Size = new System.Drawing.Size(343, 28);
            this.tbxNome.TabIndex = 139;
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
            this.tbxCargo.Location = new System.Drawing.Point(161, 135);
            this.tbxCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCargo.Name = "tbxCargo";
            this.tbxCargo.PasswordChar = '\0';
            this.tbxCargo.PlaceholderText = "";
            this.tbxCargo.SelectedText = "";
            this.tbxCargo.Size = new System.Drawing.Size(343, 28);
            this.tbxCargo.TabIndex = 140;
            // 
            // tbxResponsavel
            // 
            this.tbxResponsavel.BorderColor = System.Drawing.Color.Black;
            this.tbxResponsavel.BorderRadius = 10;
            this.tbxResponsavel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxResponsavel.DefaultText = "";
            this.tbxResponsavel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxResponsavel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxResponsavel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxResponsavel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxResponsavel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxResponsavel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResponsavel.ForeColor = System.Drawing.Color.Black;
            this.tbxResponsavel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxResponsavel.Location = new System.Drawing.Point(161, 83);
            this.tbxResponsavel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxResponsavel.Name = "tbxResponsavel";
            this.tbxResponsavel.PasswordChar = '\0';
            this.tbxResponsavel.PlaceholderText = "";
            this.tbxResponsavel.SelectedText = "";
            this.tbxResponsavel.Size = new System.Drawing.Size(343, 28);
            this.tbxResponsavel.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(22, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 142;
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
            this.cbxSetor.Location = new System.Drawing.Point(161, 187);
            this.cbxSetor.Name = "cbxSetor";
            this.cbxSetor.Size = new System.Drawing.Size(343, 36);
            this.cbxSetor.TabIndex = 143;
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
            this.cbxSubdivisao.Location = new System.Drawing.Point(161, 247);
            this.cbxSubdivisao.Name = "cbxSubdivisao";
            this.cbxSubdivisao.Size = new System.Drawing.Size(343, 36);
            this.cbxSubdivisao.TabIndex = 144;
            // 
            // ConsultarUsuarioPatri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 603);
            this.Controls.Add(this.cbxSubdivisao);
            this.Controls.Add(this.cbxSetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxResponsavel);
            this.Controls.Add(this.tbxCargo);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNF);
            this.Controls.Add(this.btnExcluirManut);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvUsuariosPatri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarUsuarioPatri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuário de Patrimônio";
            this.Load += new System.EventHandler(this.ConsultarUsuarioPatri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPatri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirManut;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvUsuariosPatri;
        private System.Windows.Forms.Label labelNF;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCadastro;
        private Guna.UI2.WinForms.Guna2TextBox tbxNome;
        private Guna.UI2.WinForms.Guna2TextBox tbxCargo;
        private Guna.UI2.WinForms.Guna2TextBox tbxResponsavel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSetor;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSubdivisao;
    }
}