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
    public partial class MainForm : Form
    {

        /// <summary>
        /// Начальный список элементов
        /// </summary>
        private BindingList<ElementBase> _elemenList =
            new BindingList<ElementBase>()
            {
                new Resistor(1000, TypeOfResistor.Linear),
                new Capacitor(100, 50, TypeOfCapacity.Aluminum),
                new InductiveСoil(40, 50)
            };

        public MainForm()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = _elemenList;
            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void AddElementsClick_Click(object sender, EventArgs e)
        {
            var addElements = new AddElements();
            this.AddElementsClick.Enabled = false;
            addElements.Show();
        }
    }
}
