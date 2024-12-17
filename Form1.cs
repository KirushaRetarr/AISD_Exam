using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            string selectedType = "All";
            if (checkBoxProcessor.Checked)
                selectedType = "Processor";
            if (checkBoxGraphicsCard.Checked)
                selectedType = "Graphics Card";
            if (checkBoxMotherboard.Checked)
                selectedType = "Motherboard";
            if (checkBoxCase.Checked)
                selectedType = "Case";
            if (checkBoxRAM.Checked)
                selectedType = "RAM";
            if (checkBoxStorage.Checked)
                selectedType = "Storage";

            // Проверка на выбор в ComboBox
            int compatibility = 0; // Значение по умолчанию
            if (comboBox1.SelectedItem != null && int.TryParse(comboBox1.SelectedItem.ToString(), out int result))
            {
                compatibility = result;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите значение совместимости из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxProcessor.Checked = false;
                checkBoxGraphicsCard.Checked = false;
                checkBoxMotherboard.Checked = false;
                checkBoxCase.Checked = false;
                checkBoxRAM.Checked = false;
                checkBoxStorage.Checked = false;
                return; // Прерываем выполнение метода
            }

            // Применяем фильтрацию и сортировку
            componentList.FilterAndSort(dataGridView1, selectedType, compatibility);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Снимаем все чекбоксы
            checkBoxProcessor.Checked = false;
            checkBoxGraphicsCard.Checked = false;
            checkBoxMotherboard.Checked = false;
            checkBoxCase.Checked = false;
            checkBoxRAM.Checked = false;
            checkBoxStorage.Checked = false;

            // Сбрасываем ComboBox
            comboBox1.SelectedIndex = -1;

            // Очищаем DataGridView и загружаем все данные
            dataGridView1.Rows.Clear();
            componentList.ToDataGridView(dataGridView1);
        }
    }
}
