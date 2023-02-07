using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            string correta = "palavra";
            string digitada = textBox1.Text;

            if (correta.Equals(digitada, StringComparison.OrdinalIgnoreCase))
            {
                // É a palavra certa - permitir que o usuário continue
            }
            else
            {
                // Não é a palavra certa - avisar o usuário
            }
            string cor = textBox1.Text;

                switch (cor)
                {
                    case "vermelho":
                        btnEnviar.BackColor = Color.Red;
                        break;
                    case "laranja":
                        btnEnviar.BackColor = Color.Orange;
                        break;
                    case "amarelo":
                        btnEnviar.BackColor = Color.Yellow;
                        break;
                    case "verde":
                        btnEnviar.BackColor = Color.Green;
                        break;
                    case "azul":
                        btnEnviar.BackColor = Color.Blue;
                        break;
                    case "roxo":
                        btnEnviar.BackColor = Color.Purple;
                        break;
                    case "preto":
                        btnEnviar.BackColor = Color.Black;
                        break;

                    default:
                        btnEnviar.BackColor = Color.White;
                        break;
                
            }

        }


            }

        }
    



        
    



