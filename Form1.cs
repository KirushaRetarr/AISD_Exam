using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Подключаем пространство имен для работы с файлами
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using ClassLibrary1;

namespace AISD_Exam
{
    public partial class Form1 : Form
    {

        private LinkedList componentList = new LinkedList(); // Список компонентов
        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
        }

        // Метод для загрузки данных из файла
        public void LoadDataFromFile()
        {
            try
            {
                // Путь к файлу с данными
                string filePath = @"D:\bd.txt"; // Замените на путь к вашему файлу

                // Чтение строк из файла
                string[] lines = File.ReadAllLines(filePath);

                // Создаем список компонентов
                componentList = new LinkedList();

                // Обработка каждой строки и добавление данных в список
                foreach (string line in lines)
                {
                    // Разделяем строку на части
                    string[] parts = line.Split(',');

                    // Создаем компонент и добавляем его в список
                    Component component = new Component(
                        int.Parse(parts[0]),
                        parts[1].Trim('"'),
                        parts[2].Trim('"'),
                        parts[3].Trim('"'),
                        decimal.Parse(parts[4]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])
                    );
                    componentList.Add(component);
                }

                // Очистим DataGridView перед добавлением новых данных
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Добавляем столбцы в DataGridView
                dataGridView1.Columns.Add("Id", "ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("ComponentType", "Component Type");
                dataGridView1.Columns.Add("Specifications", "Specifications");
                dataGridView1.Columns.Add("Price", "Price");
                dataGridView1.Columns.Add("Compatibility", "Compatibility");
                dataGridView1.Columns.Add("Efficiency", "Efficiency");

                // Преобразуем список в DataGridView
                componentList.ToDataGridView(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик изменения состояния чекбоксов
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Определяем, какой тип компонента выбран
            string selectedType = "All"; // по умолчанию показываем все типы
            if (checkBoxProcessor.Checked)
                selectedType = "Processor";
            else if (checkBoxGraphicsCard.Checked)
                selectedType = "Graphics Card";
            else if (checkBoxMotherboard.Checked)
                selectedType = "Motherboard";
            else if (checkBoxCase.Checked)
                selectedType = "Case";
            else if (checkBoxRAM.Checked)
                selectedType = "RAM";
            else if (checkBoxStorage.Checked)
                selectedType = "Storage";
            // Добавьте другие типы по аналогии

            // Получаем выбранную совместимость из ComboBox
            int compatibility = int.Parse(comboBox1.SelectedItem.ToString());

            // Применяем фильтрацию и сортировку
            componentList.FilterAndSort(dataGridView1, selectedType, compatibility);
        }
    }
}
