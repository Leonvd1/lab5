
namespace Компьютерный
{
	partial class клиенты_и_сотрудники
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
			this.иДСотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчествоСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.паспортныеДанныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.иДДолжностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.должностьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.иСDataSet = new Компьютерный.ИСDataSet();
			this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.клиентыTableAdapter = new Компьютерный.ИСDataSetTableAdapters.КлиентыTableAdapter();
			this.сотрудникиTableAdapter = new Компьютерный.ИСDataSetTableAdapters.СотрудникиTableAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.иДДолжностьDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.типДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.должностьTableAdapter = new Компьютерный.ИСDataSetTableAdapters.ДолжностьTableAdapter();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.клиентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.клиентыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.данныеУслугBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.данные_услугTableAdapter = new Компьютерный.ИСDataSetTableAdapters.Данные_услугTableAdapter();
			this.должностьBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.клиентыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.иДКлиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчествоКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерТелефонаКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.данныеУслугBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource3)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДСотрудникDataGridViewTextBoxColumn,
            this.фамилияСотрудникаDataGridViewTextBoxColumn,
            this.имяСотрудникаDataGridViewTextBoxColumn,
            this.отчествоСотрудникаDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.паспортныеДанныеDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.иДДолжностьDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.сотрудникиBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(66, 53);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(846, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// иДСотрудникDataGridViewTextBoxColumn
			// 
			this.иДСотрудникDataGridViewTextBoxColumn.DataPropertyName = "ИД_Сотрудник";
			this.иДСотрудникDataGridViewTextBoxColumn.HeaderText = "ИД_Сотрудник";
			this.иДСотрудникDataGridViewTextBoxColumn.Name = "иДСотрудникDataGridViewTextBoxColumn";
			// 
			// фамилияСотрудникаDataGridViewTextBoxColumn
			// 
			this.фамилияСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия сотрудника";
			this.фамилияСотрудникаDataGridViewTextBoxColumn.HeaderText = "Фамилия сотрудника";
			this.фамилияСотрудникаDataGridViewTextBoxColumn.Name = "фамилияСотрудникаDataGridViewTextBoxColumn";
			// 
			// имяСотрудникаDataGridViewTextBoxColumn
			// 
			this.имяСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Имя сотрудника";
			this.имяСотрудникаDataGridViewTextBoxColumn.HeaderText = "Имя сотрудника";
			this.имяСотрудникаDataGridViewTextBoxColumn.Name = "имяСотрудникаDataGridViewTextBoxColumn";
			// 
			// отчествоСотрудникаDataGridViewTextBoxColumn
			// 
			this.отчествоСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Отчество сотрудника";
			this.отчествоСотрудникаDataGridViewTextBoxColumn.HeaderText = "Отчество сотрудника";
			this.отчествоСотрудникаDataGridViewTextBoxColumn.Name = "отчествоСотрудникаDataGridViewTextBoxColumn";
			// 
			// датаРожденияDataGridViewTextBoxColumn
			// 
			this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
			this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
			this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
			// 
			// паспортныеДанныеDataGridViewTextBoxColumn
			// 
			this.паспортныеДанныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные данные";
			this.паспортныеДанныеDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
			this.паспортныеДанныеDataGridViewTextBoxColumn.Name = "паспортныеДанныеDataGridViewTextBoxColumn";
			// 
			// номерТелефонаDataGridViewTextBoxColumn
			// 
			this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
			this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
			this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
			// 
			// иДДолжностьDataGridViewTextBoxColumn
			// 
			this.иДДолжностьDataGridViewTextBoxColumn.DataPropertyName = "ИД_Должность";
			this.иДДолжностьDataGridViewTextBoxColumn.DataSource = this.должностьBindingSource1;
			this.иДДолжностьDataGridViewTextBoxColumn.DisplayMember = "Тип должности";
			this.иДДолжностьDataGridViewTextBoxColumn.HeaderText = "Должность";
			this.иДДолжностьDataGridViewTextBoxColumn.Name = "иДДолжностьDataGridViewTextBoxColumn";
			this.иДДолжностьDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.иДДолжностьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.иДДолжностьDataGridViewTextBoxColumn.ValueMember = "ИД_Должность";
			// 
			// должностьBindingSource1
			// 
			this.должностьBindingSource1.DataMember = "Должность";
			this.должностьBindingSource1.DataSource = this.иСDataSet;
			// 
			// иСDataSet
			// 
			this.иСDataSet.DataSetName = "ИСDataSet";
			this.иСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// сотрудникиBindingSource
			// 
			this.сотрудникиBindingSource.DataMember = "Сотрудники";
			this.сотрудникиBindingSource.DataSource = this.иСDataSet;
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
			// сотрудникиTableAdapter
			// 
			this.сотрудникиTableAdapter.ClearBeforeFill = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1062, 501);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(202, 209);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Добавить данные";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(353, 209);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Поиск данных";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(506, 209);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Сохранить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(66, 448);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "Добавить данные";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(202, 448);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 7;
			this.button6.Text = "Поиск данных";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(353, 448);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 8;
			this.button7.Text = "Сохранить данные";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// dataGridView3
			// 
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДДолжностьDataGridViewTextBoxColumn1,
            this.типДолжностиDataGridViewTextBoxColumn});
			this.dataGridView3.DataSource = this.должностьBindingSource;
			this.dataGridView3.Location = new System.Drawing.Point(699, 279);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(240, 150);
			this.dataGridView3.TabIndex = 9;
			// 
			// иДДолжностьDataGridViewTextBoxColumn1
			// 
			this.иДДолжностьDataGridViewTextBoxColumn1.DataPropertyName = "ИД_Должность";
			this.иДДолжностьDataGridViewTextBoxColumn1.HeaderText = "ИД_Должность";
			this.иДДолжностьDataGridViewTextBoxColumn1.Name = "иДДолжностьDataGridViewTextBoxColumn1";
			// 
			// типДолжностиDataGridViewTextBoxColumn
			// 
			this.типДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Тип должности";
			this.типДолжностиDataGridViewTextBoxColumn.HeaderText = "Тип должности";
			this.типДолжностиDataGridViewTextBoxColumn.Name = "типДолжностиDataGridViewTextBoxColumn";
			// 
			// должностьBindingSource
			// 
			this.должностьBindingSource.DataMember = "Должность";
			this.должностьBindingSource.DataSource = this.иСDataSet;
			// 
			// должностьTableAdapter
			// 
			this.должностьTableAdapter.ClearBeforeFill = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(679, 448);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 10;
			this.button8.Text = "Добавить данные";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(789, 448);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 11;
			this.button9.Text = "Поиск данных";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(895, 448);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 12;
			this.button10.Text = "Сохранить";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(432, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 25);
			this.label1.TabIndex = 13;
			this.label1.Text = "Сотрудники";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(219, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Клиенты";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(761, 250);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 25);
			this.label3.TabIndex = 15;
			this.label3.Text = "Должность";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДКлиентDataGridViewTextBoxColumn,
            this.фамилияКлиентаDataGridViewTextBoxColumn,
            this.имяКлиентаDataGridViewTextBoxColumn,
            this.отчествоКлиентаDataGridViewTextBoxColumn,
            this.номерТелефонаКлиентаDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.клиентыBindingSource3;
			this.dataGridView2.Location = new System.Drawing.Point(66, 292);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(547, 150);
			this.dataGridView2.TabIndex = 16;
			// 
			// клиентыBindingSource1
			// 
			this.клиентыBindingSource1.DataMember = "Клиенты";
			this.клиентыBindingSource1.DataSource = this.иСDataSet;
			// 
			// клиентыBindingSource2
			// 
			this.клиентыBindingSource2.DataMember = "Клиенты";
			this.клиентыBindingSource2.DataSource = this.иСDataSet;
			// 
			// данныеУслугBindingSource
			// 
			this.данныеУслугBindingSource.DataMember = "Данные услуг";
			this.данныеУслугBindingSource.DataSource = this.иСDataSet;
			// 
			// данные_услугTableAdapter
			// 
			this.данные_услугTableAdapter.ClearBeforeFill = true;
			// 
			// должностьBindingSource2
			// 
			this.должностьBindingSource2.DataMember = "Должность";
			this.должностьBindingSource2.DataSource = this.иСDataSet;
			// 
			// клиентыBindingSource3
			// 
			this.клиентыBindingSource3.DataMember = "Клиенты";
			this.клиентыBindingSource3.DataSource = this.иСDataSet;
			// 
			// иДКлиентDataGridViewTextBoxColumn
			// 
			this.иДКлиентDataGridViewTextBoxColumn.DataPropertyName = "ИД_Клиент";
			this.иДКлиентDataGridViewTextBoxColumn.HeaderText = "ИД_Клиент";
			this.иДКлиентDataGridViewTextBoxColumn.Name = "иДКлиентDataGridViewTextBoxColumn";
			// 
			// фамилияКлиентаDataGridViewTextBoxColumn
			// 
			this.фамилияКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия клиента";
			this.фамилияКлиентаDataGridViewTextBoxColumn.HeaderText = "Фамилия клиента";
			this.фамилияКлиентаDataGridViewTextBoxColumn.Name = "фамилияКлиентаDataGridViewTextBoxColumn";
			// 
			// имяКлиентаDataGridViewTextBoxColumn
			// 
			this.имяКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Имя клиента";
			this.имяКлиентаDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
			this.имяКлиентаDataGridViewTextBoxColumn.Name = "имяКлиентаDataGridViewTextBoxColumn";
			// 
			// отчествоКлиентаDataGridViewTextBoxColumn
			// 
			this.отчествоКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Отчество клиента";
			this.отчествоКлиентаDataGridViewTextBoxColumn.HeaderText = "Отчество клиента";
			this.отчествоКлиентаDataGridViewTextBoxColumn.Name = "отчествоКлиентаDataGridViewTextBoxColumn";
			// 
			// номерТелефонаКлиентаDataGridViewTextBoxColumn
			// 
			this.номерТелефонаКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона клиента";
			this.номерТелефонаКлиентаDataGridViewTextBoxColumn.HeaderText = "Номер телефона клиента";
			this.номерТелефонаКлиентаDataGridViewTextBoxColumn.Name = "номерТелефонаКлиентаDataGridViewTextBoxColumn";
			// 
			// клиенты_и_сотрудники
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1149, 533);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "клиенты_и_сотрудники";
			this.Text = "клиенты_и_сотрудники";
			this.Load += new System.EventHandler(this.клиенты_и_сотрудники_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.иСDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.данныеУслугBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		public ИСDataSet иСDataSet;
		public System.Windows.Forms.BindingSource клиентыBindingSource;
		public ИСDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
		public System.Windows.Forms.BindingSource сотрудникиBindingSource;
		public ИСDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button4;
		public System.Windows.Forms.Button button5;
		public System.Windows.Forms.Button button6;
		public System.Windows.Forms.Button button7;
		public System.Windows.Forms.BindingSource должностьBindingSource;
		public ИСDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
		public System.Windows.Forms.DataGridView dataGridView3;
		public System.Windows.Forms.DataGridViewTextBoxColumn иДДолжностьDataGridViewTextBoxColumn1;
		public System.Windows.Forms.DataGridViewTextBoxColumn типДолжностиDataGridViewTextBoxColumn;
		public System.Windows.Forms.Button button8;
		public System.Windows.Forms.Button button9;
		public System.Windows.Forms.Button button10;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.DataGridViewTextBoxColumn иДСотрудникDataGridViewTextBoxColumn;
		public System.Windows.Forms.DataGridViewTextBoxColumn фамилияСотрудникаDataGridViewTextBoxColumn;
		public System.Windows.Forms.DataGridViewTextBoxColumn имяСотрудникаDataGridViewTextBoxColumn;
		public System.Windows.Forms.DataGridViewTextBoxColumn отчествоСотрудникаDataGridViewTextBoxColumn;
		public System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
		public System.Windows.Forms.DataGridViewTextBoxColumn паспортныеДанныеDataGridViewTextBoxColumn;
		public System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
		public System.Windows.Forms.DataGridViewComboBoxColumn иДДолжностьDataGridViewTextBoxColumn;
		public System.Windows.Forms.BindingSource должностьBindingSource1;
		public System.Windows.Forms.DataGridView dataGridView2;
		public System.Windows.Forms.BindingSource клиентыBindingSource1;
		private System.Windows.Forms.BindingSource клиентыBindingSource2;
		private System.Windows.Forms.BindingSource данныеУслугBindingSource;
		private ИСDataSetTableAdapters.Данные_услугTableAdapter данные_услугTableAdapter;
		private System.Windows.Forms.BindingSource должностьBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn иДКлиентDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияКлиентаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяКлиентаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn отчествоКлиентаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаКлиентаDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource клиентыBindingSource3;
	}
}