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
	public partial class добавить_типкомп : Form
	{
		public добавить_типкомп()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.иСDataSet.Tables[0].Rows.Add(nRow);
                main.вид_компьютерного_местаTableAdapter.Update(main.иСDataSet.Вид_компьютерного_места);
                main.иСDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }
	}
}
