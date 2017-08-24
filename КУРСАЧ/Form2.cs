using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace КУРСАЧ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Fam
        {
            get
            {
                return textBox1.Text;
            }
        }

        public string Nam
        {
            get
            {
                return textBox2.Text;
            }
        }

        public string Otch
        {
            get
            {
                return textBox3.Text;
            }
        }

        public string Znak
        {
            get
            {
                return comboBox1.Text;
            }
        }

        public string Year
        {
            get
            {
                return comboBox2.Text;
            }
        }

        public string DR
        {
            get
            {
                DateTime dt = monthCalendar1.SelectionStart;
                return dt.Day + "." + dt.Month + "." + dt.Year;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Visible = false;
        }

        private void впередToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Visible = false;
        }

        private void Начать_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Visible = false;
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form2 dialog = new Form2();
                if (DialogResult.Yes == dialog.ShowDialog())
                {
                    string body = "Данные регистрации:";

                    body += " Фамилия:" + dialog.Fam;
                    body += ", Имя:" + dialog.Nam;
                    body += ", Отчество:" + dialog.Otch;
                    body += ", Знак зодиака:" + dialog.Znak;
                    body += ", Год восточный:" + dialog.Year;
                    body += ", День рождения:" + dialog.DR;

                }


            }
        }
    }
}
