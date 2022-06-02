
namespace LB4
{
    partial class AddElements
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
            this.FrequencyInductance = new System.Windows.Forms.Label();
            this.InrutResistor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resistorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxInduction = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.InputInductance = new System.Windows.Forms.Label();
            this.groupBoxCondensator = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FrequencyCondensator = new System.Windows.Forms.Label();
            this.InputCondensator = new System.Windows.Forms.Label();
            this.groupBoxResistor = new System.Windows.Forms.GroupBox();
            this.radioButtonResistor = new System.Windows.Forms.RadioButton();
            this.radioButtonInductance = new System.Windows.Forms.RadioButton();
            this.radioButtonCondensator = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).BeginInit();
            this.groupBoxInduction.SuspendLayout();
            this.groupBoxCondensator.SuspendLayout();
            this.groupBoxResistor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrequencyInductance
            // 
            this.FrequencyInductance.AutoSize = true;
            this.FrequencyInductance.Location = new System.Drawing.Point(6, 16);
            this.FrequencyInductance.Name = "FrequencyInductance";
            this.FrequencyInductance.Size = new System.Drawing.Size(114, 26);
            this.FrequencyInductance.TabIndex = 0;
            this.FrequencyInductance.Text = "Введите частоту \r\nэлектрического тока";
            // 
            // InrutResistor
            // 
            this.InrutResistor.AutoSize = true;
            this.InrutResistor.Location = new System.Drawing.Point(6, 16);
            this.InrutResistor.Name = "InrutResistor";
            this.InrutResistor.Size = new System.Drawing.Size(132, 26);
            this.InrutResistor.TabIndex = 0;
            this.InrutResistor.Text = "Введите сопротивление \r\nэлемента ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // resistorBindingSource
            // 
            this.resistorBindingSource.DataSource = typeof(ElectricalElements.Resistor);
            // 
            // groupBoxInduction
            // 
            this.groupBoxInduction.Controls.Add(this.textBox4);
            this.groupBoxInduction.Controls.Add(this.textBox1);
            this.groupBoxInduction.Controls.Add(this.FrequencyInductance);
            this.groupBoxInduction.Controls.Add(this.InputInductance);
            this.groupBoxInduction.Location = new System.Drawing.Point(229, 12);
            this.groupBoxInduction.Name = "groupBoxInduction";
            this.groupBoxInduction.Size = new System.Drawing.Size(297, 131);
            this.groupBoxInduction.TabIndex = 6;
            this.groupBoxInduction.TabStop = false;
            this.groupBoxInduction.Text = "Катушка";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 2;
            // 
            // InputInductance
            // 
            this.InputInductance.AutoSize = true;
            this.InputInductance.Location = new System.Drawing.Point(6, 53);
            this.InputInductance.Name = "InputInductance";
            this.InputInductance.Size = new System.Drawing.Size(127, 26);
            this.InputInductance.TabIndex = 0;
            this.InputInductance.Text = "Введите индуктивность\r\nкатушки";
            // 
            // groupBoxCondensator
            // 
            this.groupBoxCondensator.Controls.Add(this.textBox5);
            this.groupBoxCondensator.Controls.Add(this.textBox3);
            this.groupBoxCondensator.Controls.Add(this.FrequencyCondensator);
            this.groupBoxCondensator.Controls.Add(this.InputCondensator);
            this.groupBoxCondensator.Location = new System.Drawing.Point(229, 12);
            this.groupBoxCondensator.Name = "groupBoxCondensator";
            this.groupBoxCondensator.Size = new System.Drawing.Size(297, 131);
            this.groupBoxCondensator.TabIndex = 7;
            this.groupBoxCondensator.TabStop = false;
            this.groupBoxCondensator.Text = "Конденсатор";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(163, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 2;
            // 
            // FrequencyCondensator
            // 
            this.FrequencyCondensator.AutoSize = true;
            this.FrequencyCondensator.Location = new System.Drawing.Point(6, 16);
            this.FrequencyCondensator.Name = "FrequencyCondensator";
            this.FrequencyCondensator.Size = new System.Drawing.Size(114, 26);
            this.FrequencyCondensator.TabIndex = 0;
            this.FrequencyCondensator.Text = "Введите частоту \r\nэлектрического тока";
            // 
            // InputCondensator
            // 
            this.InputCondensator.AutoSize = true;
            this.InputCondensator.Location = new System.Drawing.Point(6, 53);
            this.InputCondensator.Name = "InputCondensator";
            this.InputCondensator.Size = new System.Drawing.Size(127, 26);
            this.InputCondensator.TabIndex = 0;
            this.InputCondensator.Text = "Введите индуктивность\r\nкатушки";
            // 
            // groupBoxResistor
            // 
            this.groupBoxResistor.Controls.Add(this.InrutResistor);
            this.groupBoxResistor.Controls.Add(this.textBox2);
            this.groupBoxResistor.Location = new System.Drawing.Point(229, 12);
            this.groupBoxResistor.Name = "groupBoxResistor";
            this.groupBoxResistor.Size = new System.Drawing.Size(297, 131);
            this.groupBoxResistor.TabIndex = 8;
            this.groupBoxResistor.TabStop = false;
            this.groupBoxResistor.Text = "Резистор";
            // 
            // radioButtonResistor
            // 
            this.radioButtonResistor.AutoSize = true;
            this.radioButtonResistor.Location = new System.Drawing.Point(16, 28);
            this.radioButtonResistor.Name = "radioButtonResistor";
            this.radioButtonResistor.Size = new System.Drawing.Size(73, 17);
            this.radioButtonResistor.TabIndex = 0;
            this.radioButtonResistor.TabStop = true;
            this.radioButtonResistor.Text = "Резистор";
            this.radioButtonResistor.UseVisualStyleBackColor = true;
            this.radioButtonResistor.CheckedChanged += new System.EventHandler(this.radioButtonResistor_CheckedChanged);
            // 
            // radioButtonInductance
            // 
            this.radioButtonInductance.AutoSize = true;
            this.radioButtonInductance.Location = new System.Drawing.Point(15, 59);
            this.radioButtonInductance.Name = "radioButtonInductance";
            this.radioButtonInductance.Size = new System.Drawing.Size(68, 17);
            this.radioButtonInductance.TabIndex = 0;
            this.radioButtonInductance.TabStop = true;
            this.radioButtonInductance.Text = "Катушка";
            this.radioButtonInductance.UseVisualStyleBackColor = true;
            this.radioButtonInductance.CheckedChanged += new System.EventHandler(this.radioButtonResistor_CheckedChanged);
            // 
            // radioButtonCondensator
            // 
            this.radioButtonCondensator.AutoSize = true;
            this.radioButtonCondensator.Location = new System.Drawing.Point(16, 90);
            this.radioButtonCondensator.Name = "radioButtonCondensator";
            this.radioButtonCondensator.Size = new System.Drawing.Size(91, 17);
            this.radioButtonCondensator.TabIndex = 0;
            this.radioButtonCondensator.TabStop = true;
            this.radioButtonCondensator.Text = "Конденсатор";
            this.radioButtonCondensator.UseVisualStyleBackColor = true;
            this.radioButtonCondensator.CheckedChanged += new System.EventHandler(this.radioButtonResistor_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCondensator);
            this.groupBox1.Controls.Add(this.radioButtonInductance);
            this.groupBox1.Controls.Add(this.radioButtonResistor);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберете элемент";
            // 
            // AddElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 190);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxResistor);
            this.Controls.Add(this.groupBoxCondensator);
            this.Controls.Add(this.groupBoxInduction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddElements";
            this.Text = "AddElements";
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).EndInit();
            this.groupBoxInduction.ResumeLayout(false);
            this.groupBoxInduction.PerformLayout();
            this.groupBoxCondensator.ResumeLayout(false);
            this.groupBoxCondensator.PerformLayout();
            this.groupBoxResistor.ResumeLayout(false);
            this.groupBoxResistor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label FrequencyInductance;
        private System.Windows.Forms.Label InrutResistor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource resistorBindingSource;
        private System.Windows.Forms.GroupBox groupBoxInduction;
        private System.Windows.Forms.Label InputInductance;
        private System.Windows.Forms.GroupBox groupBoxCondensator;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label FrequencyCondensator;
        private System.Windows.Forms.GroupBox groupBoxResistor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label InputCondensator;
        private System.Windows.Forms.RadioButton radioButtonResistor;
        private System.Windows.Forms.RadioButton radioButtonInductance;
        private System.Windows.Forms.RadioButton radioButtonCondensator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
    }
}