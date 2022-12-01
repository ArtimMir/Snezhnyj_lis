using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snezhnyj_lis
{
    public class Student
    {
        public string Name, Surname;
        public int Points, Mark;
        public Student(string Surname, string Name, int Points, int Mark)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Points = Points;
            this.Mark = Mark;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
