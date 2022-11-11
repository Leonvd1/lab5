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
	public partial class поиск_состояния : Form
	{
		public поиск_состояния()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form4 main = this.Owner as Form4;
			if (main != null)
			{
				for (int i = 0; i < main.dataGridView2.RowCount; i++)
				{
					main.dataGridView2.Rows[i].Selected = false;
					for (int j = 0; j < main.dataGridView2.ColumnCount; j++)
						if (main.dataGridView2.Rows[i].Cells[j].Value != null)
							if (main.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
							{
								main.dataGridView2.Rows[i].Selected = true;
								break;
							}
				}
			}
		}
	}
}
