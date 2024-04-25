namespace Peojeto_Prog_Sistem
{
    partial class CadastroSetores
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbxAddPatrimonio = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbxStatusPatri = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(346, 298);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 32);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // tbxAddPatrimonio
            // 
            this.tbxAddPatrimonio.BorderColor = System.Drawing.Color.Black;
            this.tbxAddPatrimonio.BorderRadius = 10;
            this.tbxAddPatrimonio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAddPatrimonio.DefaultText = "";
            this.tbxAddPatrimonio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxAddPatrimonio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxAddPatrimonio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAddPatrimonio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAddPatrimonio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAddPatrimonio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddPatrimonio.ForeColor = System.Drawing.Color.Black;
            this.tbxAddPatrimonio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAddPatrimonio.Location = new System.Drawing.Point(107, 239);
            this.tbxAddPatrimonio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAddPatrimonio.Name = "tbxAddPatrimonio";
            this.tbxAddPatrimonio.PasswordChar = '\0';
            this.tbxAddPatrimonio.PlaceholderText = "";
            this.tbxAddPatrimonio.SelectedText = "";
            this.tbxAddPatrimonio.Size = new System.Drawing.Size(330, 30);
            this.tbxAddPatrimonio.TabIndex = 16;
            // 
            // lbxStatusPatri
            // 
            this.lbxStatusPatri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStatusPatri.FormattingEnabled = true;
            this.lbxStatusPatri.ItemHeight = 21;
            this.lbxStatusPatri.Location = new System.Drawing.Point(107, 73);
            this.lbxStatusPatri.Name = "lbxStatusPatri";
            this.lbxStatusPatri.Size = new System.Drawing.Size(330, 151);
            this.lbxStatusPatri.TabIndex = 15;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(224, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 32);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(102, 298);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 32);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // CadastroSetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 402);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.tbxAddPatrimonio);
            this.Controls.Add(this.lbxStatusPatri);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "CadastroSetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Setores";
            this.Load += new System.EventHandler(this.CadastroSetores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private Guna.UI2.WinForms.Guna2TextBox tbxAddPatrimonio;
        private System.Windows.Forms.ListBox lbxStatusPatri;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
    }
}