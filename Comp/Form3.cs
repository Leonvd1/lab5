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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Состояние_пользования". При необходимости она может быть перемещена или удалена.
			this.состояние_пользованияTableAdapter.Fill(this.иСDataSet.Состояние_пользования);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Компьютерные_места". При необходимости она может быть перемещена или удалена.
			this.компьютерные_местаTableAdapter.Fill(this.иСDataSet.Компьютерные_места);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
			this.сотрудникиTableAdapter.Fill(this.иСDataSet.Сотрудники);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this.иСDataSet.Клиенты);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Оплата". При необходимости она может быть перемещена или удалена.
			this.оплатаTableAdapter.Fill(this.иСDataSet.Оплата);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Услуга". При необходимости она может быть перемещена или удалена.
			this.услугаTableAdapter.Fill(this.иСDataSet.Услуга);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Данные_услуг". При необходимости она может быть перемещена или удалена.
			this.данные_услугTableAdapter.Fill(this.иСDataSet.Данные_услуг);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			добавление_данных1 af = new добавление_данных1();
			af.Owner = this;
			af.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			поиск_данные_услуг1 af = new поиск_данные_услуг1();
			af.Owner = this;
			af.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			данные_услугTableAdapter.Update(иСDataSet);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			услугаTableAdapter.Update(иСDataSet);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			оплатаTableAdapter.Update(иСDataSet);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			добавить_услугу af = new добавить_услугу();
			af.Owner = this;
			af.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			поиск_оплаты af = new поиск_оплаты();
			af.Owner = this;
			af.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			поиск_услуги af = new поиск_услуги();
			af.Owner = this;
			af.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			добавить_оплату af = new добавить_оплату();
			af.Owner = this;
			af.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			клиенты_и_сотрудники f3 = new клиенты_и_сотрудники();
			f3.ShowDialog();
		}
	}
}
