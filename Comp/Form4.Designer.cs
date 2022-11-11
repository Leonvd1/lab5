
namespace Компьютерный
{
	partial class Form4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.данныеУслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.иСDataSet = new Компьютерный.ИСDataSet();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.иДСостояниеПользованияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.типСостоянияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.состояниеПользованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.данные_услугTableAdapter = new Компьютерный.ИСDataSetTableAdapters.Данные_услугTableAdapter();
			this.состояние_пользованияTableAdapter = new Компьютерный.ИСDataSetTableAdapters.Состояние_пользованияTableAdapter();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.клиентыTableAdapter = new Компьютерный.ИСDataSetTableAdapters.КлиентыTableAdapter();
			this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.сотрудникиTableAdapter = new Компьютерный.ИСDataSetTableAdapters.СотрудникиTableAdapter();
			this.компьютерныеМестаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.компьютерные_местаTableAdapter = new Компьютерный.ИСDataSetTableAdapters.Компьютерные_местаTableAdapter();
			this.услугаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.услугаTableAdapter = new Компьютерный.ИСDataSetTableAdapters.УслугаTableAdapter();
			this.оплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.оплатаTableAdapter = new Компьютерный.ИСDataSetTableAdapters.ОплатаTableAdapter();
			this.состояниеПользованияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.иДДанныеУслугDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.колвоВремениDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.времяПользованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.иДКлиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.иДСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.иДУслугаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.иДОплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.иДСостояниеПользованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.данныеУслугBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.состояниеПользованияBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.компьютерныеМестаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.состояниеПользованияBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДДанныеУслугDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.колвоВремениDataGridViewTextBoxColumn,
            this.времяПользованияDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.иДКлиентDataGridViewTextBoxColumn,
            this.иДСотрудникаDataGridViewTextBoxColumn,
            this.иДКомпьютерноеМестоDataGridViewTextBoxColumn,
            this.иДУслугаDataGridViewTextBoxColumn,
            this.иДОплатаDataGridViewTextBoxColumn,
            this.иДСостояниеПользованияDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.данныеУслугBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(27, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1024, 150);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// данныеУслугBindingSource
			// 
			this.данныеУслугBindingSource.DataMember = "Данные услуг";
			this.данныеУслугBindingSource.DataSource = this.иСDataSet;
			// 
			// иСDataSet
			// 
			this.иСDataSet.DataSetName = "ИСDataSet";
			this.иСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДСостояниеПользованияDataGridViewTextBoxColumn1,
            this.типСостоянияDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.состояниеПользованияBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(40, 328);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(247, 150);
			this.dataGridView2.TabIndex = 1;
			// 
			// иДСостояниеПользованияDataGridViewTextBoxColumn1
			// 
			this.иДСостояниеПользованияDataGridViewTextBoxColumn1.DataPropertyName = "ИД_Состояние пользования";
			this.иДСостояниеПользованияDataGridViewTextBoxColumn1.HeaderText = "ИД_Состояние пользования";
			this.иДСостояниеПользованияDataGridViewTextBoxColumn1.Name = "иДСостояниеПользованияDataGridViewTextBoxColumn1";
			// 
			// типСостоянияDataGridViewTextBoxColumn
			// 
			this.типСостоянияDataGridViewTextBoxColumn.DataPropertyName = "Тип состояния";
			this.типСостоянияDataGridViewTextBoxColumn.HeaderText = "Тип состояния";
			this.типСостоянияDataGridViewTextBoxColumn.Name = "типСостоянияDataGridViewTextBoxColumn";
			// 
			// состояниеПользованияBindingSource
			// 
			this.состояниеПользованияBindingSource.DataMember = "Состояние пользования";
			this.состояниеПользованияBindingSource.DataSource = this.иСDataSet;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Добавить данные";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(192, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Поиск данных";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(321, 223);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Сохранить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(40, 484);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Добавить данные";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(135, 484);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "Поиск данных";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(227, 484);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 8;
			this.button6.Text = "Сохранить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(931, 548);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 12;
			this.button10.Text = "Закрыть";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// данные_услугTableAdapter
			// 
			this.данные_услугTableAdapter.ClearBeforeFill = true;
			// 
			// состояние_пользованияTableAdapter
			// 
			this.состояние_пользованияTableAdapter.ClearBeforeFill = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(931, 288);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(99, 83);
			this.button7.TabIndex = 13;
			this.button7.Text = "Клиенты и сотрудники";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(452, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 25);
			this.label1.TabIndex = 15;
			this.label1.Text = "Данные услуг";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(49, 300);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(253, 25);
			this.label2.TabIndex = 16;
			this.label2.Text = "Состояние пользования";
			// 
			// клиентыBindingSource
			// 
			this.клиентыBindingSource.DataMember = "Клиенты";
			this.клиентыBindingSource.DataSource = this.иСDataSet;
			// 
			// клиентыTableAdapter
			// 
			this.клиентыTableAdapter.ClearBeforeFill = true;
			// 
			// сотрудникиBindingSource
			// 
			this.сотрудникиBindingSource.DataMember = "Сотрудники";
			this.сотрудникиBindingSource.DataSource = this.иСDataSet;
			// 
			// сотрудникиTableAdapter
			// 
			this.сотрудникиTableAdapter.ClearBeforeFill = true;
			// 
			// компьютерныеМестаBindingSource
			// 
			this.компьютерныеМестаBindingSource.DataMember = "Компьютерные места";
			this.компьютерныеМестаBindingSource.DataSource = this.иСDataSet;
			// 
			// компьютерные_местаTableAdapter
			// 
			this.компьютерные_местаTableAdapter.ClearBeforeFill = true;
			// 
			// услугаBindingSource
			// 
			this.услугаBindingSource.DataMember = "Услуга";
			this.услугаBindingSource.DataSource = this.иСDataSet;
			// 
			// услугаTableAdapter
			// 
			this.услугаTableAdapter.ClearBeforeFill = true;
			// 
			// оплатаBindingSource
			// 
			this.оплатаBindingSource.DataMember = "Оплата";
			this.оплатаBindingSource.DataSource = this.иСDataSet;
			// 
			// оплатаTableAdapter
			// 
			this.оплатаTableAdapter.ClearBeforeFill = true;
			// 
			// состояниеПользованияBindingSource1
			// 
			this.состояниеПользованияBindingSource1.DataMember = "Состояние пользования";
			this.состояниеПользованияBindingSource1.DataSource = this.иСDataSet;
			// 
			// иДДанныеУслугDataGridViewTextBoxColumn
			// 
			this.иДДанныеУслугDataGridViewTextBoxColumn.DataPropertyName = "ИД_Данные услуг";
			this.иДДанныеУслугDataGridViewTextBoxColumn.HeaderText = "ИД_Данные услуг";
			this.иДДанныеУслугDataGridViewTextBoxColumn.Name = "иДДанныеУслугDataGridViewTextBoxColumn";
			// 
			// датаDataGridViewTextBoxColumn
			// 
			this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
			this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
			this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
			// 
			// колвоВремениDataGridViewTextBoxColumn
			// 
			this.колвоВремениDataGridViewTextBoxColumn.DataPropertyName = "Кол-во времени";
			this.колвоВремениDataGridViewTextBoxColumn.HeaderText = "Кол-во времени";
			this.колвоВремениDataGridViewTextBoxColumn.Name = "колвоВремениDataGridViewTextBoxColumn";
			// 
			// времяПользованияDataGridViewTextBoxColumn
			// 
			this.времяПользованияDataGridViewTextBoxColumn.DataPropertyName = "Время пользования";
			this.времяПользованияDataGridViewTextBoxColumn.HeaderText = "Время пользования";
			this.времяПользованияDataGridViewTextBoxColumn.Name = "времяПользованияDataGridViewTextBoxColumn";
			// 
			// суммаDataGridViewTextBoxColumn
			// 
			this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
			this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
			this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
			// 
			// иДКлиентDataGridViewTextBoxColumn
			// 
			this.иДКлиентDataGridViewTextBoxColumn.DataPropertyName = "ИД_Клиент";
			this.иДКлиентDataGridViewTextBoxColumn.DataSource = this.клиентыBindingSource;
			this.иДКлиентDataGridViewTextBoxColumn.DisplayMember = "Фамилия клиента";
			this.иДКлиентDataGridViewTextBoxColumn.HeaderText = "ИД_Клиент";
			this.иДКлиентDataGridViewTextBoxColumn.Name = "иДКлиентDataGridViewTextBoxColumn";
			this.иДКлиентDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.иДКлиентDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.иДКлиентDataGridViewTextBoxColumn.ValueMember = "ИД_Клиент";
			// 
			// иДСотрудникаDataGridViewTextBoxColumn
			// 
			this.иДСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ИД_Сотрудника";
			this.иДСотрудникаDataGridViewTextBoxColumn.DataSource = this.сотрудникиBindingSource;
			this.иДСотрудникаDataGridViewTextBoxColumn.DisplayMember = "Фамилия сотрудника";
			this.иДСотрудникаDataGridViewTextBoxColumn.HeaderText = "ИД_Сотрудника";
			this.иДСотрудникаDataGridViewTextBoxColumn.Name = "иДСотрудникаDataGridViewTextBoxColumn";
			this.иДСотрудникаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.иДСотрудникаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.иДСотрудникаDataGridViewTextBoxColumn.ValueMember = "ИД_Сотрудник";
			// 
			// иДКомпьютерноеМестоDataGridViewTextBoxColumn
			// 
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.DataPropertyName = "ИД_Компьютерное место";
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.DataSource = this.компьютерныеМестаBindingSource;
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.DisplayMember = "Место";
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.HeaderText = "ИД_Компьютерное место";
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.Name = "иДКомпьютерноеМестоDataGridViewTextBoxColumn";
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.иДКомпьютерноеМестоDataGridViewTextBoxColumn.ValueMember = "ИД_Компьютерные места";
			// 
			// иДУслугаDataGridViewTextBoxColumn
			// 
			this.иДУслугаDataGridViewTextBoxColumn.DataPropertyName = "ИД_Услуга";
			this.иДУслугаDataGridViewTextBoxColumn.DataSource = this.услугаBindingSource;
			this.иДУслугаDataGridViewTextBoxColumn.DisplayMember = "Тип услуги";
			this.иДУслугаDataGridViewTextBoxColumn.HeaderText = "ИД_Услуга";
			this.иДУслугаDataGridViewTextBoxColumn.Name = "иДУслугаDataGridViewTextBoxColumn";
			this.иДУслугаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.иДУслугаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.иДУслугаDataGridViewTextBoxColumn.ValueMember = "ИД_Услуга";
			// 
			// иДОплатаDataGridViewTextBoxColumn
			// 
			this.иДОплатаDataGridViewTextBoxColumn.DataPropertyName = "ИД_Оплата";
			this.иДОплатаDataGridViewTextBoxColumn.DataSource = this.оплатаBindingSource;
			this.иДОплатаDataGridViewTextBoxColumn.DisplayMember = "Вид оплата";
			this.иДОплатаDataGridViewTextBoxColumn.HeaderText = "ИД_Оплата";
			this.иДОплатаDataGridViewTextBoxColumn.Name = "иДОплатаDataGridViewTextBoxColumn";
			this.иДОплатаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.иДОплатаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.иДОплатаDataGridViewTextBoxColumn.ValueMember = "ИД_Оплата";
			// 
			// иДСостояниеПользованияDataGridViewTextBoxColumn
			// 
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.DataPropertyName = "ИД_Состояние пользования";
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.DataSource = this.состояниеПользованияBindingSource1;
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.DisplayMember = "Тип состояния";
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.HeaderText = "ИД_Состояние пользования";
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.Name = "иДСостояниеПользованияDataGridViewTextBoxColumn";
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.иДСостояниеПользованияDataGridViewTextBoxColumn.ValueMember = "ИД_Состояние пользования";
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 614);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form4";
			this.Text = "Предоставление доступа к услуге";
			this.Load += new System.EventHandler(this.Form4_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.данныеУслугBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.состояниеПользованияBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.компьютерныеМестаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.услугаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.состояниеПользованияBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.DataGridView dataGridView2;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button4;
		public System.Windows.Forms.Button button5;
		public System.Windows.Forms.Button button6;
		public System.Windows.Forms.Button button10;
		public ИСDataSet иСDataSet;
		public System.Windows.Forms.BindingSource данныеУслугBindingSource;
		public ИСDataSetTableAdapters.Данные_услугTableAdapter данные_услугTableAdapter;
		public System.Windows.Forms.BindingSource состояниеПользованияBindingSource;
		public ИСDataSetTableAdapters.Состояние_пользованияTableAdapter состояние_пользованияTableAdapter;
		public System.Windows.Forms.DataGridViewTextBoxColumn иДСостояниеПользованияDataGridViewTextBoxColumn1;
		public System.Windows.Forms.DataGridViewTextBoxColumn типСостоянияDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource клиентыBindingSource;
		private ИСDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
		private System.Windows.Forms.BindingSource сотрудникиBindingSource;
		private ИСDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
		private System.Windows.Forms.BindingSource компьютерныеМестаBindingSource;
		private ИСDataSetTableAdapters.Компьютерные_местаTableAdapter компьютерные_местаTableAdapter;
		private System.Windows.Forms.BindingSource услугаBindingSource;
		private ИСDataSetTableAdapters.УслугаTableAdapter услугаTableAdapter;
		private System.Windows.Forms.BindingSource оплатаBindingSource;
		private ИСDataSetTableAdapters.ОплатаTableAdapter оплатаTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn иДДанныеУслугDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn колвоВремениDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn времяПользованияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn иДКлиентDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn иДСотрудникаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn иДКомпьютерноеМестоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn иДУслугаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn иДОплатаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn иДСостояниеПользованияDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource состояниеПользованияBindingSource1;
	}
}