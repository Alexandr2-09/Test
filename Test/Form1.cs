using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Form1 : Form
    {

        public void DataUpdate()
        {
            testBdDataSet.Clear();
            this.testAutorizationTableAdapter.Fill(this.testBdDataSet.TestAutorization);
            this.testTable2TableAdapter.Fill(this.testBdDataSet.TestTable2);
            this.testTable1TableAdapter.Fill(this.testBdDataSet.TestTable1);
        }

        public Form1()
        {
            InitializeComponent();
            sqlConnection1.ConnectionString = @"Data Source=WIN-VV8FA29SI22\SQLEXPRESS;Initial Catalog=TestBd;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testBdDataSet.TestTable1". При необходимости она может быть перемещена или удалена.
            this.testTable1TableAdapter.Fill(this.testBdDataSet.TestTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testBdDataSet.TestTable2". При необходимости она может быть перемещена или удалена.
            this.testTable2TableAdapter.Fill(this.testBdDataSet.TestTable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testBdDataSet.TestAutorization". При необходимости она может быть перемещена или удалена.
            this.testAutorizationTableAdapter.Fill(this.testBdDataSet.TestAutorization);


            sqlConnection1.Open();
        }

        private void MainMenuDeleteButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"DELETE FROM TestTable1 WHERE Id =" + dataGridView3.CurrentRow.Cells[0].Value, sqlConnection1);
            cmd.ExecuteNonQuery();
            DataUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.dgv = null;
            form.ds = testBdDataSet;
            form.con = sqlConnection1;
            form.ShowDialog();
            DataUpdate();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
        form.dgv = dataGridView3;
            form.ds = testBdDataSet;
            form.con = sqlConnection1;
            form.ShowDialog();
            DataUpdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"DELETE FROM TestTable2 WHERE Id =" + dataGridView2.CurrentRow.Cells[0].Value, sqlConnection1);
            cmd.ExecuteNonQuery();
            DataUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.dgv = null;
            form.ds = testBdDataSet;
            form.con = sqlConnection1;
            form.ShowDialog();
            DataUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.dgv = dataGridView2;
            form.ds = testBdDataSet;
            form.con = sqlConnection1;
            form.ShowDialog();
            DataUpdate();
        }
    }
}
