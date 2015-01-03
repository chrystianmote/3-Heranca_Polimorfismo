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
    public partial class FormCadastroPessoaFisica : Form
    {
        public FormCadastroPessoaFisica()
        {
            InitializeComponent();
            Random rdn = new Random();
            txtCodigo.Text = rdn.Next(100, 99999999).ToString();
            txtCPF.Text = rdn.Next(100, 999) + "." + rdn.Next(100, 999) + "." + rdn.Next(100, 999) + "-" + rdn.Next(10, 99);
            txtRG.Text = rdn.Next(1, 9) + "." + rdn.Next(100, 999) + "." + rdn.Next(100, 999);
        }
    }
}
