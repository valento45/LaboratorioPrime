namespace LaboratorioPrimeUI
{
    partial class frmUsuario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAcao = new System.Windows.Forms.Button();
            this.groupInfObs = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.groupInfUsuario = new System.Windows.Forms.GroupBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPermissao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModulos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groudInfPessoal = new System.Windows.Forms.GroupBox();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.dgvConsultarUsuario = new System.Windows.Forms.DataGridView();
            this.groupOpFiltros = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.groupInfObs.SuspendLayout();
            this.groupInfUsuario.SuspendLayout();
            this.groudInfPessoal.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabConsultar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 490);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "0";
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.btnNovo);
            this.tabRegistro.Controls.Add(this.btnCancelar);
            this.tabRegistro.Controls.Add(this.btnImprimir);
            this.tabRegistro.Controls.Add(this.btnAcao);
            this.tabRegistro.Controls.Add(this.groupInfObs);
            this.tabRegistro.Controls.Add(this.groupInfUsuario);
            this.tabRegistro.Controls.Add(this.groudInfPessoal);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(834, 464);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo.BackColor = System.Drawing.Color.Teal;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(168, 430);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(107, 28);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(538, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.BackColor = System.Drawing.Color.Teal;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(422, 430);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(107, 28);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnAcao
            // 
            this.btnAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAcao.BackColor = System.Drawing.Color.Teal;
            this.btnAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcao.ForeColor = System.Drawing.Color.White;
            this.btnAcao.Location = new System.Drawing.Point(303, 430);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(107, 28);
            this.btnAcao.TabIndex = 3;
            this.btnAcao.Text = "Incluir";
            this.btnAcao.UseVisualStyleBackColor = false;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // groupInfObs
            // 
            this.groupInfObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfObs.Controls.Add(this.txtObservacao);
            this.groupInfObs.Location = new System.Drawing.Point(6, 269);
            this.groupInfObs.Name = "groupInfObs";
            this.groupInfObs.Size = new System.Drawing.Size(822, 139);
            this.groupInfObs.TabIndex = 2;
            this.groupInfObs.TabStop = false;
            this.groupInfObs.Text = "Observacões";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.Location = new System.Drawing.Point(76, 19);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(642, 93);
            this.txtObservacao.TabIndex = 2;
            // 
            // groupInfUsuario
            // 
            this.groupInfUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfUsuario.Controls.Add(this.chkAtivo);
            this.groupInfUsuario.Controls.Add(this.label7);
            this.groupInfUsuario.Controls.Add(this.txtPermissao);
            this.groupInfUsuario.Controls.Add(this.label6);
            this.groupInfUsuario.Controls.Add(this.txtConfirmaSenha);
            this.groupInfUsuario.Controls.Add(this.label10);
            this.groupInfUsuario.Controls.Add(this.txtSenha);
            this.groupInfUsuario.Controls.Add(this.label9);
            this.groupInfUsuario.Controls.Add(this.txtModulos);
            this.groupInfUsuario.Controls.Add(this.label5);
            this.groupInfUsuario.Controls.Add(this.txtLogin);
            this.groupInfUsuario.Controls.Add(this.label8);
            this.groupInfUsuario.Location = new System.Drawing.Point(6, 133);
            this.groupInfUsuario.Name = "groupInfUsuario";
            this.groupInfUsuario.Size = new System.Drawing.Size(822, 130);
            this.groupInfUsuario.TabIndex = 1;
            this.groupInfUsuario.TabStop = false;
            this.groupInfUsuario.Text = "Informações de Usuário";
            // 
            // chkAtivo
            // 
            this.chkAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(529, 93);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(15, 14);
            this.chkAtivo.TabIndex = 15;
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ativo";
            // 
            // txtPermissao
            // 
            this.txtPermissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPermissao.Location = new System.Drawing.Point(529, 60);
            this.txtPermissao.Name = "txtPermissao";
            this.txtPermissao.Size = new System.Drawing.Size(189, 20);
            this.txtPermissao.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Permissão";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmaSenha.Location = new System.Drawing.Point(213, 84);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = 'O';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(123, 20);
            this.txtConfirmaSenha.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Confirmar senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Location = new System.Drawing.Point(213, 57);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'O';
            this.txtSenha.Size = new System.Drawing.Size(123, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Senha";
            // 
            // txtModulos
            // 
            this.txtModulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModulos.Location = new System.Drawing.Point(529, 34);
            this.txtModulos.Name = "txtModulos";
            this.txtModulos.Size = new System.Drawing.Size(189, 20);
            this.txtModulos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Módulos";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Location = new System.Drawing.Point(213, 31);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(123, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Login";
            // 
            // groudInfPessoal
            // 
            this.groudInfPessoal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groudInfPessoal.Controls.Add(this.txtFuncao);
            this.groudInfPessoal.Controls.Add(this.label4);
            this.groudInfPessoal.Controls.Add(this.txtCpf);
            this.groudInfPessoal.Controls.Add(this.label3);
            this.groudInfPessoal.Controls.Add(this.txtRg);
            this.groudInfPessoal.Controls.Add(this.label2);
            this.groudInfPessoal.Controls.Add(this.txtNome);
            this.groudInfPessoal.Controls.Add(this.label1);
            this.groudInfPessoal.Location = new System.Drawing.Point(6, 6);
            this.groudInfPessoal.Name = "groudInfPessoal";
            this.groudInfPessoal.Size = new System.Drawing.Size(822, 121);
            this.groudInfPessoal.TabIndex = 0;
            this.groudInfPessoal.TabStop = false;
            this.groudInfPessoal.Text = "Informações Pessoais";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFuncao.Location = new System.Drawing.Point(538, 62);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(180, 20);
            this.txtFuncao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Função";
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpf.Location = new System.Drawing.Point(351, 62);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(125, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // txtRg
            // 
            this.txtRg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRg.Location = new System.Drawing.Point(186, 62);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(123, 20);
            this.txtRg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(186, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(532, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.pnlConsultar);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(834, 464);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Tag = "1";
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConsultar.Controls.Add(this.button4);
            this.pnlConsultar.Controls.Add(this.button3);
            this.pnlConsultar.Controls.Add(this.button1);
            this.pnlConsultar.Controls.Add(this.button2);
            this.pnlConsultar.Controls.Add(this.btnPesquisar);
            this.pnlConsultar.Controls.Add(this.txtFiltro);
            this.pnlConsultar.Controls.Add(this.label11);
            this.pnlConsultar.Controls.Add(this.groupOpFiltros);
            this.pnlConsultar.Controls.Add(this.dgvConsultarUsuario);
            this.pnlConsultar.Location = new System.Drawing.Point(6, 6);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(822, 452);
            this.pnlConsultar.TabIndex = 0;
            // 
            // dgvConsultarUsuario
            // 
            this.dgvConsultarUsuario.AllowUserToAddRows = false;
            this.dgvConsultarUsuario.AllowUserToDeleteRows = false;
            this.dgvConsultarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvConsultarUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvConsultarUsuario.GridColor = System.Drawing.SystemColors.Control;
            this.dgvConsultarUsuario.Location = new System.Drawing.Point(3, 150);
            this.dgvConsultarUsuario.Name = "dgvConsultarUsuario";
            this.dgvConsultarUsuario.Size = new System.Drawing.Size(816, 256);
            this.dgvConsultarUsuario.TabIndex = 0;
            // 
            // groupOpFiltros
            // 
            this.groupOpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOpFiltros.Location = new System.Drawing.Point(615, 3);
            this.groupOpFiltros.Name = "groupOpFiltros";
            this.groupOpFiltros.Size = new System.Drawing.Size(200, 141);
            this.groupOpFiltros.TabIndex = 0;
            this.groupOpFiltros.TabStop = false;
            this.groupOpFiltros.Text = "Filtrar Por";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(40, 124);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(316, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(362, 121);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 73;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 73;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 73;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 73;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 73;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 73;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 73;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 79;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(556, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(330, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(443, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(175, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Exportar / Importar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(866, 514);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.groupInfObs.ResumeLayout(false);
            this.groupInfObs.PerformLayout();
            this.groupInfUsuario.ResumeLayout(false);
            this.groupInfUsuario.PerformLayout();
            this.groudInfPessoal.ResumeLayout(false);
            this.groudInfPessoal.PerformLayout();
            this.tabConsultar.ResumeLayout(false);
            this.pnlConsultar.ResumeLayout(false);
            this.pnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.GroupBox groudInfPessoal;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.GroupBox groupInfUsuario;
        private System.Windows.Forms.TextBox txtModulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPermissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupInfObs;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlConsultar;
        private System.Windows.Forms.DataGridView dgvConsultarUsuario;
        private System.Windows.Forms.GroupBox groupOpFiltros;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}