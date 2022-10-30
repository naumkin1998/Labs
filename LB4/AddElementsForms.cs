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
using ElectricalElements;

namespace LB4
{
    /// <summary>
    /// Реализация класса AddElementsForms
    /// </summary>
    public partial class AddElementsForms : EventForm
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

        //TODO: нарушешение инкапсулции+
        /// <summary>
        /// Новый элемент
        /// </summary>
        public EventHandler<ElementsEventArgs> ElementAdded;

        //TODO: RSDN+
        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddElement_Click(object sender, EventArgs e)
        {
            ElementBase element = null;
            //TODO: Дубли+
            if (RadioButtonResistor.Checked == true)
            {
                try
                {
                    element = new Resistor(float.Parse(textBoxResistor.Text), 
                                            "Резистор");                    
                }
                catch (Exception)
                {
                    ErroneousDataEntry();
                }
            }
            if (RadioButtonInductance.Checked == true)
            {
                try
                {
                    element = new InductiveСoil(float.Parse(textBoxInduc.Text), 
                                              int.Parse(textBoxFreqInduc.Text), 
                                              "Катушка индуктивности");                    
                }
                catch (Exception)
                {
                    ErroneousDataEntry();
                }
            }
            if (RradioButtonCapacitor.Checked == true)
            {
                try
                {
                    element = new Capacitor(float.Parse(textBoxCap.Text), 
                                             int.Parse(textBoxFreqCap.Text), 
                                             "Конденсатор");                    

                }
                catch (Exception)
                {
                    ErroneousDataEntry();
                }
            }
            if (element != null)
            {
                ElementAdded.Invoke(this, new ElementsEventArgs(element));
                Close();
            }
        }


        private void ErroneousDataEntry()
        {
            ErrorMessageBox("Некорректный ввод данных или пустое поле." +
                        "\nПожалуйста, попробуйте заново");
        }

        /// <summary>
        /// Реализация работы отмены действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
