using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OrderKeyParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string Nol = "000";
            string koma = ";";
            string hasil = "";
            string message = "Richtextbox masih kosong || String Length == 0";
            string title = "Information || Error!";
            var lines = richTextBox1.Text.Split('\n', '\r').ToList();

            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show(message, title);
            }
            else
            //string hasil = hasil.Substring(0, hasil.LastIndexOf('000;'));

            foreach (var line in lines.Distinct())
            {

                hasil = Nol + line + koma;
                hasil = System.Text.RegularExpressions.Regex.Replace(hasil, " ", "");
                hasil = System.Text.RegularExpressions.Regex.Replace(hasil, "000;", "");
                richTextBox2.AppendText(hasil);
                //richTextBox2.AppendText("\r\n");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = "Richtextbox kosong || Empty string!!";
            string title = "Information || Error!";
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show(message, title);
            }
            else
            richTextBox1.Text = "";
            richTextBox2.Text = "";

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Tidak Bisa Copy ke Clipboard karena kosong || Cannot copy string into your Clipboard";
            string title = "Information || Error!";
            if (richTextBox2.Text.Length == 0)
            {
                MessageBox.Show(message, title);
            }
            else
            richTextBox2.Focus();
            richTextBox2.SelectAll();
            richTextBox2.Copy();
        }
    }
 }

