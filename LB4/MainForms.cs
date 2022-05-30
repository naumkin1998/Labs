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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызов формы добавления элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElementsClick(object sender, EventArgs e)
        {
            var addElements = new AddElements();
            addElements.Show();

        }

        private void searchClick(object sender, EventArgs e)
        {
            var searchElements = new SearchElements();
            searchElements.Show();            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
