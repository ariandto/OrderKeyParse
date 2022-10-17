using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace OrderKeyParse
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton1.Checked == true)
                {
                    const string filename = @"D:\SQLITEDB\klsroute.db";
                    const string sql = "select * from routingan;";
                    var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
                    conn.Open();
                    DataSet ds = new DataSet();
                    var da = new SQLiteDataAdapter(sql, conn);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    string message = "Error connect database sqlite";
                    MessageBox.Show(message);
                }
            }
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //string message = "ENTER WAS PRESSED";
                //MessageBox.Show(message);
                //const string filename = @"D:\SQLITEDB\klsroute.db";
                //var commandcmd = new SQLiteCommand();
                //var ds = new DataSet();
                //var da = new SQLiteDataAdapter();
                //const string sql = "select * from routingan;";
                //var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
                //conn.Open();
                //commandcmd = new SQLiteCommand("SELECT * FROM routingan where area like '%" + searchTextBox.Text, conn);
                //ds = new DataSet();
                //da = new SQLiteDataAdapter(commandcmd);
                //da.Fill(ds);
                .//dataGridView1.DataSource = ds.Tables[0].DefaultView;
                //this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
