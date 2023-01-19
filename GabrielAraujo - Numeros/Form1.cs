using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabrielAraujo___Numeros
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CancelButton = button4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Confirme se deseja sair", "Jogo dos Números", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Sair == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Facil = new facil();
            Facil.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Medio = new medio();
            Medio.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Dificil = new dificil();
            Dificil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
