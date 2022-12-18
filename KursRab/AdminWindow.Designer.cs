namespace KursRab
{
    partial class AdminWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.НомерЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клиент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуга = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Счётчики = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаСозданияЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПоловинаДня = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаВыполненияЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заметка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Работник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceName = new System.Windows.Forms.Label();
            this.CountersLabel = new System.Windows.Forms.Label();
            this.CountersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CompliteDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkerComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.HalfDayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HalfDayLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.CustomerAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.EditTableButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddNewTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfDayNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.НомерЗаказа,
            this.Клиент,
            this.Услуга,
            this.Счётчики,
            this.Стоимость,
            this.ДатаСозданияЗаказа,
            this.ПоловинаДня,
            this.ДатаВыполненияЗаказа,
            this.Заметка,
            this.Статус,
            this.Работник});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(993, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // НомерЗаказа
            // 
            this.НомерЗаказа.HeaderText = "№";
            this.НомерЗаказа.Name = "НомерЗаказа";
            this.НомерЗаказа.ReadOnly = true;
            this.НомерЗаказа.Width = 25;
            // 
            // Клиент
            // 
            this.Клиент.HeaderText = "Клиент";
            this.Клиент.Name = "Клиент";
            this.Клиент.ReadOnly = true;
            // 
            // Услуга
            // 
            this.Услуга.HeaderText = "Услуга";
            this.Услуга.Name = "Услуга";
            this.Услуга.ReadOnly = true;
            this.Услуга.Width = 75;
            // 
            // Счётчики
            // 
            this.Счётчики.HeaderText = "Счётчики";
            this.Счётчики.Name = "Счётчики";
            this.Счётчики.ReadOnly = true;
            this.Счётчики.Width = 70;
            // 
            // Стоимость
            // 
            this.Стоимость.HeaderText = "Стоимость";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            this.Стоимость.Width = 80;
            // 
            // ДатаСозданияЗаказа
            // 
            this.ДатаСозданияЗаказа.HeaderText = "Дата создания заказа";
            this.ДатаСозданияЗаказа.Name = "ДатаСозданияЗаказа";
            this.ДатаСозданияЗаказа.ReadOnly = true;
            this.ДатаСозданияЗаказа.Width = 110;
            // 
            // ПоловинаДня
            // 
            this.ПоловинаДня.HeaderText = "Половина дня";
            this.ПоловинаДня.Name = "ПоловинаДня";
            this.ПоловинаДня.ReadOnly = true;
            // 
            // ДатаВыполненияЗаказа
            // 
            this.ДатаВыполненияЗаказа.HeaderText = "Дата выполнения заказа";
            this.ДатаВыполненияЗаказа.Name = "ДатаВыполненияЗаказа";
            this.ДатаВыполненияЗаказа.ReadOnly = true;
            this.ДатаВыполненияЗаказа.Width = 125;
            // 
            // Заметка
            // 
            this.Заметка.HeaderText = "Заметка";
            this.Заметка.Name = "Заметка";
            this.Заметка.ReadOnly = true;
            // 
            // Статус
            // 
            this.Статус.HeaderText = "Статус";
            this.Статус.Name = "Статус";
            this.Статус.ReadOnly = true;
            this.Статус.Width = 80;
            // 
            // Работник
            // 
            this.Работник.HeaderText = "Работник";
            this.Работник.Name = "Работник";
            this.Работник.ReadOnly = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(140, 292);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(198, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 295);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "ФИО клиента";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(140, 318);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.ServiceComboBox.TabIndex = 3;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSize = true;
            this.ServiceName.Location = new System.Drawing.Point(12, 321);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(43, 13);
            this.ServiceName.TabIndex = 4;
            this.ServiceName.Text = "Услуга";
            // 
            // CountersLabel
            // 
            this.CountersLabel.AutoSize = true;
            this.CountersLabel.Location = new System.Drawing.Point(12, 349);
            this.CountersLabel.Name = "CountersLabel";
            this.CountersLabel.Size = new System.Drawing.Size(120, 13);
            this.CountersLabel.TabIndex = 5;
            this.CountersLabel.Text = "Количество счётчиков";
            // 
            // CountersNumericUpDown
            // 
            this.CountersNumericUpDown.Location = new System.Drawing.Point(140, 346);
            this.CountersNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CountersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountersNumericUpDown.Name = "CountersNumericUpDown";
            this.CountersNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CountersNumericUpDown.TabIndex = 6;
            this.CountersNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата выполнения";
            // 
            // CompliteDayDateTimePicker
            // 
            this.CompliteDayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CompliteDayDateTimePicker.Location = new System.Drawing.Point(140, 399);
            this.CompliteDayDateTimePicker.MinDate = new System.DateTime(2022, 11, 20, 0, 0, 0, 0);
            this.CompliteDayDateTimePicker.Name = "CompliteDayDateTimePicker";
            this.CompliteDayDateTimePicker.Size = new System.Drawing.Size(155, 20);
            this.CompliteDayDateTimePicker.TabIndex = 8;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(140, 425);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(198, 20);
            this.NoteTextBox.TabIndex = 9;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(12, 425);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(51, 13);
            this.NoteLabel.TabIndex = 10;
            this.NoteLabel.Text = "Заметка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Работник";
            // 
            // WorkerComboBox
            // 
            this.WorkerComboBox.FormattingEnabled = true;
            this.WorkerComboBox.Location = new System.Drawing.Point(139, 451);
            this.WorkerComboBox.Name = "WorkerComboBox";
            this.WorkerComboBox.Size = new System.Drawing.Size(199, 21);
            this.WorkerComboBox.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 492);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить заявку";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HalfDayNumericUpDown
            // 
            this.HalfDayNumericUpDown.Location = new System.Drawing.Point(141, 372);
            this.HalfDayNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HalfDayNumericUpDown.Name = "HalfDayNumericUpDown";
            this.HalfDayNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HalfDayNumericUpDown.TabIndex = 14;
            // 
            // HalfDayLabel
            // 
            this.HalfDayLabel.AutoSize = true;
            this.HalfDayLabel.Location = new System.Drawing.Point(12, 372);
            this.HalfDayLabel.Name = "HalfDayLabel";
            this.HalfDayLabel.Size = new System.Drawing.Size(78, 13);
            this.HalfDayLabel.TabIndex = 15;
            this.HalfDayLabel.Text = "Половина дня";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(138, 492);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Удалить заявку";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(395, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 143);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить статус заявки";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Не отработана";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выполнена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создана";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(687, 292);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.ReadOnly = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(318, 20);
            this.CustomerNameTextBox.TabIndex = 18;
            // 
            // CustomerPhoneTextBox
            // 
            this.CustomerPhoneTextBox.Location = new System.Drawing.Point(687, 321);
            this.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
            this.CustomerPhoneTextBox.ReadOnly = true;
            this.CustomerPhoneTextBox.Size = new System.Drawing.Size(318, 20);
            this.CustomerPhoneTextBox.TabIndex = 19;
            // 
            // CustomerAddressTextBox
            // 
            this.CustomerAddressTextBox.Location = new System.Drawing.Point(687, 349);
            this.CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            this.CustomerAddressTextBox.ReadOnly = true;
            this.CustomerAddressTextBox.Size = new System.Drawing.Size(318, 36);
            this.CustomerAddressTextBox.TabIndex = 20;
            this.CustomerAddressTextBox.Text = "";
            // 
            // EditTableButton
            // 
            this.EditTableButton.Location = new System.Drawing.Point(769, 441);
            this.EditTableButton.Name = "EditTableButton";
            this.EditTableButton.Size = new System.Drawing.Size(152, 23);
            this.EditTableButton.TabIndex = 21;
            this.EditTableButton.Text = "Редактировать таблицу";
            this.EditTableButton.UseVisualStyleBackColor = true;
            this.EditTableButton.Click += new System.EventHandler(this.EditTableButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Удалить таблицу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(745, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление таблицы";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AddNewTableButton
            // 
            this.AddNewTableButton.Location = new System.Drawing.Point(769, 470);
            this.AddNewTableButton.Name = "AddNewTableButton";
            this.AddNewTableButton.Size = new System.Drawing.Size(152, 23);
            this.AddNewTableButton.TabIndex = 25;
            this.AddNewTableButton.Text = "Добавить таблицу";
            this.AddNewTableButton.UseVisualStyleBackColor = true;
            this.AddNewTableButton.Click += new System.EventHandler(this.AddNewTableButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 611);
            this.Controls.Add(this.AddNewTableButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EditTableButton);
            this.Controls.Add(this.CustomerAddressTextBox);
            this.Controls.Add(this.CustomerPhoneTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.HalfDayLabel);
            this.Controls.Add(this.HalfDayNumericUpDown);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.WorkerComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.CompliteDayDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountersNumericUpDown);
            this.Controls.Add(this.CountersLabel);
            this.Controls.Add(this.ServiceName);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminWindow";
            this.Text = "Админ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfDayNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Клиент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Услуга;
        private System.Windows.Forms.DataGridViewTextBoxColumn Счётчики;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаСозданияЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПоловинаДня;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаВыполненияЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заметка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn Работник;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.Label ServiceName;
        private System.Windows.Forms.Label CountersLabel;
        private System.Windows.Forms.NumericUpDown CountersNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CompliteDayDateTimePicker;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WorkerComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown HalfDayNumericUpDown;
        private System.Windows.Forms.Label HalfDayLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox CustomerPhoneTextBox;
        private System.Windows.Forms.RichTextBox CustomerAddressTextBox;
        private System.Windows.Forms.Button EditTableButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddNewTableButton;
    }
}

