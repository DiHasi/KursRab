namespace KursRab
{
    partial class AddNewTableWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsNeedToConnection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ForeignTable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ForeignKey = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AddNewTableButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.ColumnName,
            this.Type,
            this.IsNeedToConnection,
            this.ForeignTable,
            this.ForeignKey});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(11, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(545, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // Key
            // 
            this.Key.HeaderText = "Ключ";
            this.Key.Name = "Key";
            this.Key.Width = 40;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Items.AddRange(new object[] {
            "Int",
            "VarChar"});
            this.Type.Name = "Type";
            // 
            // IsNeedToConnection
            // 
            this.IsNeedToConnection.HeaderText = "Связь";
            this.IsNeedToConnection.Name = "IsNeedToConnection";
            this.IsNeedToConnection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsNeedToConnection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ForeignTable
            // 
            this.ForeignTable.HeaderText = "Таблица";
            this.ForeignTable.Name = "ForeignTable";
            this.ForeignTable.ReadOnly = true;
            // 
            // ForeignKey
            // 
            this.ForeignKey.HeaderText = "Внешний ключ";
            this.ForeignKey.Name = "ForeignKey";
            this.ForeignKey.ReadOnly = true;
            // 
            // AddNewTableButton
            // 
            this.AddNewTableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddNewTableButton.Location = new System.Drawing.Point(11, 233);
            this.AddNewTableButton.Name = "AddNewTableButton";
            this.AddNewTableButton.Size = new System.Drawing.Size(190, 23);
            this.AddNewTableButton.TabIndex = 1;
            this.AddNewTableButton.Text = "Добавить";
            this.AddNewTableButton.UseVisualStyleBackColor = true;
            this.AddNewTableButton.Click += new System.EventHandler(this.AddNewTableButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя таблицы";
            // 
            // AddNewTableWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddNewTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddNewTableWindow";
            this.Text = "AddNewTableWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewTableWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddNewTableButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNeedToConnection;
        private System.Windows.Forms.DataGridViewComboBoxColumn ForeignTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn ForeignKey;
    }
}