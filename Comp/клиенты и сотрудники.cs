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
	public partial class клиенты_и_сотрудники : Form
	{
		public клиенты_и_сотрудники()
		{
			InitializeComponent();
		}

		private void клиенты_и_сотрудники_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Данные_услуг". При необходимости она может быть перемещена или удалена.
			this.данные_услугTableAdapter.Fill(this.иСDataSet.Данные_услуг);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Должность". При необходимости она может быть перемещена или удалена.
			this.должностьTableAdapter.Fill(this.иСDataSet.Должность);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
			this.сотрудникиTableAdapter.Fill(this.иСDataSet.Сотрудники);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this.иСDataSet.Клиенты);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			сотрудникиTableAdapter.Update(иСDataSet);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			клиентыTableAdapter.Update(иСDataSet);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			добавить_сотрудников af = new добавить_сотрудников();
			af.Owner = this;
			af.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			поиск_сотрудника af = new поиск_сотрудника();
			af.Owner = this;
			af.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			поиск_клиента af = new поиск_клиента();
			af.Owner = this;
			af.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			добавить_клиента af = new добавить_клиента();
			af.Owner = this;
			af.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			должностьTableAdapter.Update(иСDataSet);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			добавить_должность af = new добавить_должность();
			af.Owner = this;
			af.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			поиск_должность af = new поиск_должность();
			af.Owner = this;
			af.Show();
		}
	}
}
