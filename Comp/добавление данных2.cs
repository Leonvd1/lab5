using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Компьютерный
{
	public partial class добавление_данных2 : Form
	{
		public добавление_данных2()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[1].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = textBox6.Text;
                nRow[7] = textBox7.Text;
                nRow[8] = textBox8.Text;
                nRow[9] = textBox9.Text;
                nRow[10] = textBox10.Text;
                main.иСDataSet.Tables[1].Rows.Add(nRow);
                main.данные_услугTableAdapter.Update(main.иСDataSet.Данные_услуг);
                main.иСDataSet.Tables[1].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Close();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
