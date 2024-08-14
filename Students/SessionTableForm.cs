using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class SessionTableForm : Form
    {
        public SessionTableForm()
        {
            InitializeComponent();
        }

        private void ведомость_сдачи_сессииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ведомость_сдачи_сессииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

           
        }

        private void SessionTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.studentsDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.studentsDataSet.Студент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Ведомость_сдачи_сессии". При необходимости она может быть перемещена или удалена.
            this.ведомость_сдачи_сессииTableAdapter.Fill(this.studentsDataSet.Ведомость_сдачи_сессии);

            LoadGroupsForAverageScore();
            LoadStudents();
        }
        private void LoadStudents()
        {
            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ФИО_Студента FROM Студент", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    comboBox3.DataSource = dataTable;
                    comboBox3.DisplayMember = "ФИО_Студента";
                    comboBox3.ValueMember = "ФИО_Студента";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        private void LoadGroupsForAverageScore()
        {
            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Название_группы FROM Группа", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    comboBox2.DataSource = dataTable;
                    comboBox2.DisplayMember = "Название_группы";
                    comboBox2.ValueMember = "Название_группы";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn column = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    {
                        column = dataGridViewTextBoxColumn2;
                        break;
                    }
                case 1:
                    {
                        column = dataGridViewTextBoxColumn3;
                        break;
                    }
                case 2:
                    {
                        column = dataGridViewTextBoxColumn4;
                        break;
                    }
                case 3:
                    {
                        column = dataGridViewTextBoxColumn5;
                        break;
                    }
                case 4:
                    {
                        column = dataGridViewTextBoxColumn6;
                        break;
                    }
                case 5:
                    {
                        column = dataGridViewTextBoxColumn7;
                        break;
                    }
                case 6:
                    {
                        column = dataGridViewTextBoxColumn8;
                        break;
                    }
            }
            if (radioButton1.Checked)
                ведомость_сдачи_сессииDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
            else
                ведомость_сдачи_сессииDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.Filter = "Название_дисциплины='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ведомость_сдачи_сессииDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < ведомость_сдачи_сессииDataGridView.RowCount - 1; j++)
                {
                    ведомость_сдачи_сессииDataGridView[i, j].Style.BackColor = Color.White;
                    ведомость_сдачи_сессииDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < ведомость_сдачи_сессииDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < ведомость_сдачи_сессииDataGridView.RowCount - 1; j++)
                {
                    if (ведомость_сдачи_сессииDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        ведомость_сдачи_сессииDataGridView[i, j].Style.BackColor = Color.Blue;
                        ведомость_сдачи_сессииDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ПолучитьСписокСтудентовСЗадолженностями", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Открытие диалогового окна с результатами
                    Form resultsForm = new Form();
                    DataGridView resultsGrid = new DataGridView { DataSource = dataTable, Dock = DockStyle.Fill };
                    resultsForm.Controls.Add(resultsGrid);
                    resultsForm.Text = "Список студентов с задолженностями";
                    resultsForm.Width = 800;
                    resultsForm.Height = 600;
                    resultsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ПолучитьСписокСтудентовСОтличнымиОценками", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Открытие диалогового окна с результатами
                    Form resultsForm = new Form();
                    DataGridView resultsGrid = new DataGridView { DataSource = dataTable, Dock = DockStyle.Fill };
                    resultsForm.Controls.Add(resultsGrid);
                    resultsForm.Text = "Список студентов с отличными оценками";
                    resultsForm.Width = 800;
                    resultsForm.Height = 600;
                    resultsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string studentName = comboBox3.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Пожалуйста, выберите студента.");
                return;
            }

            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ПолучитьУспеваемостьСтудентаПоФИО", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ФИО_Студента", studentName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Проверка, заполнена ли таблица данными
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Данные не найдены.");
                        return;
                    }

                    // Открытие диалогового окна с результатами
                    Form resultsForm = new Form();
                    DataGridView resultsGrid = new DataGridView { DataSource = dataTable, Dock = DockStyle.Fill };
                    resultsForm.Controls.Add(resultsGrid);
                    resultsForm.Text = "Успеваемость студента по предметам";
                    resultsForm.Width = 800;
                    resultsForm.Height = 600;
                    resultsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string groupName = comboBox2.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Пожалуйста, выберите группу.");
                return;
            }

            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ПолучитьСреднийБаллГруппыПоПредметам", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Название_группы", groupName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Проверка, заполнена ли таблица данными
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Данные не найдены.");
                        return;
                    }

                    // Открытие диалогового окна с результатами
                    Form resultsForm = new Form();
                    DataGridView resultsGrid = new DataGridView { DataSource = dataTable, Dock = DockStyle.Fill };
                    resultsForm.Controls.Add(resultsGrid);
                    resultsForm.Text = "Средний балл группы по предметам";
                    resultsForm.Width = 800;
                    resultsForm.Height = 600;
                    resultsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
