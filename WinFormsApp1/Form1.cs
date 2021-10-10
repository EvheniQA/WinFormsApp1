using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string[,] clientLogin;

        public Form1()
        {
            InitializeComponent();
            clientLogin = new string[5, 2]
            {
                {"client1", "password1"},
                {"client2", "password2"},
                {"client3", "password3"},
                {"client4", "password4"},
                {"client5", "password5"}
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = clientLogin.GetUpperBound(0) + 1;
            int colums = clientLogin.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (clientLogin[i, 0] == textBox1.Text.ToLower() && clientLogin[i, j] == textBox1.Text) 
                    {
                        MessageBox.Show("Access Login\n\nHello " + clientLogin[i, 0]);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Access is denied");
                        return;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
