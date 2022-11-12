
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
            //TODO:+
#if !RELEASE
            this.RandomElementButton = new System.Windows.Forms.Button();
#endif


            this.CancelFilterButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.comboBoxSortingAction = new System.Windows.Forms.ComboBox();
            this.ColumnSortComboBox = new System.Windows.Forms.ComboBox();
            this.DataSortTextBox = new System.Windows.Forms.TextBox();
            this.labelSortAction = new System.Windows.Forms.Label();
            this.labelInfSort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(627, 328);
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
#if !RELEASE
            this.groupBox3.Controls.Add(this.RandomElementButton);
#endif
            this.groupBox3.Controls.Add(this.CancelFilterButton);
            this.groupBox3.Controls.Add(this.SortButton);
            this.groupBox3.Controls.Add(this.comboBoxSortingAction);
            this.groupBox3.Controls.Add(this.ColumnSortComboBox);
            this.groupBox3.Controls.Add(this.DataSortTextBox);
            this.groupBox3.Controls.Add(this.labelSortAction);
            this.groupBox3.Controls.Add(this.labelInfSort);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(263, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 124);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортировка";
            //TODO: Опечатки+
#if !RELEASE

            // 
            // RandomElementButton
            // 
            this.RandomElementButton.Location = new System.Drawing.Point(85, 78);
            this.RandomElementButton.Name = "RandomElementButton";
            this.RandomElementButton.Size = new System.Drawing.Size(72, 40);
            this.RandomElementButton.TabIndex = 9;
            this.RandomElementButton.Text = "Случайный элемент";
            this.RandomElementButton.UseVisualStyleBackColor = true;
            this.RandomElementButton.Click += new System.EventHandler(this.RandomElementButton_Click);
#endif
            // 
            // CancelFilterButton
            // 
            this.CancelFilterButton.Location = new System.Drawing.Point(295, 95);
            this.CancelFilterButton.Name = "CancelFilterButton";
            this.CancelFilterButton.Size = new System.Drawing.Size(75, 23);
            this.CancelFilterButton.TabIndex = 5;
            this.CancelFilterButton.Text = "Сбросить";
            this.CancelFilterButton.UseVisualStyleBackColor = true;
            this.CancelFilterButton.Click += new System.EventHandler(this.CancelFilterButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(178, 95);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(111, 23);
            this.SortButton.TabIndex = 5;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // comboBoxSortingAction
            // 
            this.comboBoxSortingAction.DisplayMember = "> = <";
            this.comboBoxSortingAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortingAction.FormattingEnabled = true;
            this.comboBoxSortingAction.Items.AddRange(new object[] {
            ">",
            "=",
            "<"});
            this.comboBoxSortingAction.Location = new System.Drawing.Point(258, 53);
            this.comboBoxSortingAction.Name = "comboBoxSortingAction";
            this.comboBoxSortingAction.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSortingAction.TabIndex = 4;
            this.comboBoxSortingAction.ValueMember = "> = <";
            // 
            // ColumnSortComboBox
            // 
            this.ColumnSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnSortComboBox.FormattingEnabled = true;
            this.ColumnSortComboBox.Items.AddRange(new object[] {
            "Тип элемента",
            "Импеданс"});
            this.ColumnSortComboBox.Location = new System.Drawing.Point(6, 53);
            this.ColumnSortComboBox.Name = "ColumnSortComboBox";
            this.ColumnSortComboBox.Size = new System.Drawing.Size(100, 21);
            this.ColumnSortComboBox.TabIndex = 3;
            this.ColumnSortComboBox.SelectedIndexChanged += new System.EventHandler(this.ColumnSortComboBox_SelectedIndexChanged);
            // 
            // DataSortTextBox
            // 
            this.DataSortTextBox.Location = new System.Drawing.Point(132, 53);
            this.DataSortTextBox.Name = "DataSortTextBox";
            this.DataSortTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataSortTextBox.TabIndex = 2;
            // 
            // labelSortAction
            // 
            this.labelSortAction.AutoSize = true;
            this.labelSortAction.Location = new System.Drawing.Point(267, 24);
            this.labelSortAction.Name = "labelSortAction";
            this.labelSortAction.Size = new System.Drawing.Size(81, 26);
            this.labelSortAction.TabIndex = 1;
            this.labelSortAction.Text = "Действие для \r\nсортировки";
            // 
            // labelInfSort
            // 
            this.labelInfSort.AutoSize = true;
            this.labelInfSort.Location = new System.Drawing.Point(131, 24);
            this.labelInfSort.Name = "labelInfSort";
            this.labelInfSort.Size = new System.Drawing.Size(97, 26);
            this.labelInfSort.TabIndex = 0;
            this.labelInfSort.Text = "Информация для \r\nсортировки";
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(653, 481);
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
        private System.Windows.Forms.ComboBox comboBoxSortingAction;
        private System.Windows.Forms.ComboBox ColumnSortComboBox;
        private System.Windows.Forms.TextBox DataSortTextBox;
        private System.Windows.Forms.Label labelSortAction;
        private System.Windows.Forms.Label labelInfSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RandomElementButton;
    }
}

