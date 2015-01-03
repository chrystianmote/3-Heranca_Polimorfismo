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
    public partial class FormCadastroPessoajuridica : Form
    {
        public FormCadastroPessoajuridica()
        {
            InitializeComponent();
            Random rdn = new Random();
            txtCodigo.Text = rdn.Next(100, 99999999).ToString();
            txtInscricaoEstadual.Text = rdn.Next(100, 999) + "." + rdn.Next(100, 999) + "." + rdn.Next(100, 999) + "." + rdn.Next(100, 999);
            txtCnpj.Text = rdn.Next(10, 99) + "." + rdn.Next(100, 999) + "." + rdn.Next(100, 999) + "/0001-" + rdn.Next(10, 99);
        }
    }
}
