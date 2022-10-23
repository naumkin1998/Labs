
namespace LB4
{
    partial class AddElementsForms
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
            this.textBoxFreqInduc = new System.Windows.Forms.TextBox();
            this.textBoxResistor = new System.Windows.Forms.TextBox();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.resistorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.RradioButtonCapacitor = new System.Windows.Forms.RadioButton();
            this.RadioButtonInductance = new System.Windows.Forms.RadioButton();
            this.RadioButtonResistor = new System.Windows.Forms.RadioButton();
            this.GroupBoxInductance = new System.Windows.Forms.GroupBox();
            this.textBoxInduc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBoxCapacitor = new System.Windows.Forms.GroupBox();
            this.textBoxCap = new System.Windows.Forms.TextBox();
            this.textBoxFreqCap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupBoxResistor = new System.Windows.Forms.GroupBox();
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
            // textBoxFreqInduc
            // 
            this.textBoxFreqInduc.Location = new System.Drawing.Point(163, 53);
            this.textBoxFreqInduc.Name = "textBoxFreqInduc";
            this.textBoxFreqInduc.Size = new System.Drawing.Size(121, 20);
            this.textBoxFreqInduc.TabIndex = 2;
            // 
            // textBoxResistor
            // 
            this.textBoxResistor.Location = new System.Drawing.Point(163, 53);
            this.textBoxResistor.Name = "textBoxResistor";
            this.textBoxResistor.Size = new System.Drawing.Size(121, 20);
            this.textBoxResistor.TabIndex = 2;
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Location = new System.Drawing.Point(450, 157);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(75, 23);
            this.buttonAddElement.TabIndex = 3;
            this.buttonAddElement.Text = "Добавить";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
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
            this.RradioButtonCapacitor.CheckedChanged += new System.EventHandler(this.GroupBoxRadioButton_CheckedChanged);
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
            this.RadioButtonInductance.CheckedChanged += new System.EventHandler(this.GroupBoxRadioButton_CheckedChanged);
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
            this.RadioButtonResistor.CheckedChanged += new System.EventHandler(this.GroupBoxRadioButton_CheckedChanged);
            // 
            // GroupBoxInductance
            // 
            this.GroupBoxInductance.Controls.Add(this.textBoxInduc);
            this.GroupBoxInductance.Controls.Add(this.textBoxFreqInduc);
            this.GroupBoxInductance.Controls.Add(this.label3);
            this.GroupBoxInductance.Controls.Add(this.label6);
            this.GroupBoxInductance.Location = new System.Drawing.Point(228, 12);
            this.GroupBoxInductance.Name = "GroupBoxInductance";
            this.GroupBoxInductance.Size = new System.Drawing.Size(297, 131);
            this.GroupBoxInductance.TabIndex = 6;
            this.GroupBoxInductance.TabStop = false;
            this.GroupBoxInductance.Text = "Катушка";
            // 
            // textBoxInduc
            // 
            this.textBoxInduc.Location = new System.Drawing.Point(163, 92);
            this.textBoxInduc.Name = "textBoxInduc";
            this.textBoxInduc.Size = new System.Drawing.Size(121, 20);
            this.textBoxInduc.TabIndex = 2;
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
            this.GroupBoxCapacitor.Controls.Add(this.textBoxCap);
            this.GroupBoxCapacitor.Controls.Add(this.textBoxFreqCap);
            this.GroupBoxCapacitor.Controls.Add(this.label5);
            this.GroupBoxCapacitor.Controls.Add(this.label7);
            this.GroupBoxCapacitor.Location = new System.Drawing.Point(228, 12);
            this.GroupBoxCapacitor.Name = "GroupBoxCapacitor";
            this.GroupBoxCapacitor.Size = new System.Drawing.Size(297, 131);
            this.GroupBoxCapacitor.TabIndex = 7;
            this.GroupBoxCapacitor.TabStop = false;
            this.GroupBoxCapacitor.Text = "Конденсатор";
            // 
            // textBoxCap
            // 
            this.textBoxCap.Location = new System.Drawing.Point(163, 92);
            this.textBoxCap.Name = "textBoxCap";
            this.textBoxCap.Size = new System.Drawing.Size(121, 20);
            this.textBoxCap.TabIndex = 2;
            // 
            // textBoxFreqCap
            // 
            this.textBoxFreqCap.Location = new System.Drawing.Point(163, 53);
            this.textBoxFreqCap.Name = "textBoxFreqCap";
            this.textBoxFreqCap.Size = new System.Drawing.Size(121, 20);
            this.textBoxFreqCap.TabIndex = 2;
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
            this.label7.Size = new System.Drawing.Size(98, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Введите емкость \r\nконденсатора";
            // 
            // GroupBoxResistor
            // 
            this.GroupBoxResistor.Controls.Add(this.label4);
            this.GroupBoxResistor.Controls.Add(this.textBoxResistor);
            this.GroupBoxResistor.Location = new System.Drawing.Point(228, 12);
            this.GroupBoxResistor.Name = "GroupBoxResistor";
            this.GroupBoxResistor.Size = new System.Drawing.Size(297, 131);
            this.GroupBoxResistor.TabIndex = 8;
            this.GroupBoxResistor.TabStop = false;
            this.GroupBoxResistor.Text = "Резистор";
            // 
            // AddElementsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 188);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBoxRadioButton);
            this.Controls.Add(this.buttonAddElement);
            this.Controls.Add(this.GroupBoxCapacitor);
            this.Controls.Add(this.GroupBoxResistor);
            this.Controls.Add(this.GroupBoxInductance);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddElementsForms";
            this.Text = "AddElements";
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
        private System.Windows.Forms.TextBox textBoxFreqInduc;
        private System.Windows.Forms.TextBox textBoxResistor;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.BindingSource resistorBindingSource;
        private System.Windows.Forms.GroupBox GroupBoxRadioButton;
        private System.Windows.Forms.RadioButton RradioButtonCapacitor;
        private System.Windows.Forms.RadioButton RadioButtonInductance;
        private System.Windows.Forms.RadioButton RadioButtonResistor;
        private System.Windows.Forms.GroupBox GroupBoxInductance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GroupBoxCapacitor;
        private System.Windows.Forms.TextBox textBoxFreqCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupBoxResistor;
        private System.Windows.Forms.TextBox textBoxInduc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCap;
    }
}