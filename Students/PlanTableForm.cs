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
    public partial class PlanTableForm : Form
    {
        public PlanTableForm()
        {
            InitializeComponent();
        }

        private void учебный_планBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учебный_планBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void PlanTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.studentsDataSet.Специальность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Учебный_план". При необходимости она может быть перемещена или удалена.
            this.учебный_планTableAdapter.Fill(this.studentsDataSet.Учебный_план);

            LoadSpecialties();
        }
        private void LoadSpecialties()
        {
            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Название_специальности FROM Специальность", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    comboBox2.DataSource = dataTable;
                    comboBox2.DisplayMember = "Название_специальности";
                    comboBox2.ValueMember = "Название_специальности";
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

        private void button2_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.Filter = "Номер_специальности='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < учебный_планDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < учебный_планDataGridView.RowCount - 1; j++)
                {
                    учебный_планDataGridView[i, j].Style.BackColor = Color.White;
                    учебный_планDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < учебный_планDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < учебный_планDataGridView.RowCount - 1; j++)
                {
                    if (учебный_планDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        учебный_планDataGridView[i, j].Style.BackColor = Color.Blue;
                        учебный_планDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
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
            }
            if (radioButton1.Checked)
                учебный_планDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
            else
                учебный_планDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string specialtyName = comboBox2.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(specialtyName))
            {
                MessageBox.Show("Пожалуйста, выберите специальность.");
                return;
            }

            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ПолучитьУчебныеПланыПоСпециальности", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Название_специальности", specialtyName);

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
                    resultsForm.Text = "Учебные планы по специальностям";
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string specialtyName = comboBox2.SelectedValue?.ToString();
            int semesterNumber = (int)numericUpDown1.Value;

            if (string.IsNullOrEmpty(specialtyName))
            {
                MessageBox.Show("Пожалуйста, выберите специальность.");
                return;
            }

            string connectionString = "Data Source=HOME-PC;Initial Catalog=Students;Integrated Security=True;Encrypt=False"; // Замените на вашу строку подключения

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ПолучитьДисциплиныПоСпециальностиИСеместру", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Название_специальности", specialtyName);
                command.Parameters.AddWithValue("@Номер_семестра", semesterNumber);

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
                    resultsForm.Text = "Дисциплины по специальности в разрезе семестров";
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
