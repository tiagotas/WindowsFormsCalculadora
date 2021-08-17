using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculadora
{
    public partial class Form1 : Form
    {
        double memoria_pre_operacao;
        double memoria_pos_operacao;
        double resultado;

        string operacao_selecionada;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            txtVisor.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memoria_pre_operacao = Convert.ToDouble(txtVisor.Text);
            txtVisor.Text = "";
            operacao_selecionada = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            memoria_pos_operacao = Convert.ToDouble(txtVisor.Text);

            if (operacao_selecionada == "+")
                resultado = memoria_pre_operacao + memoria_pos_operacao;

            txtVisor.Text = resultado.ToString();

        }
    }
}
