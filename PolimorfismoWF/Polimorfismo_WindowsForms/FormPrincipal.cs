using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polimorfismo_WindowsForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void CadastrarPF_Click(object sender, EventArgs e)
        {
            FormCadastroPessoaFisica frmCadastroPF = new FormCadastroPessoaFisica();
            frmCadastroPF.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroPessoajuridica frmCadastroPJ = new FormCadastroPessoajuridica();
            frmCadastroPJ.ShowDialog();
        }
    }
}
