using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarPF_Click(object sender, EventArgs e)
        {
            FormCadastroPessoaFisica formCadastrarPF = new FormCadastroPessoaFisica();
            formCadastrarPF.ShowDialog();
        }

        private void btnCadastrarPJ_Click(object sender, EventArgs e)
        {
            
        }
    }
}
