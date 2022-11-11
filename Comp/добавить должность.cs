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
	public partial class добавить_должность : Form
	{
		public добавить_должность()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            клиенты_и_сотрудники main = this.Owner as клиенты_и_сотрудники;
            if (main != null)
            {
                DataRow nRow = main.иСDataSet.Tables[2].NewRow();
                int rc = main.dataGridView3.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.иСDataSet.Tables[2].Rows.Add(nRow);
                main.должностьTableAdapter.Update(main.иСDataSet.Должность);
                main.иСDataSet.Tables[2].AcceptChanges();
                main.dataGridView3.Refresh();
                textBox1.Text = "";
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}
