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
	public partial class добавление_комп : Form
	{
		public добавление_комп()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[4].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                main.иСDataSet.Tables[4].Rows.Add(nRow);
                main.компьютерные_местаTableAdapter.Update(main.иСDataSet.Компьютерные_места);
                main.иСDataSet.Tables[4].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}
