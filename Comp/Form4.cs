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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Оплата". При необходимости она может быть перемещена или удалена.
			this.оплатаTableAdapter.Fill(this.иСDataSet.Оплата);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Услуга". При необходимости она может быть перемещена или удалена.
			this.услугаTableAdapter.Fill(this.иСDataSet.Услуга);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Компьютерные_места". При необходимости она может быть перемещена или удалена.
			this.компьютерные_местаTableAdapter.Fill(this.иСDataSet.Компьютерные_места);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
			this.сотрудникиTableAdapter.Fill(this.иСDataSet.Сотрудники);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this.иСDataSet.Клиенты);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Состояние_пользования". При необходимости она может быть перемещена или удалена.
			this.состояние_пользованияTableAdapter.Fill(this.иСDataSet.Состояние_пользования);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Данные_услуг". При необходимости она может быть перемещена или удалена.
			this.данные_услугTableAdapter.Fill(this.иСDataSet.Данные_услуг);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			добавление_данных2 af = new добавление_данных2();
			af.Owner = this;
			af.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			добавить_состояние af = new добавить_состояние();
			af.Owner = this;
			af.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			поиск_данных2 af = new поиск_данных2();
			af.Owner = this;
			af.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			данные_услугTableAdapter.Update(иСDataSet);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			состояние_пользованияTableAdapter.Update(иСDataSet);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			поиск_состояния af = new поиск_состояния();
			af.Owner = this;
			af.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			клиенты_и_сотрудники f3 = new клиенты_и_сотрудники();
			f3.ShowDialog();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
