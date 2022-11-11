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
	public partial class добавить_оплату : Form
	{
		public добавить_оплату()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.иСDataSet.Tables[5].Rows.Add(nRow);
                main.оплатаTableAdapter.Update(main.иСDataSet.Оплата);
                main.иСDataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }
	}
}
