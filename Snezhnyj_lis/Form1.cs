using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Snezhnyj_lis
{
    public partial class Form1 : Form
    {
        public string t = "false";
        public Form1()
        {
            //Form1 frm1 = new Form1();
            //Point point = new Point(10500, 150);
            StartPosition = FormStartPosition.CenterScreen;

            //frm1.Location = point;
            InitializeComponent();
            StreamReader f = new StreamReader("input.txt");
            t = f.ReadLine();
            f.Close();
            if (t == "true")
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                this.ForeColor = Color.Cornsilk;
                button1.BackColor = System.Drawing.Color.DimGray;
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                button2.BackColor = System.Drawing.Color.DimGray;
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                button3.BackColor = System.Drawing.Color.DimGray;
                button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                button4.BackColor = System.Drawing.Color.DimGray;
                button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
            }
            StreamWriter f1 = new StreamWriter("for_mark.txt", false);
            f1.Write("");
            f1.Close();
            StreamWriter f3 = new StreamWriter("points.txt", false);
            f3.Write("");
            f3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Owner = this;
            this.Hide();
            newForm.Show();
            FormCollection F = Application.OpenForms;
            StreamReader f = new StreamReader("input.txt");
            t = f.ReadLine();
            f.Close();
            /*if (t == "true")
            {
                newForm.BackColor = Color.FromArgb(50, 50, 50);
                newForm.ForeColor = Color.Cornsilk;
                //newForm.button1.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
                //newForm.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                //newForm.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            }*/        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (t == "false")
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                this.ForeColor = Color.Cornsilk;
                button1.BackColor = System.Drawing.Color.DimGray;
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                button2.BackColor = System.Drawing.Color.DimGray;
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                button3.BackColor = System.Drawing.Color.DimGray;
                button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                button4.BackColor = System.Drawing.Color.DimGray;
                button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                t = "true";
                StreamWriter sw = new StreamWriter("input.txt", false);
                sw.WriteLine("true");
                sw.Close();
            }
            else 
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
                this.ForeColor = Color.Black;
                button1.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
                button2.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
                button3.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
                button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
                button4.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
                button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
                t = "false";
                StreamWriter sw = new StreamWriter("input.txt", false);
                sw.WriteLine("false");
                sw.Close();
            }
        }
    }
}
