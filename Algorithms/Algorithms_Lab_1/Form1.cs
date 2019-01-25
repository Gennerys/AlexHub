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

namespace Algorithms_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KeyValue[] person = new KeyValue[0];
        KeyValue[] per = new KeyValue[0];

        bool flag;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Быстрая_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            string path = @"Words.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = line.Split(new char[] { '\n', ' ' });
                        Array.Resize(ref person, person.Length + 1);
                        person[person.Length - 1].key = Convert.ToInt32(str[0]);
                        person[person.Length - 1].value = str[1];

                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int j = 0;
            foreach (KeyValue keyValue in person)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells[0].Value = keyValue.key.ToString();
                dataGridView1.Rows[j].Cells[1].Value = keyValue.value.ToString();
                j++;
            }
            flag = true;
            button1.Enabled = false;
        }

        private void Очистка_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void FillTable()
        {
            int j = 0;
            foreach (KeyValue keyValue in per)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[j].Cells[0].Value = keyValue.key.ToString();
                dataGridView2.Rows[j].Cells[1].Value = keyValue.value.ToString();
                j++;
            }
        }
        int kol = 0;
        private void Сорт_Click(object sender, EventArgs e)
        {

            if (Пузырёк.Checked)
            {
                int k = person.Length;
                Array.Resize(ref per, k);
                Array.Copy(person, per, k);
                kol = Sorts.Bubble(per, kol);
                dataGridView3.Rows[0].Cells[0].Value = kol.ToString();
                FillTable();
                Array.Clear(per, 0, k);
            }
            if (Быстрая.Checked)
            {
                int k = person.Length;
                Array.Resize(ref per, k);
                Array.Copy(person, per, k);
                kol = Sorts.Quick(per, 0, per.Length - 1, kol);
                dataGridView3.Rows[0].Cells[1].Value = kol.ToString();
                FillTable();
                Array.Clear(per, 0, k);
            }

            if (Выбором.Checked)
            {
                int k = person.Length;
                Array.Resize(ref per, k);
                Array.Copy(person, per, k);
                kol = Sorts.Selection(per, kol);
                dataGridView3.Rows[0].Cells[2].Value = kol.ToString();
                FillTable();
                Array.Clear(per, 0, k);
            }


            if (Вставками.Checked)
            {
                int k = person.Length;
                Array.Resize(ref per, k);
                Array.Copy(person, per, k);
                kol = Sorts.Insertion(per, kol);
                dataGridView3.Rows[0].Cells[3].Value = kol.ToString();
                FillTable();
                Array.Clear(per, 0, k);
            }
          
            if (Шелл.Checked)
            {
                int k = person.Length;
                Array.Resize(ref per, k);
                Array.Copy(person, per, k);
                kol = Sorts.Shell(per, kol);
                dataGridView3.Rows[0].Cells[4].Value = kol.ToString();
                FillTable();
                Array.Clear(per, 0, k);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '\b');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k;
            k = Convert.ToInt32(textBox1.Text);
            string s = "";
            int Iter = 0;
            if (!flag)
            {
                MessageBox.Show("Пожалуйста, загрузите список людей. Для этого нажмите кнопку 'Загрузить'.");
            }
            else
            {
                s = Searches.QuickSequential(person, person.Length, k, ref Iter);
                MessageBox.Show("Количество действий : " + Iter.ToString(), "Счётчик");
            }
            if (s == null)
            {
                textBox2.Clear();
                textBox1.Clear();
                MessageBox.Show("Такого значения НЕТ. Попробуйте ввести другой ключ.\nВНИМАНИЕ! В списке всего " + person.Length + " элемента(-ов)");

            }
            else if (s != null)
            {
                textBox2.Text = s;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k;
            k = Convert.ToInt32(textBox1.Text);
            string s = "";
            int Iter = 0;
            if (!flag)
            {
                MessageBox.Show("Пожалуйста, загрузите список людей. Для этого нажмите кнопку 'Загрузить'.");
            }
            else
            {
                Sorts.Bubble(person, 0);
                s = Searches.Binary(person, person.Length, k, ref Iter);
                MessageBox.Show("Количество действий : " + Iter.ToString(), "Счётчик");
            }
            if (s == null)
            {
                textBox2.Clear();
                textBox1.Clear();
                MessageBox.Show("Такого значения НЕТ. Попробуйте ввести другой ключ.\nВНИМАНИЕ! В списке всего " + person.Length + " элемента(-ов)");

            }
            else if (s != null)
            {
                textBox2.Text = s;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k;
            k = Convert.ToInt32(textBox1.Text);
            string s = "";
            int Iter = 0;
            if (!flag)
            {
                MessageBox.Show("Пожалуйста, загрузите список людей. Для этого нажмите кнопку 'Загрузить'.");
            }
            else
            {
                Sorts.Bubble(person, 0);
                s = Searches.Interpolation(person, person.Length, k, ref Iter);
                MessageBox.Show("Количество действий : "+ Iter.ToString(),"Счётчик");
            }
            if (s == null)
            {
                textBox2.Clear();
                textBox1.Clear();
                MessageBox.Show("Такого значения НЕТ. Попробуйте ввести другой ключ.\nВНИМАНИЕ! В списке всего " + person.Length + " элемента(-ов)");

            }
            else if (s != null)
            {
                textBox2.Text = s;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k;
            k = Convert.ToInt32(textBox1.Text);
            string s = "";
            int Iter = 0;
            if (!flag)
            {
                MessageBox.Show("Пожалуйста, загрузите список людей. Для этого нажмите кнопку 'Загрузить'.");
            }
            else
            {
                s = Searches.Sequential(person, person.Length, k, ref Iter);
                MessageBox.Show("Количество действий : " + Iter.ToString(), "Счётчик");
            }
            if (s == null)
            {
                textBox2.Clear();
                textBox1.Clear();
                MessageBox.Show("Такого значения НЕТ. Попробуйте ввести другой ключ.\nВНИМАНИЕ! В списке всего " + person.Length + " элемента(-ов)");

            }
            else if (s != null)
            {
                textBox2.Text = s;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int k;
            k = Convert.ToInt32(textBox1.Text);
            string s = "";
            int Iter = 0;
            if (!flag)
            {
                MessageBox.Show("Пожалуйста, загрузите список людей. Для этого нажмите кнопку 'Загрузить'.");
            }
            else
            {
                Sorts.Bubble(person, 0);
                s = Searches.Fibonacci(person, k, ref Iter);
                MessageBox.Show("Количество действий : " + Iter.ToString(), "Счётчик");
            }
            if (s == null)
            {
                textBox2.Clear();
                textBox1.Clear();
                MessageBox.Show("Такого значения НЕТ. Попробуйте ввести другой ключ.\n В списке всего " + person.Length + " элемента(-ов)");

            }
            else if (s != null)
            {
                textBox2.Text = s;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная №1\nВыполнил Папирнык Александр ПЗ-17-1","ИНФО",MessageBoxButtons.OK);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
