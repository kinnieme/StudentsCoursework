using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class StudentTableForm : Form
    {
        public StudentTableForm()
        {
            InitializeComponent();
        }

        private void студентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void StudentTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.studentsDataSet.Студент);

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
                case 7:
                    {
                        column = dataGridViewTextBoxColumn9;
                        break;
                    }
                case 8:
                    {
                        column = dataGridViewTextBoxColumn10;
                        break;
                    }
                case 9:
                    {
                        column = dataGridViewTextBoxColumn11;
                        break;
                    }
                case 10:
                    {
                        column = dataGridViewTextBoxColumn12;
                        break;
                    }
            }
            if (radioButton1.Checked)
                студентDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
            else
                студентDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентBindingSource.Filter = "ФИО_студента='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < студентDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < студентDataGridView.RowCount - 1; j++)
                {
                    студентDataGridView[i, j].Style.BackColor = Color.White;
                    студентDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < студентDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < студентDataGridView.RowCount - 1; j++)
                {
                    if (студентDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        студентDataGridView[i, j].Style.BackColor = Color.Blue;
                        студентDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
