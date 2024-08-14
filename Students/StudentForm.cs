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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void студентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.studentsDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.studentsDataSet.Студент);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            студентBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StudentTableForm studentTableForm = new StudentTableForm();
            studentTableForm.Show();
        }
    }
}
