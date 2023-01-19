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
    public partial class dificil : Form
    {
        int cont;

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public dificil()
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

            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "16" && button17.Text == "17" && button18.Text == "18" && button19.Text == "19" && button20.Text == "20" && button21.Text == "21" && button22.Text == "22" && button23.Text == "23" && button24.Text == "24" && button25.Text == "25" && button26.Text == "26" && button27.Text == "27" && button28.Text == "28" && button29.Text == "29" && button30.Text == "30" && button31.Text == "31" && button32.Text == "32" && button33.Text == "33" && button34.Text == "34" && button35.Text == "35" && button36.Text == "")
            {
                MessageBox.Show("Muito Bem! Você ganhou o Jogo", "Jogo dos Numeros - Difícil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cont = cont + 1;
            label2.Text = "Numero de Clicks:" + cont;
        }

        public void Embaralhar()
        {

            int[] buttnum = new int[36];
            int linha, coluna, verificalinha;
            Boolean flag = false;

            linha = 1;

            do
            {
                Random rnd = new Random();

                verificalinha = Convert.ToInt32((rnd.Next(0, 35)) + 1);

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

            } while (linha <= 35);

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
            button25.Text = Convert.ToString(buttnum[25]);
            button26.Text = Convert.ToString(buttnum[26]);
            button27.Text = Convert.ToString(buttnum[27]);
            button28.Text = Convert.ToString(buttnum[28]);
            button29.Text = Convert.ToString(buttnum[29]);
            button30.Text = Convert.ToString(buttnum[30]);
            button31.Text = Convert.ToString(buttnum[31]);
            button32.Text = Convert.ToString(buttnum[32]);
            button33.Text = Convert.ToString(buttnum[33]);
            button34.Text = Convert.ToString(buttnum[34]);
            button35.Text = Convert.ToString(buttnum[35]);
            button36.Text = "";

        }


        private void dificil_Load(object sender, EventArgs e)
        {
            Embaralhar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            button25.Text = Convert.ToString(25);
            button26.Text = Convert.ToString(26);
            button27.Text = Convert.ToString(27);
            button28.Text = Convert.ToString(28);
            button29.Text = Convert.ToString(29);
            button30.Text = Convert.ToString(30);
            button31.Text = Convert.ToString(31);
            button32.Text = Convert.ToString(32);
            button33.Text = Convert.ToString(33);
            button34.Text = Convert.ToString(34);
            button35.Text = Convert.ToString(35);
            button36.Text = "";

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja voltar a tela inicial?", "Jogo dos Números - Difícil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Sair == DialogResult.Yes)
            {
                this.Close();
                var menu = new Form1();
                menu.Show();
                player.controls.stop();
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            //2,7

            VVazio(button1, button2);
            VVazio(button1, button7);
            Verificar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1,3 e 8

            VVazio(button2, button1);
            VVazio(button2, button3);
            VVazio(button2, button8);
            Verificar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2,4 e 9

            VVazio(button3, button2);
            VVazio(button3, button4);
            VVazio(button3, button9);
            Verificar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //3,5 e 10

            VVazio(button4, button3);
            VVazio(button4, button5);
            VVazio(button4, button10);
            Verificar();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //4,6 e 11

            VVazio(button5, button4);
            VVazio(button5, button6);
            VVazio(button5, button11);
            Verificar();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            //5 e 12
            VVazio(button6, button5);
            VVazio(button6, button12);
            Verificar();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            //1,8 e 13
            VVazio(button7, button1);
            VVazio(button7, button8);
            VVazio(button7, button13);
            Verificar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //2,7,9 e 14

            VVazio(button8, button2);
            VVazio(button8, button7);
            VVazio(button8, button9);
            VVazio(button8, button14);
            Verificar();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //3,8,10 e 15

            VVazio(button9, button3);
            VVazio(button9, button8);
            VVazio(button9, button10);
            VVazio(button9, button15);
            Verificar();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //4,9, 11 e 16

            VVazio(button10, button4);
            VVazio(button10, button9);
            VVazio(button10, button11);
            VVazio(button10, button16);
            Verificar();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //5,10,12 e 17

            VVazio(button11, button5);
            VVazio(button11, button10);
            VVazio(button11, button12); 
            VVazio(button11, button17);
            Verificar();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //6,11 e 18

            VVazio(button12, button6);
            VVazio(button12, button11);
            VVazio(button12, button18);
            Verificar();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //7,14 e 19

            VVazio(button13, button7);
            VVazio(button13, button14);
            VVazio(button13, button19);
            Verificar();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //8,13,15 e 20

            VVazio(button14, button8);
            VVazio(button14, button13);
            VVazio(button14, button15);
            VVazio(button14, button20);
            Verificar();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //9,14,16 e 21
            VVazio(button15, button9);
            VVazio(button15, button14); 
            VVazio(button15, button16);
            VVazio(button15, button21);
            Verificar();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //10,15,17 e 22

            VVazio(button16, button10);
            VVazio(button16, button15);
            VVazio(button16, button17);
            VVazio(button16, button22);
            Verificar();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //11,16,18 e 23

            VVazio(button17, button11);
            VVazio(button17, button16);
            VVazio(button17, button18);
            VVazio(button17, button23);
            Verificar();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //12,17 e 24

            VVazio(button18, button12);
            VVazio(button18, button17);
            VVazio(button18, button24);
            Verificar();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //13,20 e 25

            VVazio(button19, button13);
            VVazio(button19, button20);
            VVazio(button19, button25);
            Verificar();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //14,19,21 e 26

            VVazio(button20, button14);
            VVazio(button20, button19); 
            VVazio(button20, button21);
            VVazio(button20, button26);
            Verificar();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //15,20,22 e 27

            VVazio(button21, button15);
            VVazio(button21, button20);
            VVazio(button21, button22);
            VVazio(button21, button27);
            Verificar();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //16,21,23 e 28

            VVazio(button22, button16);
            VVazio(button22, button21);
            VVazio(button22, button23);
            VVazio(button22, button28);
            Verificar();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //17,22,24 e 29

            VVazio(button23, button17);
            VVazio(button23, button22);
            VVazio(button23, button24);
            VVazio(button23, button29);
            Verificar();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //18, 23 e 30

            VVazio(button24, button18);
            VVazio(button24, button23);
            VVazio(button24, button30);
            Verificar();


        }

        private void button25_Click(object sender, EventArgs e)
        {
            //19,26 e 31
            VVazio(button25, button19);
            VVazio(button25, button26);
            VVazio(button25, button31);
            Verificar();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //20, 25, 27 e 32
            VVazio(button26, button20);
            VVazio(button26, button25);
            VVazio(button26, button27); 
            VVazio(button26, button32);
            Verificar();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //21,26,28 e 33

            VVazio(button27, button21);
            VVazio(button27, button26);
            VVazio(button27, button28);
            VVazio(button27, button33);
            Verificar();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            //22,27,29 e 34

            VVazio(button28, button22);
            VVazio(button28, button27);
            VVazio(button28, button29);
            VVazio(button28, button34);
            Verificar();

        }

        private void button29_Click(object sender, EventArgs e)
        {
            //23,28,30 e 35

            VVazio(button29, button23);
            VVazio(button29, button27);
            VVazio(button29, button28);
            VVazio(button29, button35);
            Verificar();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            //24,29 e 36
            VVazio(button30, button24);
            VVazio(button30, button29);
            VVazio(button30, button36);
            Verificar();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //25 e 32

            VVazio(button31, button25);
            VVazio(button31, button32);
            Verificar();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            //26,31 e 33
            VVazio(button32, button26);
            VVazio(button32, button31);
            VVazio(button32, button33);
            Verificar();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //27, 32 e 34
            VVazio(button33, button27);
            VVazio(button33, button32);
            VVazio(button33, button34);
            Verificar();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //28,33 e 35
            VVazio(button34, button28);
            VVazio(button34, button33);
            VVazio(button34, button35);
            Verificar();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //29, 34 e 36
            VVazio(button35, button29);
            VVazio(button35, button34);
            VVazio(button35, button36);
            Verificar();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //30 e 35
            VVazio(button36, button30);
            VVazio(button36, button35);
            Verificar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            player.controls.pause();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

            player.controls.play();
        }
    }
}
