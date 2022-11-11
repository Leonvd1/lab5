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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Состояние_пользования". При необходимости она может быть перемещена или удалена.
			this.состояние_пользованияTableAdapter.Fill(this.иСDataSet.Состояние_пользования);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Оплата". При необходимости она может быть перемещена или удалена.
			this.оплатаTableAdapter.Fill(this.иСDataSet.Оплата);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Услуга". При необходимости она может быть перемещена или удалена.
			this.услугаTableAdapter.Fill(this.иСDataSet.Услуга);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
			this.сотрудникиTableAdapter.Fill(this.иСDataSet.Сотрудники);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
			this.клиентыTableAdapter.Fill(this.иСDataSet.Клиенты);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Вид_компьютерного_места". При необходимости она может быть перемещена или удалена.
			this.вид_компьютерного_местаTableAdapter.Fill(this.иСDataSet.Вид_компьютерного_места);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Компьютерные_места". При необходимости она может быть перемещена или удалена.
			this.компьютерные_местаTableAdapter.Fill(this.иСDataSet.Компьютерные_места);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "иСDataSet.Данные_услуг". При необходимости она может быть перемещена или удалена.
			this.данные_услугTableAdapter.Fill(this.иСDataSet.Данные_услуг);

		}

		private void button4_Click(object sender, EventArgs e)
		{
			данные_услугTableAdapter.Update(иСDataSet);
		}

		private void button5_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			добавление_брон af = new добавление_брон();
			af.Owner = this;
			af.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			поиск_бронирование af = new поиск_бронирование();
			af.Owner = this;
			af.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			компьютерные_местаTableAdapter.Update(иСDataSet);
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			добавление_комп af = new добавление_комп();
			af.Owner = this;
			af.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			поиск_комп af = new поиск_комп();
			af.Owner = this;
			af.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			вид_компьютерного_местаTableAdapter.Update(иСDataSet);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			добавить_типкомп af = new добавить_типкомп();
			af.Owner = this;
			af.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			поиск_видкомп af = new поиск_видкомп();
			af.Owner = this;
			af.Show();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			клиенты_и_сотрудники f3 = new клиенты_и_сотрудники();
			f3.ShowDialog();
		}
	}		
}

