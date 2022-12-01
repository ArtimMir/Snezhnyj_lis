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
    public partial class Form6 : Form
    {
        public string t;
        public string i;
        public string bar;
        public string s;
        public string s1;
        public string[] str;
        public double per;
        public Form6()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
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
            StreamReader f1 = new StreamReader("for_mark.txt");
            i = f1.ReadLine();
            label3.Text = i;
            f1.Close();
            StreamReader f2 = new StreamReader("points.txt");
            label7.Text = f2.ReadLine();
            f2.Close();
            per = (Convert.ToDouble(i) / 20.0)*100;
            
            Math.Round(per, 1);
            label5.Text = Convert.ToString(per);
            Console.WriteLine(Convert.ToInt32(per));
            progressBar1.Value = Convert.ToInt32(per);
        }
        
        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);
            //Form1 newForm = new Form1();
            //newForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter f2 = new StreamWriter("for_mark.txt", false);
            f2.Write("");
            f2.Close();
            StreamWriter f3 = new StreamWriter("points.txt", false);
            f3.Write("");
            f3.Close();
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
        }
    }
}
