namespace KursRab
{
    partial class UserWindow
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
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkerComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ExportCSVButton = new System.Windows.Forms.Button();
            this.НомерЗаказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клиент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуга = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Счётчики = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаСоздания = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПоловинаДня = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаВыполнения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заметка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Работник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.НомерЗаказа,
            this.Клиент,
            this.Услуга,
            this.Счётчики,
            this.Стоимость,
            this.ДатаСоздания,
            this.ПоловинаДня,
            this.ДатаВыполнения,
            this.Заметка,
            this.Статус,
            this.Работник});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(993, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(170, 371);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(142, 21);
            this.ServiceComboBox.TabIndex = 1;
            this.ServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Услуга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата создания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Статус";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(170, 451);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(142, 21);
            this.StatusComboBox.TabIndex = 5;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Работник";
            // 
            // WorkerComboBox
            // 
            this.WorkerComboBox.FormattingEnabled = true;
            this.WorkerComboBox.Location = new System.Drawing.Point(170, 478);
            this.WorkerComboBox.Name = "WorkerComboBox";
            this.WorkerComboBox.Size = new System.Drawing.Size(142, 21);
            this.WorkerComboBox.TabIndex = 7;
            this.WorkerComboBox.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 399);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.Changed);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(170, 425);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата выполнения";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(149, 374);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Changed);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(149, 402);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Changed);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(149, 453);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.Changed);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(149, 428);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.Changed);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(149, 481);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.Changed);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Выбрать все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Убрать все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Отчистить поля";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExportCSVButton
            // 
            this.ExportCSVButton.Location = new System.Drawing.Point(318, 507);
            this.ExportCSVButton.Name = "ExportCSVButton";
            this.ExportCSVButton.Size = new System.Drawing.Size(164, 23);
            this.ExportCSVButton.TabIndex = 20;
            this.ExportCSVButton.Text = "Экспортировать как...";
            this.ExportCSVButton.UseVisualStyleBackColor = true;
            this.ExportCSVButton.Click += new System.EventHandler(this.ExportCSVButton_Click);
            // 
            // НомерЗаказа
            // 
            this.НомерЗаказа.HeaderText = "№";
            this.НомерЗаказа.MinimumWidth = 8;
            this.НомерЗаказа.Name = "НомерЗаказа";
            this.НомерЗаказа.ReadOnly = true;
            this.НомерЗаказа.Width = 25;
            // 
            // Клиент
            // 
            this.Клиент.HeaderText = "Клиент";
            this.Клиент.MinimumWidth = 8;
            this.Клиент.Name = "Клиент";
            this.Клиент.ReadOnly = true;
            this.Клиент.Width = 150;
            // 
            // Услуга
            // 
            this.Услуга.HeaderText = "Услуга";
            this.Услуга.MinimumWidth = 8;
            this.Услуга.Name = "Услуга";
            this.Услуга.ReadOnly = true;
            this.Услуга.Width = 75;
            // 
            // Счётчики
            // 
            this.Счётчики.HeaderText = "Счётчики";
            this.Счётчики.MinimumWidth = 8;
            this.Счётчики.Name = "Счётчики";
            this.Счётчики.ReadOnly = true;
            this.Счётчики.Width = 70;
            // 
            // Стоимость
            // 
            this.Стоимость.HeaderText = "Стоимость";
            this.Стоимость.MinimumWidth = 8;
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            this.Стоимость.Width = 80;
            // 
            // ДатаСоздания
            // 
            this.ДатаСоздания.HeaderText = "Дата создания";
            this.ДатаСоздания.MinimumWidth = 8;
            this.ДатаСоздания.Name = "ДатаСоздания";
            this.ДатаСоздания.ReadOnly = true;
            this.ДатаСоздания.Width = 110;
            // 
            // ПоловинаДня
            // 
            this.ПоловинаДня.HeaderText = "Половина дня";
            this.ПоловинаДня.MinimumWidth = 8;
            this.ПоловинаДня.Name = "ПоловинаДня";
            this.ПоловинаДня.ReadOnly = true;
            this.ПоловинаДня.Width = 150;
            // 
            // ДатаВыполнения
            // 
            this.ДатаВыполнения.HeaderText = "Дата выполнения";
            this.ДатаВыполнения.MinimumWidth = 8;
            this.ДатаВыполнения.Name = "ДатаВыполнения";
            this.ДатаВыполнения.ReadOnly = true;
            this.ДатаВыполнения.Width = 125;
            // 
            // Заметка
            // 
            this.Заметка.HeaderText = "Заметка";
            this.Заметка.MinimumWidth = 8;
            this.Заметка.Name = "Заметка";
            this.Заметка.ReadOnly = true;
            this.Заметка.Width = 150;
            // 
            // Статус
            // 
            this.Статус.HeaderText = "Статус";
            this.Статус.MinimumWidth = 8;
            this.Статус.Name = "Статус";
            this.Статус.ReadOnly = true;
            this.Статус.Width = 80;
            // 
            // Работник
            // 
            this.Работник.HeaderText = "Работник";
            this.Работник.MinimumWidth = 8;
            this.Работник.Name = "Работник";
            this.Работник.ReadOnly = true;
            this.Работник.Width = 150;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 555);
            this.Controls.Add(this.ExportCSVButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WorkerComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox WorkerComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ExportCSVButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерЗаказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Клиент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Услуга;
        private System.Windows.Forms.DataGridViewTextBoxColumn Счётчики;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаСоздания;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПоловинаДня;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаВыполнения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заметка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn Работник;
    }
}

