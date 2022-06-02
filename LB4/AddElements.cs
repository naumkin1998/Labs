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
    public partial class AddElements : Form
    {

        

        public AddElements()
        {
            InitializeComponent();
            GroupBoxResistor.Visible = false;
            GroupBoxCapacitor.Visible = false;
            GroupBoxInductance.Visible = false;
        }

        private void AddElements_Load(object sender, EventArgs e)
        {

        }
    }
}
