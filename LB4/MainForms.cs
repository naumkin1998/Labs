using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using ElectricalElements;

namespace LB4
{
    /// <summary>
    /// Класс основной формы
    /// </summary>
    public partial class MainForm : Form
    {


        /// <summary>
        /// Начальный список элементов
        /// </summary>
        private BindingList<ElementBase> _elementList =
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
            this.dataGridView1.DataSource = _elementList;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Columns[0].HeaderText = "Тип элемента";
            this.dataGridView1.Columns[1].HeaderText = "Импеданс";
            #if !DEBUG
            this.RandomElementButton.Visible = false;
            #endif

        }

        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddElementsClick_Click(object sender, EventArgs e)
        {
            var addElements = new AddElementsForms();
            AddElementsClick.Enabled = false ;
            addElements.StartPosition = FormStartPosition.CenterScreen;
            addElements.Show();
            addElements.Closed += (o, args) => 
            {
                if (addElements.ElementAdded != null)
                {
                    addElements.ElementAdded += (oElment, argsElement)
                         =>
                    {
                        _elementList.Add(argsElement.Element);
                    };
                    dataGridView1.DataSource = _elementList;
                }
            };

            addElements.FormClosed += 
                (s, a) => this.AddElementsClick.Enabled = true;
            
            
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
                _elementList.RemoveAt(row.Index);
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
                xmlSerialaizer.Serialize(fileWriter, _elementList);
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
                    _elementList = (BindingList<ElementBase>)
                        xmlSerializer.Deserialize(fileReader);

                }

                dataGridView1.DataSource = _elementList;
                //BUG: добавить другие варианты исключений
            }
            catch (ArgumentException _)
            {
                ErrorMessageBox("Файл поврежден");
            }
        }


        /// <summary>
        /// Сброс сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelFilterButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = _elementList;
            this.dataGridView1.Columns[0].HeaderText = "Тип элемента";
            this.dataGridView1.Columns[1].HeaderText = "Импеданс";
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

        //TODO: условная компиляция +
        //TODO: RSDN +
        /// <summary>
        /// Random
        /// </summary>
        public Random Rnd = new Random();

        //TODO: RSDN+
        /// <summary>
        /// Список рандомных элементов
        /// </summary>
        public List<ElementBase> ElementBases =>
            new List<ElementBase>()
            {
                new Resistor(Rnd.Next(0, 1000), "Резистор"),
                new Capacitor(Rnd.Next(0, 1000), 
                    Rnd.Next(0, 100), "Конденсатор"),
                new InductiveСoil(Rnd.Next(0, 1000), 
                    Rnd.Next(0, 100), "Катушка индуктивности")
            };

        /// <summary>
        /// Создание рандомного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomElementButton_Click(object sender, EventArgs e)
        {
            _elementList.Add(ElementBases[Rnd.Next(0, ElementBases.Count)]);
            dataGridView1.DataSource = _elementList;
        }

        /// <summary>
        /// Реализация проверки выбранных параметров на форме
        /// </summary>
        /// <returns></returns>
        private bool CheckSortParam()
        {
            if (this.ColumnSortComboBox.SelectedIndex == -1)
            {
                ErrorMessageBox("Пожалуйста, выберите тип столбца.");
                return true;
            }
            if (this.comboBoxSortingAction.SelectedIndex == -1)
            {
                ErrorMessageBox("Пожалуйста, выберите тип действие сортировки.");
                return true;
            }
            if (string.IsNullOrEmpty(DataSortTextBox.Text))
            {
                ErrorMessageBox("Пожалуйста, ввеедите значение которое хотите найти.");
                return true;
            }
            if (this.ColumnSortComboBox.SelectedIndex == 1                 
                && double.TryParse(DataSortTextBox.Text, out double res) ==  false)
            {
                ErrorMessageBox("Пожалуйста, ввеедите число.");
                return true;
            }
            return false;

        }


        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            //TODO: RSDN+
            var sortedEmployees = new BindingList<ElementBase>();
            

            if (CheckSortParam())
            {
                return;
            }
            if(_elementList.Count == 0)
            {
                ErrorMessageBox("Табица пуста.");
            }
            switch (ColumnSortComboBox.SelectedIndex)
            {
                case 0:
                    foreach (var element in _elementList)
                    {
                        if (element.TypeOfElements.ToLower() == DataSortTextBox.Text.ToLower())
                        {
                            sortedEmployees.Add(element);
                        }
                    }

                    break;
                
                case 1:
                    foreach (var element in _elementList)
                    {
                        switch(comboBoxSortingAction.Text)
                        {
                            case ">":
                                if (element.Impedance.Real > Convert.ToDouble(DataSortTextBox.Text)
                                    || element.Impedance.Imaginary > Convert.ToDouble(DataSortTextBox.Text))
                                {
                                    sortedEmployees.Add(element);
                                }
                                break;
                            case "=":
                                if (element.Impedance.Real == Convert.ToDouble(DataSortTextBox.Text)
                                    || element.Impedance.Imaginary == Convert.ToDouble(DataSortTextBox.Text))
                                {
                                    sortedEmployees.Add(element);
                                }
                                break;
                            case "<":
                                if (element.Impedance.Real < Convert.ToDouble(DataSortTextBox.Text)
                                    || element.Impedance.Imaginary < Convert.ToDouble(DataSortTextBox.Text))
                                {
                                    sortedEmployees.Add(element);
                                }
                                break;

                        }
                    }
                    break;
            }
            this.dataGridView1.DataSource = sortedEmployees;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Columns[0].HeaderText = "Тип элемента";
            this.dataGridView1.Columns[1].HeaderText = "Импеданс";
        }

    }
}
