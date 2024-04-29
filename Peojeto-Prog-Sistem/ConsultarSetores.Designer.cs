namespace Peojeto_Prog_Sistem
{
    partial class ConsultarSetores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExcluirManut = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvSetores = new System.Windows.Forms.DataGridView();
            this.tbxSubdivisao = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirManut
            // 
            this.btnExcluirManut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirManut.Location = new System.Drawing.Point(463, 374);
            this.btnExcluirManut.Name = "btnExcluirManut";
            this.btnExcluirManut.Size = new System.Drawing.Size(167, 38);
            this.btnExcluirManut.TabIndex = 116;
            this.btnExcluirManut.Text = "E&xcluir";
            this.btnExcluirManut.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(126, 374);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 38);
            this.btnEditar.TabIndex = 115;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvSetores
            // 
            this.dgvSetores.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSetores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetores.EnableHeadersVisualStyles = false;
            this.dgvSetores.Location = new System.Drawing.Point(431, 35);
            this.dgvSetores.MultiSelect = false;
            this.dgvSetores.Name = "dgvSetores";
            this.dgvSetores.ReadOnly = true;
            this.dgvSetores.RowHeadersVisible = false;
            this.dgvSetores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSetores.Size = new System.Drawing.Size(355, 316);
            this.dgvSetores.TabIndex = 114;
            this.dgvSetores.DoubleClick += new System.EventHandler(this.dgvSetores_DoubleClick);
            // 
            // tbxSubdivisao
            // 
            this.tbxSubdivisao.BorderRadius = 10;
            this.tbxSubdivisao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSubdivisao.DefaultText = "";
            this.tbxSubdivisao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSubdivisao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSubdivisao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSubdivisao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSubdivisao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSubdivisao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubdivisao.ForeColor = System.Drawing.Color.Black;
            this.tbxSubdivisao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSubdivisao.Location = new System.Drawing.Point(126, 160);
            this.tbxSubdivisao.Name = "tbxSubdivisao";
            this.tbxSubdivisao.PasswordChar = '\0';
            this.tbxSubdivisao.PlaceholderText = "";
            this.tbxSubdivisao.SelectedText = "";
            this.tbxSubdivisao.Size = new System.Drawing.Size(281, 28);
            this.tbxSubdivisao.TabIndex = 112;
            // 
            // tbxNome
            // 
            this.tbxNome.BorderRadius = 10;
            this.tbxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNome.DefaultText = "";
            this.tbxNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxNome.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxNome.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tbxNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.ForeColor = System.Drawing.Color.Black;
            this.tbxNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNome.Location = new System.Drawing.Point(126, 96);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.PasswordChar = '\0';
            this.tbxNome.PlaceholderText = "";
            this.tbxNome.SelectedText = "";
            this.tbxNome.Size = new System.Drawing.Size(281, 28);
            this.tbxNome.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 108;
            this.label2.Text = "Subdivisão:";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFornecedor.Location = new System.Drawing.Point(42, 100);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(67, 21);
            this.labelFornecedor.TabIndex = 107;
            this.labelFornecedor.Text = "Nome*:";
            // 
            // ConsultarSetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluirManut);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvSetores);
            this.Controls.Add(this.tbxSubdivisao);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFornecedor);
            this.Name = "ConsultarSetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Setores";
            this.Load += new System.EventHandler(this.ConsultarSetores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirManut;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvSetores;
        private Guna.UI2.WinForms.Guna2TextBox tbxSubdivisao;
        private Guna.UI2.WinForms.Guna2TextBox tbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFornecedor;
    }
}