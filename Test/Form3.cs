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
    public partial class Form3 : Form
    {

        public DataGridView dgv { get; set; }

        public DataSet ds { get; set; }

        public SqlConnection con { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (dgv != null)
            {
                textBox1.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                textBox2.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                textBox3.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (dgv == null)
                cmd = new SqlCommand($"INSERT INTO [TestTable2](TestAutorizationId,TestData,TestData2)VALUES(N'{textBox1.Text}',N'{textBox2.Text}',N'{textBox3.Text}')", con);
            else
                cmd = new SqlCommand($"UPDATE TestTable2 SET TestAutorizationId = N'{textBox1.Text}',TestData = N'{textBox2.Text}',TestData2 = N'{textBox3.Text}' WHERE Id =" + dgv.CurrentRow.Cells[0].Value, con);

            cmd.ExecuteNonQuery();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            Close();
        }
    }
}
