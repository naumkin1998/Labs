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
        /// Добавление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElements_Load(object sender, EventArgs e)
        {

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

       
    }
}
