﻿namespace Peojeto_Prog_Sistem
{
    partial class StatusPatrimonio
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbxStatusPatri = new System.Windows.Forms.ListBox();
            this.tbxAddPatrimonio = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sai&r";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(197, 264);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 32);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lbxStatusPatri
            // 
            this.lbxStatusPatri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStatusPatri.FormattingEnabled = true;
            this.lbxStatusPatri.ItemHeight = 21;
            this.lbxStatusPatri.Location = new System.Drawing.Point(138, 39);
            this.lbxStatusPatri.Name = "lbxStatusPatri";
            this.lbxStatusPatri.Size = new System.Drawing.Size(330, 151);
            this.lbxStatusPatri.TabIndex = 10;
            // 
            // tbxAddPatrimonio
            // 
            this.tbxAddPatrimonio.BorderRadius = 10;
            this.tbxAddPatrimonio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAddPatrimonio.DefaultText = "";
            this.tbxAddPatrimonio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxAddPatrimonio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxAddPatrimonio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAddPatrimonio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAddPatrimonio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAddPatrimonio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxAddPatrimonio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAddPatrimonio.Location = new System.Drawing.Point(138, 205);
            this.tbxAddPatrimonio.Name = "tbxAddPatrimonio";
            this.tbxAddPatrimonio.PasswordChar = '\0';
            this.tbxAddPatrimonio.PlaceholderText = "";
            this.tbxAddPatrimonio.SelectedText = "";
            this.tbxAddPatrimonio.Size = new System.Drawing.Size(330, 30);
            this.tbxAddPatrimonio.TabIndex = 11;
            // 
            // StatusPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 405);
            this.Controls.Add(this.tbxAddPatrimonio);
            this.Controls.Add(this.lbxStatusPatri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "StatusPatrimonio";
            this.Text = "Editar Status Patrimonio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lbxStatusPatri;
        private Guna.UI2.WinForms.Guna2TextBox tbxAddPatrimonio;
    }
}