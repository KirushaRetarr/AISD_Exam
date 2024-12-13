using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        // Класс для компонента
        public class Component
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ComponentType { get; set; }
            public string Specifications { get; set; }
            public decimal Price { get; set; }
            public int Compatibility { get; set; }
            public int Efficiency { get; set; }

            // Конструктор для удобства
            public Component(int id, string name, string componentType, string specifications, decimal price, int compatibility, int efficiency)
            {
                Id = id;
                Name = name;
                ComponentType = componentType;
                Specifications = specifications;
                Price = price;
                Compatibility = compatibility;
                Efficiency = efficiency;
            }
        }

        // Класс для узла односвязного списка
        public class Node
        {
            public Component Data { get; set; }
            public Node Next { get; set; }

            public Node(Component data)
            {
                Data = data;
                Next = null;
            }
        }

        // Класс для самого списка
        public class LinkedList
        {
            public Node Head { get; set; }

            public LinkedList()
            {
                Head = null;
            }

            // Добавление нового узла в конец списка
            public void Add(Component component)
            {
                Node newNode = new Node(component);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node current = Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            // Преобразование списка в DataGridView
            public void ToDataGridView(DataGridView dataGridView)
            {
                Node current = Head;
                while (current != null)
                {
                    dataGridView.Rows.Add(current.Data.Id, current.Data.Name, current.Data.ComponentType, current.Data.Specifications, current.Data.Price, current.Data.Compatibility, current.Data.Efficiency);
                    current = current.Next;
                }
            }

            // Метод для фильтрации и сортировки компонентов
            public void FilterAndSort(DataGridView dataGridView, string selectedType, int compatibility)
            {
                var filteredComponents = new System.Collections.Generic.List<Component>();

                // Фильтруем компоненты по типу и совместимости
                Node current = Head;
                while (current != null)
                {
                    if ((selectedType == "All" || current.Data.ComponentType == selectedType) && current.Data.Compatibility == compatibility)
                    {
                        filteredComponents.Add(current.Data);
                    }
                    current = current.Next;
                }

                // Сортируем компоненты по соотношению цена/производительность (от лучшего к худшему)
                var sortedComponents = filteredComponents.OrderBy(c => c.Efficiency).ToList();

                // Очищаем DataGridView и добавляем отсортированные данные
                dataGridView.Rows.Clear();
                foreach (var component in sortedComponents)
                {
                    dataGridView.Rows.Add(component.Id, component.Name, component.ComponentType, component.Specifications, component.Price, component.Compatibility, component.Efficiency);
                }
            }
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
            // Добавьте другие типы по аналогии

            // Получаем выбранную совместимость из TextBox или другого источника
            int compatibility = int.Parse(textBoxCompatibility.Text);

            // Применяем фильтрацию и сортировку
            componentList.FilterAndSort(dataGridView1, selectedType, compatibility);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
