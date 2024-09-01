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
    public partial class FrmP1 : Form
    {
        public FrmP1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerto.Checked == true)
            {
                MessageBox.Show("Certa Resposta", "Quiz");
                VariaveisGlobais.Acertos += 1;
                FrmP2 p2 = new FrmP2();
                p2.ShowDialog();
                this.Close();
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "Quiz");
                VariaveisGlobais.Erros += 1;
                FrmP2 p2 = new FrmP2();
                p2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa!");
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
