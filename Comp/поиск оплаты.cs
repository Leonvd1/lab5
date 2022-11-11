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
	public partial class поиск_оплаты : Form
	{
		public поиск_оплаты()
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
				for (int i = 0; i < main.dataGridView3.RowCount; i++)
				{
					main.dataGridView3.Rows[i].Selected = false;
					for (int j = 0; j < main.dataGridView3.ColumnCount; j++)
						if (main.dataGridView3.Rows[i].Cells[j].Value != null)
							if (main.dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
							{
								main.dataGridView3.Rows[i].Selected = true;
								break;
							}
				}
			}
		}
	}
}
