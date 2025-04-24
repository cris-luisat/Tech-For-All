using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_tela05.Views
{
    public partial class Adm_Gerente : Form
    {
        public Adm_Gerente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Adm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnLogin_Adm_Click(object sender, EventArgs e)
        {

        }
    }
}
