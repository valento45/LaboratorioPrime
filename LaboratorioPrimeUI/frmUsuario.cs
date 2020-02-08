﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoalheriaPrimeDAL;
using JoalheriaPrimeBLL;

namespace LaboratorioPrimeUI
{    
    public partial class frmUsuario : Form
    {
        bool alterar = false;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        public void Gravar()
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Funcao = txtFuncao.Text;
            usuario.Documento = txtRg.Text;
            usuario.CPF = txtCpf.Text;
            usuario.Modulos = txtModulos.Text;
            usuario.Observacoes = txtObservacao.Text;
            usuario.userPermissao =Convert.ToChar(txtPermissao.Text);
            if (chkAtivo.Checked)
                usuario.Ativo = true;
            else
                usuario.Ativo = false;

            
        }

        private bool ValidarCampos()
        {
            if (txtNome.Text.Trim() != "" || txtLogin.Text.Trim() != "" || txtSenha.Text.Trim() != "" && txtSenha.Text.Trim() == txtConfirmaSenha.Text.Trim())
                return true;
            else
                return false;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (alterar == false && ValidarCampos())
                Gravar();
        }
    }
}
