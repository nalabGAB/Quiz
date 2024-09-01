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
    public partial class FrmP9 : Form
    {
        public FrmP9()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerto.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "Quiz");
                VariaveisGlobais.Acertos += 1;
                FrmP10 p10 = new FrmP10();
                p10.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton1.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "Quiz");
                VariaveisGlobais.Erros += 1;
                FrmP10 p10 = new FrmP10();
                p10.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa!");
            }
        }
    }
}
