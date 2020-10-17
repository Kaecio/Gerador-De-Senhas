using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenhas
{
    public partial class Form1 : Form
    {
        int password_num = 20;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";

            if (checkMaiuscula.Checked)
            {
                alfabeto += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (checkAlgarismo.Checked)
            {
                alfabeto += "0123456789";
            }
            else if (checkSimbolos.Checked)
            {
                alfabeto += "!@#$%&*+";
            }
            Lista_senhas.Items.Clear();

            Random gerarNum = new Random();
            for (int g = 1; g < password_num ; g++)
            {
                StringBuilder str = new StringBuilder();
                for (int i = 1; i <= count_chars.Value; i++)
                {
                    int posicao = gerarNum.Next(0, alfabeto.Length);
                    str.Append(alfabeto[posicao].ToString());

                }
                Lista_senhas.Items.Add(str.ToString());
            }

            
         }

        
    }
}
