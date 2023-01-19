using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GabrielAraujo___Numeros
{
    public partial class facil : Form
    {
        int cont;

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public facil()
        {
            InitializeComponent();
            player.URL = "Lofi.mp3";
        }

        public void VVazio(Button button1, Button button2)
        {

            if(button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }

        }

        public void Verificar()
        {
            
            if(button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "")
            {
                MessageBox.Show("Muito Bem! Você ganhou o Jogo", "Jogo dos Numeros - Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cont = cont + 1;
            label2.Text = "Numero de Clicks:" + cont;
        }

        public void Embaralhar()
        {

            int[] buttnum = new int[16];
            int linha, coluna, verificalinha;
            Boolean flag = false;

            linha = 1;

            do
            {
                Random rnd = new Random();

                verificalinha = Convert.ToInt32((rnd.Next(0, 15)) + 1);

                for(coluna = 1; coluna <= linha; coluna++)
                {
                    if(buttnum[coluna] == verificalinha)
                    {
                        flag = true;
                        break;
                    }
                }
                
                if(flag == true)
                {
                    flag = false;
                }
                else
                {
                    buttnum[linha] = verificalinha;
                    linha++;
                }

            } while (linha <= 15);

            button1.Text = Convert.ToString(buttnum[1]);
            button2.Text = Convert.ToString(buttnum[2]);
            button3.Text = Convert.ToString(buttnum[3]);
            button4.Text = Convert.ToString(buttnum[4]);
            button5.Text = Convert.ToString(buttnum[5]);
            button6.Text = Convert.ToString(buttnum[6]);
            button7.Text = Convert.ToString(buttnum[7]);
            button8.Text = Convert.ToString(buttnum[8]);
            button9.Text = Convert.ToString(buttnum[9]);
            button10.Text = Convert.ToString(buttnum[10]);
            button11.Text = Convert.ToString(buttnum[11]);
            button12.Text = Convert.ToString(buttnum[12]);
            button13.Text = Convert.ToString(buttnum[13]);
            button14.Text = Convert.ToString(buttnum[14]);
            button15.Text = Convert.ToString(buttnum[15]);
            button16.Text = "";
        }
        private void facil_Load(object sender, EventArgs e)
        {
            Embaralhar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //2 e 5

            VVazio(button1, button2);
            VVazio(button1, button5);
            Verificar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1, 3 e 6

            VVazio(button2, button1);
            VVazio(button2, button3);
            VVazio(button2, button6);
            Verificar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2, 4 e 7

            VVazio(button3, button2);
            VVazio(button3, button4);
            VVazio(button3, button7);
            Verificar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3 e 8

            VVazio(button4, button3);
            VVazio(button4, button8);
            Verificar();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //1, 6 e 9

            VVazio(button5, button1);
            VVazio(button5, button6);
            VVazio(button5, button9);
            Verificar();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //2, 5, 7, e 10

            VVazio(button6, button2);
            VVazio(button6, button5);
            VVazio(button6, button7);
            VVazio(button6, button10);
            Verificar();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //3, 6, 8 e 11

            VVazio(button7, button3);
            VVazio(button7, button6);
            VVazio(button7, button8);
            VVazio(button7, button11);
            Verificar();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //4, 7 e 12

            VVazio(button8, button4);
            VVazio(button8, button7);
            VVazio(button8, button12);
            Verificar();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //5, 10 e 13

            VVazio(button9, button5);
            VVazio(button9, button10);
            VVazio(button9, button13);
            Verificar();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //6, 9, 11, 14

            VVazio(button10, button6);
            VVazio(button10, button9);
            VVazio(button10, button11);
            VVazio(button10, button14);
            Verificar();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //7, 10, 12 e 15

            VVazio(button11, button7);
            VVazio(button11, button10);
            VVazio(button11, button12);
            VVazio(button11, button15);
            Verificar();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //8, 11 e 16

            VVazio(button12, button8);
            VVazio(button12, button11);
            VVazio(button12, button16);
            Verificar();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //9 e 14

            VVazio(button13, button9);
            VVazio(button13, button14);
            Verificar();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //10, 13, 15

            VVazio(button14, button10);
            VVazio(button14, button13);
            VVazio(button14, button15);
            Verificar();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //11, 14 e 16

            VVazio(button15, button11);
            VVazio(button15, button14);
            VVazio(button15, button16);
            Verificar();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //12 e 15

            VVazio(button16, button12);
            VVazio(button16, button15);
            Verificar();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult voltar = MessageBox.Show("Deseja voltar a tela inicial?", "Jogo dos Numeros - Fácil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (voltar == DialogResult.Yes)
            {
                this.Close();
                var Menu = new Form1();
                Menu.Show();
                player.controls.stop();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1); 
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cont = 0;
            Embaralhar();
            label2.Text = "Numero de Clicks:";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Embaralhar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            
            player.controls.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            player.controls.pause();
        }
    }
}
