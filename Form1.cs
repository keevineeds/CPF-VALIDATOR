using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static validar obj_validar;

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            string cpf = txt_visor.Text;
            obj_validar = new validar(cpf, "");
            string va;
            if(obj_validar.ValidarCPF() == true)
            {
                va = "O CPF " + obj_validar.getCPF() + " É VÁLIDO!";
            }
            else
            {
                va = "O CPF " + obj_validar.getCPF() + " É INVÁLIDO!"; ;
            }
            MessageBox.Show(va);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
