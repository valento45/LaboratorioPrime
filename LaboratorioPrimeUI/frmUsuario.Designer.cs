﻿namespace LaboratorioPrimeUI
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
            this.tabPermissao = new System.Windows.Forms.TabPage();
            this.groudInfPessoal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupInfUsuario = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.groupInfObs = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnAcao = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.groudInfPessoal.SuspendLayout();
            this.groupInfUsuario.SuspendLayout();
            this.groupInfObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabPermissao);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 447);
            this.tabControl1.TabIndex = 0;
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
            this.tabRegistro.Size = new System.Drawing.Size(834, 421);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // tabPermissao
            // 
            this.tabPermissao.Location = new System.Drawing.Point(4, 22);
            this.tabPermissao.Name = "tabPermissao";
            this.tabPermissao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermissao.Size = new System.Drawing.Size(834, 421);
            this.tabPermissao.TabIndex = 1;
            this.tabPermissao.Text = "Permissoes";
            this.tabPermissao.UseVisualStyleBackColor = true;
            // 
            // groudInfPessoal
            // 
            this.groudInfPessoal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groudInfPessoal.Controls.Add(this.textBox2);
            this.groudInfPessoal.Controls.Add(this.label4);
            this.groudInfPessoal.Controls.Add(this.maskedTextBox2);
            this.groudInfPessoal.Controls.Add(this.label3);
            this.groudInfPessoal.Controls.Add(this.maskedTextBox1);
            this.groudInfPessoal.Controls.Add(this.label2);
            this.groudInfPessoal.Controls.Add(this.textBox1);
            this.groudInfPessoal.Controls.Add(this.label1);
            this.groudInfPessoal.Location = new System.Drawing.Point(6, 6);
            this.groudInfPessoal.Name = "groudInfPessoal";
            this.groudInfPessoal.Size = new System.Drawing.Size(822, 121);
            this.groudInfPessoal.TabIndex = 0;
            this.groudInfPessoal.TabStop = false;
            this.groudInfPessoal.Text = "Informações Pessoais";
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(186, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 20);
            this.textBox1.TabIndex = 1;
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(186, 62);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(123, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox2.Location = new System.Drawing.Point(351, 62);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(125, 20);
            this.maskedTextBox2.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(538, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 7;
            // 
            // groupInfUsuario
            // 
            this.groupInfUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfUsuario.Controls.Add(this.chkAtivo);
            this.groupInfUsuario.Controls.Add(this.label7);
            this.groupInfUsuario.Controls.Add(this.textBox7);
            this.groupInfUsuario.Controls.Add(this.label6);
            this.groupInfUsuario.Controls.Add(this.textBox6);
            this.groupInfUsuario.Controls.Add(this.label10);
            this.groupInfUsuario.Controls.Add(this.textBox5);
            this.groupInfUsuario.Controls.Add(this.label9);
            this.groupInfUsuario.Controls.Add(this.textBox3);
            this.groupInfUsuario.Controls.Add(this.label5);
            this.groupInfUsuario.Controls.Add(this.textBox4);
            this.groupInfUsuario.Controls.Add(this.label8);
            this.groupInfUsuario.Location = new System.Drawing.Point(6, 133);
            this.groupInfUsuario.Name = "groupInfUsuario";
            this.groupInfUsuario.Size = new System.Drawing.Size(822, 130);
            this.groupInfUsuario.TabIndex = 1;
            this.groupInfUsuario.TabStop = false;
            this.groupInfUsuario.Text = "Informações de Usuário";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(529, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Módulos";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(213, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Login";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(123, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Senha";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(123, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Confirmar senha";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(529, 60);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(189, 20);
            this.textBox7.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Permissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ativo";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(529, 93);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(15, 14);
            this.chkAtivo.TabIndex = 15;
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // groupInfObs
            // 
            this.groupInfObs.Controls.Add(this.textBox8);
            this.groupInfObs.Location = new System.Drawing.Point(6, 269);
            this.groupInfObs.Name = "groupInfObs";
            this.groupInfObs.Size = new System.Drawing.Size(822, 100);
            this.groupInfObs.TabIndex = 2;
            this.groupInfObs.TabStop = false;
            this.groupInfObs.Text = "Observacões";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(105, 19);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(613, 75);
            this.textBox8.TabIndex = 2;
            // 
            // btnAcao
            // 
            this.btnAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAcao.BackColor = System.Drawing.Color.Teal;
            this.btnAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcao.ForeColor = System.Drawing.Color.White;
            this.btnAcao.Location = new System.Drawing.Point(246, 375);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(107, 28);
            this.btnAcao.TabIndex = 3;
            this.btnAcao.Text = "Incluir";
            this.btnAcao.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.BackColor = System.Drawing.Color.Teal;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(365, 375);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(107, 28);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(481, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo.BackColor = System.Drawing.Color.Teal;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(111, 375);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(107, 28);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(866, 471);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.groudInfPessoal.ResumeLayout(false);
            this.groudInfPessoal.PerformLayout();
            this.groupInfUsuario.ResumeLayout(false);
            this.groupInfUsuario.PerformLayout();
            this.groupInfObs.ResumeLayout(false);
            this.groupInfObs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.GroupBox groudInfPessoal;
        private System.Windows.Forms.TabPage tabPermissao;
        private System.Windows.Forms.GroupBox groupInfUsuario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupInfObs;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
    }
}