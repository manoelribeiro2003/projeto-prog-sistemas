namespace Peojeto_Prog_Sistem
{
    partial class CadastroManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroManutencao));
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxPatrimonio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpPrevisao = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFornecedor.Location = new System.Drawing.Point(39, 133);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(84, 21);
            this.labelFornecedor.TabIndex = 63;
            this.labelFornecedor.Text = "Previsão*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(48, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Motivo*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "Patrimônio*:";
            // 
            // tbxMotivo
            // 
            this.tbxMotivo.BorderColor = System.Drawing.Color.Black;
            this.tbxMotivo.BorderRadius = 10;
            this.tbxMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMotivo.DefaultText = "";
            this.tbxMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMotivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMotivo.Location = new System.Drawing.Point(133, 197);
            this.tbxMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMotivo.Multiline = true;
            this.tbxMotivo.Name = "tbxMotivo";
            this.tbxMotivo.PasswordChar = '\0';
            this.tbxMotivo.PlaceholderText = "";
            this.tbxMotivo.SelectedText = "";
            this.tbxMotivo.Size = new System.Drawing.Size(343, 110);
            this.tbxMotivo.TabIndex = 94;
            // 
            // cbxPatrimonio
            // 
            this.cbxPatrimonio.BackColor = System.Drawing.Color.Transparent;
            this.cbxPatrimonio.BorderColor = System.Drawing.Color.Black;
            this.cbxPatrimonio.BorderRadius = 10;
            this.cbxPatrimonio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPatrimonio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPatrimonio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPatrimonio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPatrimonio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxPatrimonio.ForeColor = System.Drawing.Color.Black;
            this.cbxPatrimonio.ItemHeight = 30;
            this.cbxPatrimonio.Location = new System.Drawing.Point(133, 61);
            this.cbxPatrimonio.Name = "cbxPatrimonio";
            this.cbxPatrimonio.Size = new System.Drawing.Size(343, 36);
            this.cbxPatrimonio.TabIndex = 103;
            this.cbxPatrimonio.SelectedIndexChanged += new System.EventHandler(this.cbxPatrimonio_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(553, 275);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 32);
            this.btnSalvar.TabIndex = 104;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpPrevisao
            // 
            this.dtpPrevisao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrevisao.Location = new System.Drawing.Point(133, 129);
            this.dtpPrevisao.Name = "dtpPrevisao";
            this.dtpPrevisao.Size = new System.Drawing.Size(343, 29);
            this.dtpPrevisao.TabIndex = 105;
            // 
            // CadastroManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 385);
            this.Controls.Add(this.dtpPrevisao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbxPatrimonio);
            this.Controls.Add(this.tbxMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroManutencao";
            this.Text = "Cadastro de Manutenções";
            this.Load += new System.EventHandler(this.CadastroManutencao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbxMotivo;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPatrimonio;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpPrevisao;
    }
}