using ElectricalElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    /// <summary>
    /// Реализация класса AddElementsForms
    /// </summary>
    public partial class AddElementsForms : Form
    {


        /// <summary>
        /// Инициализация формы 
        /// </summary>
        public AddElementsForms()
        {
            InitializeComponent();
            GroupBoxResistor.Visible = false;
            GroupBoxCapacitor.Visible = false;
            GroupBoxInductance.Visible = false;
        }

        
        /// <summary>
        /// RadioButton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupBoxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxResistor.Visible = RadioButtonResistor.Checked;
            GroupBoxInductance.Visible = RadioButtonInductance.Checked;
            GroupBoxCapacitor.Visible = RradioButtonCapacitor.Checked;
        }

        /// <summary>
        /// Вызов сообщения об ошибке
        /// </summary>
        /// <param name="text"></param>
        private void ErrorMessageBox(string text)
        {
            MessageBox.Show(this,
                text,
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        //TODO: нарушешение инкапсулции
        /// <summary>
        /// Новый элемент
        /// </summary>
        public ElementBase Element;

        //TODO: RSDN
        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            //TODO: Дубли
            if (RadioButtonResistor.Checked == true)
            {
                try
                {

                    Element = new Resistor(float.Parse(textBoxResistor.Text), "Резистор");
                   
                }
                catch (Exception)
                {
                    ErrorMessageBox("Некорректный ввод данных или пустое поле." +
                        "\nПожалуйста, попробуйте заново");

                }
            }
            if (RadioButtonInductance.Checked == true)
            {
                try
                {
                    Element = new InductiveСoil(float.Parse(textBoxInduc.Text), 
                                              int.Parse(textBoxFreqInduc.Text), "Катушка индуктивности");                   
                }
                catch (Exception)
                {

                    ErrorMessageBox("Некорректный ввод данных или пустое поле." +
                        "\nПожалуйста, попробуйте заново");
                }
            }
            if (RradioButtonCapacitor.Checked == true)
            {
                try
                {
                    Element = new Capacitor(float.Parse(textBoxCap.Text), 
                                             int.Parse(textBoxFreqCap.Text), "Конденсатор");
                   
                }
                catch (Exception)
                {

                    ErrorMessageBox("Некорректный ввод данных или пустое поле." +
                        "\nПожалуйста, попробуйте заново");
                }
            }
            this.Close();

        }
    }
}
