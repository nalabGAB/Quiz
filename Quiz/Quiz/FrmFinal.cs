using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmFinal : Form
    {
        public FrmFinal()
        {
            InitializeComponent();
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErros.Text = VariaveisGlobais.Erros.ToString();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblAcertos_Click(object sender, EventArgs e)
        {

        }
    }
}
