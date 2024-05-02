namespace Peojeto_Prog_Sistem
{
    partial class ConsultarPatrimonio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPatrimonio));
            this.dgvPatrimonios = new System.Windows.Forms.DataGridView();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtpDtGarantia = new System.Windows.Forms.DateTimePicker();
            this.dtpDtAquisicao = new System.Windows.Forms.DateTimePicker();
            this.tbxObservacoes = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbGestorResp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxOperador = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxLocalizacao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxLocacao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbNf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbDescricaoPatri = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGestorResp = new System.Windows.Forms.Label();
            this.labelOperador = new System.Windows.Forms.Label();
            this.labelLocalizacao = new System.Windows.Forms.Label();
            this.labelLocacao = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelNF = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatrimonios
            // 
            this.dgvPatrimonios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatrimonios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatrimonios.EnableHeadersVisualStyles = false;
            this.dgvPatrimonios.Location = new System.Drawing.Point(629, 7);
            this.dgvPatrimonios.MultiSelect = false;
            this.dgvPatrimonios.Name = "dgvPatrimonios";
            this.dgvPatrimonios.ReadOnly = true;
            this.dgvPatrimonios.RowHeadersVisible = false;
            this.dgvPatrimonios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatrimonios.Size = new System.Drawing.Size(660, 490);
            this.dgvPatrimonios.TabIndex = 104;
            this.dgvPatrimonios.DoubleClick += new System.EventHandler(this.dgvPatrimonios_DoubleClick);
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(198, 93);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(422, 29);
            this.cbxFornecedor.TabIndex = 129;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(594, 593);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 34);
            this.btnEditar.TabIndex = 128;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtpDtGarantia
            // 
            this.dtpDtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtGarantia.Location = new System.Drawing.Point(198, 175);
            this.dtpDtGarantia.Name = "dtpDtGarantia";
            this.dtpDtGarantia.Size = new System.Drawing.Size(343, 24);
            this.dtpDtGarantia.TabIndex = 127;
            // 
            // dtpDtAquisicao
            // 
            this.dtpDtAquisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAquisicao.Location = new System.Drawing.Point(198, 136);
            this.dtpDtAquisicao.Name = "dtpDtAquisicao";
            this.dtpDtAquisicao.Size = new System.Drawing.Size(343, 24);
            this.dtpDtAquisicao.TabIndex = 126;
            // 
            // tbxObservacoes
            // 
            this.tbxObservacoes.BorderColor = System.Drawing.Color.Black;
            this.tbxObservacoes.BorderRadius = 10;
            this.tbxObservacoes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxObservacoes.DefaultText = "";
            this.tbxObservacoes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxObservacoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxObservacoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxObservacoes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxObservacoes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxObservacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxObservacoes.ForeColor = System.Drawing.Color.Black;
            this.tbxObservacoes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxObservacoes.Location = new System.Drawing.Point(198, 512);
            this.tbxObservacoes.Multiline = true;
            this.tbxObservacoes.Name = "tbxObservacoes";
            this.tbxObservacoes.PasswordChar = '\0';
            this.tbxObservacoes.PlaceholderText = "";
            this.tbxObservacoes.SelectedText = "";
            this.tbxObservacoes.Size = new System.Drawing.Size(343, 110);
            this.tbxObservacoes.TabIndex = 125;
            // 
            // txbValor
            // 
            this.txbValor.BorderColor = System.Drawing.Color.Black;
            this.txbValor.BorderRadius = 10;
            this.txbValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbValor.DefaultText = "";
            this.txbValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValor.ForeColor = System.Drawing.Color.Black;
            this.txbValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbValor.Location = new System.Drawing.Point(198, 469);
            this.txbValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbValor.Name = "txbValor";
            this.txbValor.PasswordChar = '\0';
            this.txbValor.PlaceholderText = "";
            this.txbValor.SelectedText = "";
            this.txbValor.Size = new System.Drawing.Size(343, 28);
            this.txbValor.TabIndex = 124;
            // 
            // cbbGestorResp
            // 
            this.cbbGestorResp.BackColor = System.Drawing.Color.Transparent;
            this.cbbGestorResp.BorderColor = System.Drawing.Color.Black;
            this.cbbGestorResp.BorderRadius = 10;
            this.cbbGestorResp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGestorResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGestorResp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGestorResp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGestorResp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGestorResp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbGestorResp.ItemHeight = 30;
            this.cbbGestorResp.Items.AddRange(new object[] {
            "Gestor Responsável 1"});
            this.cbbGestorResp.Location = new System.Drawing.Point(198, 418);
            this.cbbGestorResp.Name = "cbbGestorResp";
            this.cbbGestorResp.Size = new System.Drawing.Size(293, 36);
            this.cbbGestorResp.TabIndex = 123;
            // 
            // cbxOperador
            // 
            this.cbxOperador.BackColor = System.Drawing.Color.Transparent;
            this.cbxOperador.BorderColor = System.Drawing.Color.Black;
            this.cbxOperador.BorderRadius = 10;
            this.cbxOperador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperador.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxOperador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxOperador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxOperador.ItemHeight = 30;
            this.cbxOperador.Location = new System.Drawing.Point(198, 367);
            this.cbxOperador.Name = "cbxOperador";
            this.cbxOperador.Size = new System.Drawing.Size(293, 36);
            this.cbxOperador.TabIndex = 122;
            // 
            // cbxLocalizacao
            // 
            this.cbxLocalizacao.BackColor = System.Drawing.Color.Transparent;
            this.cbxLocalizacao.BorderColor = System.Drawing.Color.Black;
            this.cbxLocalizacao.BorderRadius = 10;
            this.cbxLocalizacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLocalizacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocalizacao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocalizacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocalizacao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxLocalizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxLocalizacao.ItemHeight = 30;
            this.cbxLocalizacao.Items.AddRange(new object[] {
            "Localizacao 2"});
            this.cbxLocalizacao.Location = new System.Drawing.Point(198, 265);
            this.cbxLocalizacao.Name = "cbxLocalizacao";
            this.cbxLocalizacao.Size = new System.Drawing.Size(293, 36);
            this.cbxLocalizacao.TabIndex = 121;
            this.cbxLocalizacao.SelectionChangeCommitted += new System.EventHandler(this.cbxLocalizacao_SelectionChangeCommitted);
            // 
            // cbxLocacao
            // 
            this.cbxLocacao.BackColor = System.Drawing.Color.Transparent;
            this.cbxLocacao.BorderColor = System.Drawing.Color.Black;
            this.cbxLocacao.BorderRadius = 10;
            this.cbxLocacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLocacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocacao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocacao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxLocacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxLocacao.ItemHeight = 30;
            this.cbxLocacao.Location = new System.Drawing.Point(198, 316);
            this.cbxLocacao.Name = "cbxLocacao";
            this.cbxLocacao.Size = new System.Drawing.Size(293, 36);
            this.cbxLocacao.TabIndex = 120;
            this.cbxLocacao.SelectionChangeCommitted += new System.EventHandler(this.cbxLocacao_SelectionChangeCommitted);
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbxStatus.BorderColor = System.Drawing.Color.Black;
            this.cbxStatus.BorderRadius = 10;
            this.cbxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxStatus.ItemHeight = 30;
            this.cbxStatus.Location = new System.Drawing.Point(198, 214);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(293, 36);
            this.cbxStatus.TabIndex = 119;
            // 
            // txbNf
            // 
            this.txbNf.BorderColor = System.Drawing.Color.Black;
            this.txbNf.BorderRadius = 10;
            this.txbNf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNf.DefaultText = "";
            this.txbNf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNf.ForeColor = System.Drawing.Color.Black;
            this.txbNf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNf.Location = new System.Drawing.Point(198, 50);
            this.txbNf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNf.Name = "txbNf";
            this.txbNf.PasswordChar = '\0';
            this.txbNf.PlaceholderText = "";
            this.txbNf.SelectedText = "";
            this.txbNf.Size = new System.Drawing.Size(422, 28);
            this.txbNf.TabIndex = 118;
            // 
            // txbDescricaoPatri
            // 
            this.txbDescricaoPatri.BorderColor = System.Drawing.Color.Black;
            this.txbDescricaoPatri.BorderRadius = 10;
            this.txbDescricaoPatri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDescricaoPatri.DefaultText = "";
            this.txbDescricaoPatri.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDescricaoPatri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDescricaoPatri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDescricaoPatri.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDescricaoPatri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDescricaoPatri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricaoPatri.ForeColor = System.Drawing.Color.Black;
            this.txbDescricaoPatri.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDescricaoPatri.Location = new System.Drawing.Point(198, 7);
            this.txbDescricaoPatri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDescricaoPatri.Name = "txbDescricaoPatri";
            this.txbDescricaoPatri.PasswordChar = '\0';
            this.txbDescricaoPatri.PlaceholderText = "";
            this.txbDescricaoPatri.SelectedText = "";
            this.txbDescricaoPatri.Size = new System.Drawing.Size(422, 28);
            this.txbDescricaoPatri.TabIndex = 117;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelValor.Location = new System.Drawing.Point(112, 473);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(56, 20);
            this.labelValor.TabIndex = 116;
            this.labelValor.Text = "Valor*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(62, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 115;
            this.label3.Text = "Observações:";
            // 
            // labelGestorResp
            // 
            this.labelGestorResp.AutoSize = true;
            this.labelGestorResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestorResp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGestorResp.Location = new System.Drawing.Point(10, 426);
            this.labelGestorResp.Name = "labelGestorResp";
            this.labelGestorResp.Size = new System.Drawing.Size(158, 20);
            this.labelGestorResp.TabIndex = 114;
            this.labelGestorResp.Text = "Gestor Responsável:";
            // 
            // labelOperador
            // 
            this.labelOperador.AutoSize = true;
            this.labelOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOperador.Location = new System.Drawing.Point(88, 375);
            this.labelOperador.Name = "labelOperador";
            this.labelOperador.Size = new System.Drawing.Size(80, 20);
            this.labelOperador.TabIndex = 113;
            this.labelOperador.Text = "Operador:";
            // 
            // labelLocalizacao
            // 
            this.labelLocalizacao.AutoSize = true;
            this.labelLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLocalizacao.Location = new System.Drawing.Point(65, 273);
            this.labelLocalizacao.Name = "labelLocalizacao";
            this.labelLocalizacao.Size = new System.Drawing.Size(103, 20);
            this.labelLocalizacao.TabIndex = 112;
            this.labelLocalizacao.Text = "Localização*:";
            // 
            // labelLocacao
            // 
            this.labelLocacao.AutoSize = true;
            this.labelLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLocacao.Location = new System.Drawing.Point(94, 324);
            this.labelLocacao.Name = "labelLocacao";
            this.labelLocacao.Size = new System.Drawing.Size(74, 20);
            this.labelLocacao.TabIndex = 111;
            this.labelLocacao.Text = "Locação:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStatus.Location = new System.Drawing.Point(102, 222);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 20);
            this.labelStatus.TabIndex = 110;
            this.labelStatus.Text = "Status*:";
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCadastro.Location = new System.Drawing.Point(78, 11);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(90, 20);
            this.labelCadastro.TabIndex = 109;
            this.labelCadastro.Text = "Descrição*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(87, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "Garantia*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Data de Aquisição*: ";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFornecedor.Location = new System.Drawing.Point(63, 97);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(105, 20);
            this.labelFornecedor.TabIndex = 106;
            this.labelFornecedor.Text = "Fornecedor*: ";
            // 
            // labelNF
            // 
            this.labelNF.AutoSize = true;
            this.labelNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNF.Location = new System.Drawing.Point(124, 54);
            this.labelNF.Name = "labelNF";
            this.labelNF.Size = new System.Drawing.Size(44, 20);
            this.labelNF.TabIndex = 105;
            this.labelNF.Text = "NF*: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(747, 593);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 34);
            this.btnExcluir.TabIndex = 130;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ConsultarPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 646);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtpDtGarantia);
            this.Controls.Add(this.dtpDtAquisicao);
            this.Controls.Add(this.tbxObservacoes);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.cbbGestorResp);
            this.Controls.Add(this.cbxOperador);
            this.Controls.Add(this.cbxLocalizacao);
            this.Controls.Add(this.cbxLocacao);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.txbNf);
            this.Controls.Add(this.txbDescricaoPatri);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelGestorResp);
            this.Controls.Add(this.labelOperador);
            this.Controls.Add(this.labelLocalizacao);
            this.Controls.Add(this.labelLocacao);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNF);
            this.Controls.Add(this.dgvPatrimonios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarPatrimonio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Patrimônio";
            this.Load += new System.EventHandler(this.ConsultarPatrimonio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatrimonios;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DateTimePicker dtpDtGarantia;
        private System.Windows.Forms.DateTimePicker dtpDtAquisicao;
        private Guna.UI2.WinForms.Guna2TextBox tbxObservacoes;
        private Guna.UI2.WinForms.Guna2TextBox txbValor;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGestorResp;
        private Guna.UI2.WinForms.Guna2ComboBox cbxOperador;
        private Guna.UI2.WinForms.Guna2ComboBox cbxLocalizacao;
        private Guna.UI2.WinForms.Guna2ComboBox cbxLocacao;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStatus;
        private Guna.UI2.WinForms.Guna2TextBox txbNf;
        private Guna.UI2.WinForms.Guna2TextBox txbDescricaoPatri;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGestorResp;
        private System.Windows.Forms.Label labelOperador;
        private System.Windows.Forms.Label labelLocalizacao;
        private System.Windows.Forms.Label labelLocacao;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelNF;
        private System.Windows.Forms.Button btnExcluir;
    }
}