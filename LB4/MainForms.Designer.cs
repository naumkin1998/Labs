
namespace LB4
{
    partial class MainForm
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
            this.AddElementsClick = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.DeleteElementButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CancelFilterButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ColumnSortComboBox = new System.Windows.Forms.ComboBox();
            this.DataSortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RandomElementButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddElementsClick
            // 
            this.AddElementsClick.Location = new System.Drawing.Point(6, 19);
            this.AddElementsClick.Name = "AddElementsClick";
            this.AddElementsClick.Size = new System.Drawing.Size(111, 23);
            this.AddElementsClick.TabIndex = 0;
            this.AddElementsClick.Text = "Добавить элемент";
            this.AddElementsClick.UseVisualStyleBackColor = true;
            this.AddElementsClick.Click += new System.EventHandler(this.AddElementsClick_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(6, 19);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(111, 23);
            this.SaveFileButton.TabIndex = 2;
            this.SaveFileButton.Text = "Сохранить";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(128, 18);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(111, 23);
            this.LoadFileButton.TabIndex = 3;
            this.LoadFileButton.Text = "Загрузить";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // DeleteElementButton
            // 
            this.DeleteElementButton.Location = new System.Drawing.Point(128, 19);
            this.DeleteElementButton.Name = "DeleteElementButton";
            this.DeleteElementButton.Size = new System.Drawing.Size(111, 23);
            this.DeleteElementButton.TabIndex = 4;
            this.DeleteElementButton.Text = "Удалить элемент";
            this.DeleteElementButton.UseVisualStyleBackColor = true;
            this.DeleteElementButton.Click += new System.EventHandler(this.DeleteElementButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(748, 328);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddElementsClick);
            this.groupBox1.Controls.Add(this.DeleteElementButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 59);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление/Удаление";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveFileButton);
            this.groupBox2.Controls.Add(this.LoadFileButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Загрузка/Сохранения";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CancelFilterButton);
            this.groupBox3.Controls.Add(this.SortButton);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.ColumnSortComboBox);
            this.groupBox3.Controls.Add(this.DataSortTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(385, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 124);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортировка";
            // 
            // CancelFilterButton
            // 
            this.CancelFilterButton.Location = new System.Drawing.Point(230, 95);
            this.CancelFilterButton.Name = "CancelFilterButton";
            this.CancelFilterButton.Size = new System.Drawing.Size(75, 23);
            this.CancelFilterButton.TabIndex = 5;
            this.CancelFilterButton.Text = "Сбросить";
            this.CancelFilterButton.UseVisualStyleBackColor = true;
            this.CancelFilterButton.Click += new System.EventHandler(this.CancelFilterButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(64, 95);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(111, 23);
            this.SortButton.TabIndex = 5;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // ColumnSortComboBox
            // 
            this.ColumnSortComboBox.FormattingEnabled = true;
            this.ColumnSortComboBox.Location = new System.Drawing.Point(6, 53);
            this.ColumnSortComboBox.Name = "ColumnSortComboBox";
            this.ColumnSortComboBox.Size = new System.Drawing.Size(100, 21);
            this.ColumnSortComboBox.TabIndex = 3;
            // 
            // DataSortTextBox
            // 
            this.DataSortTextBox.Location = new System.Drawing.Point(273, 54);
            this.DataSortTextBox.Name = "DataSortTextBox";
            this.DataSortTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataSortTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Действие для \r\nсортировки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Информация для \r\nсортировки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Столбец для \r\nсортировки";
            // 
            // RandomElementButton
            // 
            this.RandomElementButton.Location = new System.Drawing.Point(287, 45);
            this.RandomElementButton.Name = "RandomElementButton";
            this.RandomElementButton.Size = new System.Drawing.Size(75, 56);
            this.RandomElementButton.TabIndex = 9;
            this.RandomElementButton.Text = "Случайный элемент";
            this.RandomElementButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(773, 481);
            this.Controls.Add(this.RandomElementButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Elements";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button AddElementsClick;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Button DeleteElementButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CancelFilterButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox ColumnSortComboBox;
        private System.Windows.Forms.TextBox DataSortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RandomElementButton;
    }
}

