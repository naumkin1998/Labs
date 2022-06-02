using System;
using System.ComponentModel;
using System.Windows.Forms;
using ElectricalElements;

namespace LB4
{
    public partial class MainForm : EventForm
    {

        /// <summary>
        /// Начальный список элементов
        /// </summary>
        private BindingList<ElementBase> _elemenList =
            new BindingList<ElementBase>()
            {
                new Resistor(100),
                new Capacitor(100, 50),
                new InductiveСoil(40, 50)
            };

        /// <summary>
        /// Инициализация основной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Параметры загрузки основной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = _elemenList;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.RowsDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 150;            
            MinimizeBox = false;
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
                

        /// <summary>
        /// Вызов формы добавления элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElementsClick(object sender, EventArgs e)
        {
            var addElements = new AddElements();
            addElements.StartPosition = FormStartPosition.CenterParent;
            addElements.Show();            
        }

        /// <summary>SearchClick
        /// Вызов формы поиска элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchClick(object sender, EventArgs e)
        {
            var searchElements = new SearchElements();
            searchElements.StartPosition = FormStartPosition.CenterParent;
            searchElements.Show();            
        }

        /// <summary>
        /// Реализация удаления выбранной скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.RowCount != 0)
            {
                ErrorMessageBox("Не выбрана строка для удаления.");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                _elemenList.RemoveAt(row.Index);
            }

            if (dataGridView1.RowCount != 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }
        }
    }
}
