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

namespace Snezhnyj_lis
{
    public partial class Form3 : Form
    {
        public string t;
        public int count;
        public string line;
        public Form3()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            StreamReader f = new StreamReader("input.txt");
            t = f.ReadLine();
            f.Close();
            if (t == "true")
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                this.ForeColor = Color.Cornsilk;
            }
            StreamReader f1 = new StreamReader("mark.txt");
            while ((line = f1.ReadLine()) != null)
            {
                count++;
            }
            f1.Close();
            //Console.WriteLine(count);
            Student[] St = new Student[count];
            int i = 0;
            StreamReader f2 = new StreamReader("mark.txt");
            string s;
            while ((s = f2.ReadLine()) != null)
            {

                Console.WriteLine(s);
                St[i] = new Student(s.Split(' ')[0], s.Split(' ')[1], int.Parse(s.Split(' ')[2]), int.Parse(s.Split(' ')[3]));
                i++;
            }
            f2.Close();

            //label5.Text = String.Format("{0,-20} {1,-10} {2,6} {3,10}", "Петранцов", "Даниил", 18, 5);
            for (int j = 0; j < count; j++)
            {
                label5.Text += (St[j].Surname + "\n");
                label6.Text += (St[j].Name + "\n");
                label7.Text += (St[j].Points + "\n");
                label8.Text += (St[j].Mark + "\n");
            }


        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
