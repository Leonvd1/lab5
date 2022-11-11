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
	public partial class добавить_состояние : Form
	{
		public добавить_состояние()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[6].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.иСDataSet.Tables[6].Rows.Add(nRow);
                main.состояние_пользованияTableAdapter.Update(main.иСDataSet.Состояние_пользования);
                main.иСDataSet.Tables[6].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox1.Text = "";
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}
