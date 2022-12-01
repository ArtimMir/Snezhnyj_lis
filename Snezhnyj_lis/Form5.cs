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
    public partial class Form5 : Form
    {
        public string t;
        public int i = 0;
        public Form5()
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
                button1.BackColor = System.Drawing.Color.DimGray;
                button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
                button2.BackColor = System.Drawing.Color.DimGray;
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            List<string> lines = File.ReadAllLines("mark.txt").ToList();
            File.WriteAllLines("mark.txt", lines.GetRange(0, lines.Count - 1).ToArray());
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "71")
            {
                i++;
            }

            StreamWriter f1 = new StreamWriter("for_mark.txt", true);
            f1.Write(i);
            f1.Close();
            StreamWriter f2 = new StreamWriter("points.txt", true);
            
            StreamWriter f = new StreamWriter("mark.txt", true);
            f.Write(i);
            f.Write(" ");
            if (i < 8.2)
            {
                f.Write("2");
                f2.Write("2");
            }
            else if ((i >= 8.2) && (i < 12.2))
            {
                f.Write("3");
                f2.Write("3");
            }
            else if ((i >= 12.2) && (i < 16.2))
            {
                f.Write("4");
                f2.Write("4");
            }
            else if (i >= 16.2)
            {
                f.Write("5");
                f2.Write("5");
            }
            f.WriteLine("");
            f.Close();
            f2.Close();
            
            Console.WriteLine(i);
            Form6 newForm = new Form6();
            this.Hide();
            newForm.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = label2.Text;
            switch (num)
            {
                case "1":
                    label2.Text = "2";
                    label3.Text = "После отключения компьютера все информация стирается...";
                    radioButton1.Text = "из оперативной памяти";
                    radioButton2.Text = "с жесткого диска";
                    radioButton3.Text = "с гибкого диска";
                    if(radioButton2.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton2.Location = new Point(54, 154);
                    radioButton3.Location = new Point(54, 200);
                    break;
                case "2":
                    label2.Text = "3";
                    label3.Text = "Компьютер - это";
                    radioButton1.Text = "электронно-вычислительное устройство для работы с числами";
                    radioButton2.Text = "комплекс программно - аппаратных средств, предназначенных для \nвыполнения информационных процессов";
                    radioButton3.Text = "устройство для обработки аналоговых сигналов";
                    if (radioButton3.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton3.Location = new Point(54, 225);
                    break;
                case "3":
                    label2.Text = "4";
                    label3.Text = "Электронная таблица - это";
                    radioButton1.Text = "прикладная программа, предназначенная для обработки структурированных \nв виде таблицы данных";
                    radioButton2.Text = "устройство ПК, управляющее его ресурсами в процессе обработки данных \nв табличной форме";
                    radioButton3.Text = "системная программа, управляющая ресурсами ПК при обработке таблиц";
                    if (radioButton2.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton2.Location = new Point(54, 169);
                    radioButton3.Location = new Point(54, 235);
                    break;
                case "4":
                    label2.Text = "5";
                    label3.Text = "В какой из последовательностей единицы измерения указаны в \nпорядке возрастания?";
                    radioButton1.Text = "мегабайт, килобайт, байт, гигабайт";
                    radioButton2.Text = "байт, килобайт, мегабайт, гигабайт";
                    radioButton3.Text = "гигабайт, мегабайт, килобайт, байт";
                    if (radioButton1.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton1.Location = new Point(54, 135);
                    radioButton2.Location = new Point(54, 194);
                    radioButton3.Location = new Point(54, 260);
                    break;
                case "5":
                    label2.Text = "6";
                    label3.Text = "В электронной таблице в ячейке А1 записано число 5, в В1 — \nформула =А1*2, в С1 — формула =А1+В1. В ячейке С1 содержится \nзначение:";
                    radioButton1.Text = "10";
                    radioButton2.Text = "20";
                    radioButton3.Text = "15";
                    if (radioButton2.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton1.Location = new Point(54, 165);
                    radioButton2.Location = new Point(54, 224);
                    radioButton3.Location = new Point(54, 290);
                    break;
                case "6":
                    label2.Text = "7";
                    label3.Text = "Группа компьютеров, связанных каналами передачи информации и \nнаходящихся в пределах территории, ограниченной небольшими \nразмерами: комнаты, здания, предприятия, называется:";
                    radioButton1.Text = "глобальной компьютерной сетью";
                    radioButton2.Text = "электронной почтой";
                    radioButton3.Text = "локальной компьютерной сетью";
                    if (radioButton3.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case "7":
                    label2.Text = "8";
                    label3.Text = "Назовите устройства, входящие в состав процессора";
                    radioButton1.Text = "арифметико-логическое устройство, устройство управления";
                    radioButton2.Text = "ПЗУ, видеопамять";
                    radioButton3.Text = "видеокарта, контроллеры";
                    if (radioButton3.Checked)
                    {
                        i++;
                    }
                    radioButton1.Location = new Point(54, 120);
                    radioButton2.Location = new Point(54, 179);
                    radioButton3.Location = new Point(54, 245);
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case "8":
                    label2.Text = "9";
                    label3.Text = "Оперативная память имеет следующую структуру:";
                    radioButton1.Text = "разбита на сектора и дорожки, информация записана в виде намагниченных и \nне намагниченных областей";
                    radioButton2.Text = "разбита на кластеры, информация записана в виде намагниченных и не \nнамагниченных областей";
                    radioButton3.Text = "состоит из ячеек, каждая ячейка имеет адрес и содержание";
                    if (radioButton1.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case "9":
                    label2.Text = "10";
                    label3.Text = "Постоянное запоминающее устройство служит для:";
                    radioButton1.Text = "хранения программ начальной загрузки компьютера и тестирования его узлов";
                    radioButton2.Text = "хранения программы пользователя во время его работы";
                    radioButton3.Text = "записи особо ценных прикладных программ";
                    if (radioButton3.Checked)
                    {
                        i++;
                    }
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case "10":
                    radioButton1.Visible = false; radioButton2.Visible = false; radioButton3.Visible = false;
                    label2.Text = "11";
                    label3.Text = "Устройствами внешней памяти являются:";
                    checkBox1.Text = "накопители на гибких магнитных дисках";
                    checkBox2.Text = "оперативные запоминающие устройства";
                    checkBox3.Text = "накопители на жестких магнитных дисках"; 
                    checkBox4.Text = "стриммеры";
                    checkBox5.Text = "плоттеры";
                    checkBox1.Visible = true; checkBox2.Visible = true; checkBox3.Visible = true; checkBox4.Visible = true; checkBox5.Visible = true;
                    if (radioButton1.Checked)
                    {
                        i++;
                    }
                    break;
                case "11":
                    label2.Text = "12";
                    label3.Text = "В зависимости от типа носителя накопители подразделяются на:";
                    checkBox1.Text = "сменные носители";
                    checkBox2.Text = "несменные носители";
                    checkBox3.Text = "КЭШ-носители";
                    checkBox4.Text = "кассетные носители";
                    checkBox5.Visible = false;
                    if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked)
                    {
                        i++;
                    }
                    checkBox1.Checked = false;checkBox2.Checked = false;checkBox3.Checked = false;checkBox4.Checked = false;checkBox5.Checked = false;
                    break;
                case "12":
                    label2.Text = "13";
                    label3.Text = "К устройствам ввода информации относятся:";
                    checkBox1.Text = "клавиатура";
                    checkBox2.Text = "диджитайзер";
                    checkBox3.Text = "мышь";
                    checkBox4.Text = "джойстик";
                    checkBox5.Text = "графопостроитель";
                    checkBox6.Text = "сетевой адаптер"; 
                    checkBox7.Text = "сенсорный экран";
                    checkBox5.Visible = true; checkBox6.Visible = true; checkBox7.Visible = true;
                    if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked && checkBox4.Checked )
                    {
                        i++;
                    }
                    checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false;
                    break;
                case "13":
                    label2.Text = "14";
                    label3.Text = "К манипуляторам (устройствам указания) относятся:";
                    checkBox1.Text = "джойстик";
                    checkBox2.Text = "мышь";
                    checkBox3.Text = "клавиатура";
                    checkBox4.Text = "сканер";
                    checkBox5.Text = "трекбол";
                    checkBox6.Text = "планшет";
                    checkBox7.Text = "сетевое перо";
                    if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked && checkBox7.Checked)
                    {
                        i++;
                    }
                    checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox5.Checked = false; checkBox6.Checked = false; checkBox7.Checked = false;
                    break;
                case "14":
                    label2.Text = "15";
                    label3.Text = "Системный блок включает в себя:";
                    checkBox1.Text = "системную плату";
                    checkBox2.Text = "блок питания";
                    checkBox3.Text = "модулятор-демодулятор";
                    checkBox4.Text = "накопители на дисках";
                    checkBox5.Text = "платы расширений";
                    checkBox6.Text = "средства связи и коммуникаций";
                    checkBox7.Visible = false;
                    if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && checkBox6.Checked && checkBox7.Checked)
                    {
                        i++;
                    }
                    checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox5.Checked = false; checkBox6.Checked = false; checkBox7.Checked = false;
                    break;
                case "15":
                    checkBox1.Visible = false; checkBox2.Visible = false; checkBox3.Visible = false; checkBox4.Visible = false; checkBox5.Visible = false; checkBox6.Visible = false; checkBox7.Visible = false;
                    textBox1.Visible = true;
                    label2.Text = "16";
                    label3.Text = "Напишите наименьшее натуральное трёхзначное число, для которого \nИСТИННО высказывание:\nНЕ (Число нечётное) И (Число кратно 3)";
                    if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && !checkBox6.Checked)
                    {
                        i++;
                    }
                    checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox5.Checked = false; checkBox6.Checked = false; checkBox7.Checked = false;
                    break;
                case "16":
                    label2.Text = "17";
                    label3.Text = "Доступ к файлу net.txt, находящемуся на сервере html.ru, \nосуществляется по протоколу http.\nВ таблице фрагменты адреса файла закодированы цифрами от 1 до 7.\nЗапишите последовательность цифр, кодирующую адрес указанного \nфайла в сети Интернет.\n1) .ru\n2) ://\n3) html\n4) net\n5) /\n6) http\n7) .txt";
                    label3.Font = new Font("Comic Sans MS", 10);
                    if (textBox1.Text == "102")
                    {
                        i++;
                    }
                    textBox1.Text = "";
                    textBox1.Location = new Point(54, 305);
                    break;
                case "17":
                    label2.Text = "18";
                    label3.Text = "Переведите двоичное число 1110110 в десятичную систему \nсчисления";
                    label3.Font = new Font("Comic Sans MS", 16);
                    if (textBox1.Text == "6231547")
                    {
                        i++;
                    }
                    textBox1.Text = "";
                    textBox1.Location = new Point(54, 142);
                    break;
                case "18":
                    label2.Text = "19";
                    label3.Text = "В таблице приведены запросы и количество страниц, которые нашел \nпоисковый сервер по этим запросам в некотором сегменте Интернета:\nЗапрос	                            Количество страниц(тыс.)\nфрегат & эсминец	             500\nфрегат | эсминец	           4500\nэсминец	                         2500\nСколько страниц (в тысячах) будет найдено по запросу фрегат?";
                    if (textBox1.Text == "118")
                    {
                        i++;
                    }
                    textBox1.Text = "";
                    textBox1.Location = new Point(54, 280);
                    break;
                case "19":
                    label2.Text = "20";
                    button1.Enabled = true;
                    button2.Enabled = false;
                    label3.Text = "Среди приведённых ниже трёх чисел, записанных в различных \nсистемах счисления, найдите максимальное и запишите его в ответе \nв десятичной системе счисления.\nВ ответе запишите только число, основание системы счисления \nуказывать не нужно.\n4116, 1078, 10000112.";
                    if (textBox1.Text == "2500")
                    {
                        i++;
                    }
                    textBox1.Text = "";
                    textBox1.Location = new Point(54, 280);
                    break;
                default:
                    break;
            }
        }
    }
}
