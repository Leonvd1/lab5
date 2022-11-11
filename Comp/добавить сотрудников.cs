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
	public partial class добавить_сотрудников : Form
	{
		public добавить_сотрудников()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            клиенты_и_сотрудники main = this.Owner as клиенты_и_сотрудники;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = textBox6.Text;
                nRow[7] = textBox7.Text;
                main.иСDataSet.Tables[7].Rows.Add(nRow);
                main.сотрудникиTableAdapter.Update(main.иСDataSet.Сотрудники);
                main.иСDataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }
	}
}
