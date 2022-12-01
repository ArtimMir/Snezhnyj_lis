using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Snezhnyj_lis
{
    
    public partial class Form2 : Form
    {
        public string t;
        public Form2()
        {
            //Form2 frm2 = new Form2();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            /*this.ForeColor = Color.Cornsilk;
            button1.BackColor = System.Drawing.Color.DimGray;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);*/
            StreamReader f = new StreamReader("input.txt");
            t = f.ReadLine();
            f.Close();
            if(t == "true")
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                this.ForeColor = Color.Cornsilk;
                button1.BackColor = System.Drawing.Color.DimGray;
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("mark.txt", true);
            f.Write(textBox1.Text + " " + textBox2.Text + " ");
            f.Close();
            Form5 newForm = new Form5();
            this.Hide();
            newForm.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = textBox2.Text.Length > 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length > 0;
        }
    }
}
