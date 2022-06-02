using System;
using System.Windows.Forms;
using ElectricalElements;

namespace LB4
{
    public partial class AddElements : EventForm
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddElements()
        {
            InitializeComponent();
            groupBoxResistor.Visible = false;
            groupBoxCondensator.Visible = false;
            groupBoxInduction.Visible = false;
        }                    
      
        /// <summary>
        /// Описание работы radioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonResistor_CheckedChanged(object sender, EventArgs e)
        {                       
            groupBoxInduction.Visible = radioButtonInductance.Checked;
            groupBoxCondensator.Visible = radioButtonCondensator.Checked;
            groupBoxResistor.Visible = radioButtonResistor.Checked;
        }

        /// <summary>
        /// Отмена действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            CancelForm?.Invoke(sender, e);
        }

        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (DataTableAddValidation())
            {
                return;
            }

            try
            {               
                this.Close();
            }
            catch (ArgumentException text)
            {
                MessageBoxEvent?.Invoke(text.Message, e);
            }
            catch (Exception text)
            {
                MessageBoxEvent?.Invoke(text.Message, e);
            }
        }

        private bool DataTableAddValidation()
        {
            if (radioButtonInductance.Checked & 
                radioButtonCondensator.Checked & 
                radioButtonResistor.Checked == false)
            {
                MessageBoxEvent?.Invoke(
                    "Пожалуйста, выберите элемент", EventArgs.Empty);
                return true;
            }            
            
            return false;
        }
    }
}
