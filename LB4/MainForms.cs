using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ElectricalElements;

namespace LB4
{
    //TODO: XML
    public partial class MainForm : Form
    {
        //TODO:
        /// <summary>
        /// Начальный список элементов
        /// </summary>
        private BindingList<ElementBase> _elemenList =
            new BindingList<ElementBase>()
            {
                new Resistor(100, "Резистор"),
                new Capacitor(10, 140, "Конденсатор"), 
                new InductiveСoil(10, 50, "Катушка индуктивности")                
            };

        
        /// <summary>
        /// Инициализация основной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = _elemenList;
            this.dataGridView1.AllowUserToAddRows = false;

            var columnNames = new List<string>();
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                columnNames.Add(this.dataGridView1.Columns[i].Name);
            }
            this.ColumnSortComboBox.DataSource = columnNames;
        }

        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElementsClick_Click(object sender, EventArgs e)
        {
            var addElements = new AddElementsForms();
            addElements.StartPosition = FormStartPosition.CenterScreen;
            addElements.Show();
        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteElementButton_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Сохранение в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            var fileBrowser = new SaveFileDialog();
            fileBrowser.Filter = "XML|*.xml";
            fileBrowser.ShowDialog();
            string path = fileBrowser.FileName;

            var xmlSerialaizer =
                new XmlSerializer(typeof(BindingList<ElementBase>));

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using (var fileWriter = new FileStream(path, FileMode.Create))
            {
                xmlSerialaizer.Serialize(fileWriter, _elemenList);
            }
        }

        /// <summary>
        /// Загрузка из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "XML|*.xml"; ;
            fileBrowser.ShowDialog();

            string path = fileBrowser.FileName;

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<ElementBase>));

            try
            {
                using (var fileReader = new FileStream(path, FileMode.Open))
                {
                    _elemenList = (BindingList<ElementBase>)
                        xmlSerializer.Deserialize(fileReader);

                }

                dataGridView1.DataSource = _elemenList;

            }
            catch (InvalidOperationException _)
            {
                ErrorMessageBox("Файл поврежден");
            }
        }

        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            
            var listDataSource = (BindingList<ElementBase>)this.dataGridView1.DataSource;
            var sortedEmployees = new BindingList<ElementBase>();
            var selectedColumn = this.ColumnSortComboBox.Text;
            var stringData = this.DataSortTextBox.Text;
        }



        /// <summary>
        /// Сброс сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelFilterButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = _elemenList;
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
    }
}
