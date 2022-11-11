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
	public partial class добавить_услугу : Form
	{
		public добавить_услугу()
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
                DataRow nRow = main.иСDataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.иСDataSet.Tables[8].Rows.Add(nRow);
                main.услугаTableAdapter.Update(main.иСDataSet.Услуга);
                main.иСDataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }
	}
}
