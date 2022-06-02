
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resistorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.RradioButtonCapacitor = new System.Windows.Forms.RadioButton();
            this.RadioButtonInductance = new System.Windows.Forms.RadioButton();
            this.RadioButtonResistor = new System.Windows.Forms.RadioButton();
            this.GroupBoxInductance = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBoxCapacitor = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupBoxResistor = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).BeginInit();
            this.GroupBoxRadioButton.SuspendLayout();
            this.GroupBoxInductance.SuspendLayout();
            this.GroupBoxCapacitor.SuspendLayout();
            this.GroupBoxResistor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите частоту \r\nэлектрического тока";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите сопротивление \r\nэлемента ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 53);
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // resistorBindingSource
            // 
            this.resistorBindingSource.DataSource = typeof(ElectricalElements.Resistor);
            // 
            // GroupBoxRadioButton
            // 
            this.GroupBoxRadioButton.Controls.Add(this.RradioButtonCapacitor);
            this.GroupBoxRadioButton.Controls.Add(this.RadioButtonInductance);
            this.GroupBoxRadioButton.Controls.Add(this.RadioButtonResistor);
            this.GroupBoxRadioButton.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxRadioButton.Name = "GroupBoxRadioButton";
            this.GroupBoxRadioButton.Size = new System.Drawing.Size(200, 131);
            this.GroupBoxRadioButton.TabIndex = 5;
            this.GroupBoxRadioButton.TabStop = false;
            this.GroupBoxRadioButton.Text = "Выберете элемент";
            // 
            // RradioButtonCapacitor
            // 
            this.RradioButtonCapacitor.AutoSize = true;
            this.RradioButtonCapacitor.Location = new System.Drawing.Point(16, 90);
            this.RradioButtonCapacitor.Name = "RradioButtonCapacitor";
            this.RradioButtonCapacitor.Size = new System.Drawing.Size(91, 17);
            this.RradioButtonCapacitor.TabIndex = 0;
            this.RradioButtonCapacitor.TabStop = true;
            this.RradioButtonCapacitor.Text = "Конденсатор";
            this.RradioButtonCapacitor.UseVisualStyleBackColor = true;
            // 
            // RadioButtonInductance
            // 
            this.RadioButtonInductance.AutoSize = true;
            this.RadioButtonInductance.Location = new System.Drawing.Point(15, 59);
            this.RadioButtonInductance.Name = "RadioButtonInductance";
            this.RadioButtonInductance.Size = new System.Drawing.Size(68, 17);
            this.RadioButtonInductance.TabIndex = 0;
            this.RadioButtonInductance.TabStop = true;
            this.RadioButtonInductance.Text = "Катушка";
            this.RadioButtonInductance.UseVisualStyleBackColor = true;
            // 
            // RadioButtonResistor
            // 
            this.RadioButtonResistor.AutoSize = true;
            this.RadioButtonResistor.Location = new System.Drawing.Point(16, 28);
            this.RadioButtonResistor.Name = "RadioButtonResistor";
            this.RadioButtonResistor.Size = new System.Drawing.Size(73, 17);
            this.RadioButtonResistor.TabIndex = 0;
            this.RadioButtonResistor.TabStop = true;
            this.RadioButtonResistor.Text = "Резистор";
            this.RadioButtonResistor.UseVisualStyleBackColor = true;
            // 
            // GroupBoxInductance
            // 
            this.GroupBoxInductance.Controls.Add(this.textBox4);
            this.GroupBoxInductance.Controls.Add(this.textBox1);
            this.GroupBoxInductance.Controls.Add(this.label3);
            this.GroupBoxInductance.Controls.Add(this.label6);
            this.GroupBoxInductance.Location = new System.Drawing.Point(28, 532);
            this.GroupBoxInductance.Name = "GroupBoxInductance";
            this.GroupBoxInductance.Size = new System.Drawing.Size(297, 131);
            this.GroupBoxInductance.TabIndex = 6;
            this.GroupBoxInductance.TabStop = false;
            this.GroupBoxInductance.Text = "Катушка";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Введите индуктивность\r\nкатушки";
            // 
            // GroupBoxCapacitor
            // 
            this.GroupBoxCapacitor.Controls.Add(this.textBox5);
            this.GroupBoxCapacitor.Controls.Add(this.textBox3);
            this.GroupBoxCapacitor.Controls.Add(this.label5);
            this.GroupBoxCapacitor.Controls.Add(this.label7);
            this.GroupBoxCapacitor.Location = new System.Drawing.Point(28, 358);
            this.GroupBoxCapacitor.Name = "GroupBoxCapacitor";
            this.GroupBoxCapacitor.Size = new System.Drawing.Size(297, 131);
            this.GroupBoxCapacitor.TabIndex = 7;
            this.GroupBoxCapacitor.TabStop = false;
            this.GroupBoxCapacitor.Text = "Конденсатор";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Введите частоту \r\nэлектрического тока";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Введите индуктивность\r\nкатушки";
            // 
            // GroupBoxResistor
            // 
            this.GroupBoxResistor.Controls.Add(this.label4);
            this.GroupBoxResistor.Controls.Add(this.textBox2);
            this.GroupBoxResistor.Location = new System.Drawing.Point(28, 206);
            this.GroupBoxResistor.Name = "GroupBoxResistor";
            this.GroupBoxResistor.Size = new System.Drawing.Size(297, 131);
            this.GroupBoxResistor.TabIndex = 8;
            this.GroupBoxResistor.TabStop = false;
            this.GroupBoxResistor.Text = "Резистор";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(163, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 2;
            // 
            // AddElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 840);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBoxResistor);
            this.Controls.Add(this.GroupBoxCapacitor);
            this.Controls.Add(this.GroupBoxInductance);
            this.Controls.Add(this.GroupBoxRadioButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddElements";
            this.Text = "AddElements";
            this.Load += new System.EventHandler(this.AddElements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).EndInit();
            this.GroupBoxRadioButton.ResumeLayout(false);
            this.GroupBoxRadioButton.PerformLayout();
            this.GroupBoxInductance.ResumeLayout(false);
            this.GroupBoxInductance.PerformLayout();
            this.GroupBoxCapacitor.ResumeLayout(false);
            this.GroupBoxCapacitor.PerformLayout();
            this.GroupBoxResistor.ResumeLayout(false);
            this.GroupBoxResistor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource resistorBindingSource;
        private System.Windows.Forms.GroupBox GroupBoxRadioButton;
        private System.Windows.Forms.RadioButton RradioButtonCapacitor;
        private System.Windows.Forms.RadioButton RadioButtonInductance;
        private System.Windows.Forms.RadioButton RadioButtonResistor;
        private System.Windows.Forms.GroupBox GroupBoxInductance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GroupBoxCapacitor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupBoxResistor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
    }
}