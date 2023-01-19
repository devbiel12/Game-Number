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
    public partial class medio : Form
    {
        int cont;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public medio()
        {
            InitializeComponent();
            player.URL = "Lofi.mp3";
        }
        public void VVazio(Button button1, Button button2)
        {

            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }

        }

        public void Verificar()
        {

            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "16" && button17.Text == "17" && button18.Text == "18" && button19.Text == "19" && button20.Text == "20" && button21.Text == "21" && button22.Text == "22" && button23.Text == "23" && button24.Text == "24" && button25.Text == "")
            {
                MessageBox.Show("Muito Bem! Você ganhou o Jogo", "Jogo dos Numeros - Médio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cont = cont + 1;
            label2.Text = "Numero de Clicks:" + cont;
        }

        public void Embaralhar()
        {

            int[] buttnum = new int[25];
            int linha, coluna, verificalinha;
            Boolean flag = false;

            linha = 1;

            do
            {
                Random rnd = new Random();

                verificalinha = Convert.ToInt32((rnd.Next(0, 24)) + 1);

                for (coluna = 1; coluna <= linha; coluna++)
                {
                    if (buttnum[coluna] == verificalinha)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    buttnum[linha] = verificalinha;
                    linha++;
                }

            } while (linha <= 24);

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
            button16.Text = Convert.ToString(buttnum[16]);
            button17.Text = Convert.ToString(buttnum[17]);
            button18.Text = Convert.ToString(buttnum[18]);
            button19.Text = Convert.ToString(buttnum[19]);
            button20.Text = Convert.ToString(buttnum[20]);
            button21.Text = Convert.ToString(buttnum[21]);
            button22.Text = Convert.ToString(buttnum[22]);
            button23.Text = Convert.ToString(buttnum[23]);
            button24.Text = Convert.ToString(buttnum[24]);
            button25.Text = "";
        
        }
        private void medio_Load(object sender, EventArgs e)
        {
            Embaralhar();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult voltar = MessageBox.Show("Deseja voltar a tela inicial?", "Jogo dos Numeros - Médio", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
            button16.Text = Convert.ToString(16);
            button17.Text = Convert.ToString(17);
            button18.Text = Convert.ToString(18);
            button19.Text = Convert.ToString(19);
            button20.Text = Convert.ToString(20);
            button21.Text = Convert.ToString(21);
            button22.Text = Convert.ToString(22);
            button23.Text = Convert.ToString(23);
            button24.Text = Convert.ToString(24);
            button25.Text = "";
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Embaralhar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cont = 0;
            Embaralhar();
            label2.Text = "Numero de Clicks:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //2 e 6


            VVazio(button1, button2);
            VVazio(button1, button6);
            Verificar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1,3 e 7

            VVazio(button2, button1);
            VVazio(button2, button3);
            VVazio(button2, button7);
            Verificar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2,4 e 8
            VVazio(button3, button2);
            VVazio(button3, button4);
            VVazio(button3, button8);
            Verificar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3,5 e 9

            VVazio(button4, button3);
            VVazio(button4, button5);
            VVazio(button4, button9);
            Verificar();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //4 e 10 

            VVazio(button5, button4);
            VVazio(button5, button10);
            Verificar();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //1,7, 11

            VVazio(button6, button1);
            VVazio(button6, button7);
            VVazio(button6, button11);
            Verificar();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //2,6,8 e 12

            VVazio(button7, button2);
            VVazio(button7, button6);
            VVazio(button7, button8); 
            VVazio(button7, button12);
            Verificar();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //3,7,9 e 13

            VVazio(button8, button3);
            VVazio(button8, button7);
            VVazio(button8, button9);
            VVazio(button8, button13);
            Verificar();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //4,8,10 e 14

            VVazio(button9, button4);
            VVazio(button9, button8);
            VVazio(button9, button10);
            VVazio(button9, button14);
            Verificar();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //5,9,15

            VVazio(button10, button5);
            VVazio(button10, button9);
            VVazio(button10, button15);
            Verificar();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //6,12 e 16

            VVazio(button11, button6);
            VVazio(button11, button12);
            VVazio(button11, button16);
            Verificar();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //7,11,13 e 17

            VVazio(button12, button7);
            VVazio(button12, button11);
            VVazio(button12, button13);
            VVazio(button12, button17);
            Verificar();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //8,12,14 e 18

            VVazio(button13, button8);
            VVazio(button13, button12);
            VVazio(button13, button14);
            VVazio(button13, button18);
            Verificar();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //9,13,15 e 19

            VVazio(button14, button9);
            VVazio(button14, button13);
            VVazio(button14, button15);
            VVazio(button14, button19);
            Verificar();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //10,14 e 20

            VVazio(button15, button10);
            VVazio(button15, button14);
            VVazio(button15, button20);
            Verificar();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //11,17 e 21

            VVazio(button16, button11);
            VVazio(button16, button17);
            VVazio(button16, button21);
            Verificar();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //12,16,18 e 22

            VVazio(button17, button12);
            VVazio(button17, button16);
            VVazio(button17, button18);
            VVazio(button17, button22);
            Verificar();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //13,17,19 e 23

            VVazio(button18, button13);
            VVazio(button18, button17);
            VVazio(button18, button19);
            VVazio(button18, button23);
            Verificar();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //14,18,20 e 24

            VVazio(button19, button14);
            VVazio(button19, button18);
            VVazio(button19, button20);
            VVazio(button19, button24);
            Verificar();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //15, 19 e 25

            VVazio(button20, button15);
            VVazio(button20, button19);
            VVazio(button20, button25);
            Verificar();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //16 e 22

            VVazio(button21, button16);
            VVazio(button21, button22);
            Verificar();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //17, 21 e 23

            VVazio(button22, button17);
            VVazio(button22, button21); 
            VVazio(button22, button23);
            Verificar();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //18, 22 e 24

            VVazio(button23, button18);
            VVazio(button23, button22);
            VVazio(button23, button24);
            Verificar();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            //19,23 e 25

            VVazio(button24, button19);
            VVazio(button24, button23);
            VVazio(button24, button25);
            Verificar();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            //20 e 24

            VVazio(button25, button20);
            VVazio(button25, button24);
            Verificar();

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
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
