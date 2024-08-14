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
    public partial class GroupTableForm : Form
    {
        public GroupTableForm()
        {
            InitializeComponent();
        }

        private void группаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void GroupTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.studentsDataSet.Специальность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.studentsDataSet.Группа);

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

        private void группаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            }
            if (radioButton1.Checked)
                группаDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
            else
                группаDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            группаBindingSource.Filter = "Номер_специальности='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            группаBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < группаDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < группаDataGridView.RowCount - 1; j++)
                {
                    группаDataGridView[i, j].Style.BackColor = Color.White;
                    группаDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < группаDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < группаDataGridView.RowCount - 1; j++)
                {
                    if (группаDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        группаDataGridView[i, j].Style.BackColor = Color.Blue;
                        группаDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
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
                SqlCommand command = new SqlCommand("ПолучитьУчебныеГруппыПоСпециальности", connection);
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
                    resultsForm.Text = "Учебные группы по специальности";
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
