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
            this.comboBoxSortingAction.SelectedIndexChanged +=  ColumnSortComboBox_SelectedIndexChanged;
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
            addElements.ElementAdded += (oElment, argsElement)
                =>
            {
                _elementList.Add(argsElement.Element);
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
            
            if(dataGridView1.RowCount < 0)
            {
                ErrorMessageBox("Таблица пуста, невозможно удаление.");
            }

            if (_checkingForSorting == true)
            {
                ErrorMessageBox("Отсортированные элементы нельзя удалять.");
            }

            foreach (DataGridViewRow row  in dataGridView1.SelectedRows)
            {
                _elementList.RemoveAt(row.Index);
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
            }
            catch (ArgumentException _)
            {
                ErrorMessageBox("Файл поврежден");
            }
            catch (InvalidOperationException q )
            {
                ErrorMessageBox("Структура файла изменена");
            }

        }
        
        /// <summary>
        /// Проверка на сортировку
        /// </summary>
        private bool _checkingForSorting;

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
            _checkingForSorting = false;
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
        //TODO: Опечатки+
#if !RELEASE
        /// <summary>
        /// Random
        /// </summary>
        private Random Rnd = new Random();
        
        /// <summary>
        /// Список рандомных элементов
        /// </summary>
        private List<ElementBase> ElementBases =>
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
#endif
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
            var sortedEmployees = new BindingList<ElementBase>();

            _checkingForSorting = true;
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
                        if (element.TypeOfElements.ToLower().IndexOf(DataSortTextBox.Text.ToLower()) > -1)
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

        /// <summary>
        /// Скрывает лишнее от пользователя при сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColumnSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColumnSortComboBox.SelectedIndex)
            {
                case 0:
                    labelSortAction.Visible = false;
                    comboBoxSortingAction.SelectedIndex = 1;
                    comboBoxSortingAction.Visible = false;
                    break;
                case 1:
                    labelSortAction.Visible = true;
                    comboBoxSortingAction.Visible = true;
                    break;
            }
        }
    }
}
