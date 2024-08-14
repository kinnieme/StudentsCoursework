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
    public partial class SessionForm : Form
    {
        public SessionForm()
        {
            InitializeComponent();
        }

        private void ведомость_сдачи_сессииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ведомость_сдачи_сессииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void ведомость_сдачи_сессииBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ведомость_сдачи_сессииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.studentsDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Перечень_дисциплин". При необходимости она может быть перемещена или удалена.
            this.перечень_дисциплинTableAdapter.Fill(this.studentsDataSet.Перечень_дисциплин);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студент". При необходимости она может быть перемещена или удалена.
            this.студентTableAdapter.Fill(this.studentsDataSet.Студент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Ведомость_сдачи_сессии". При необходимости она может быть перемещена или удалена.
            this.ведомость_сдачи_сессииTableAdapter.Fill(this.studentsDataSet.Ведомость_сдачи_сессии);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ведомость_сдачи_сессииBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ведомость_сдачи_сессииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SessionTableForm sessionTableForm = new SessionTableForm();
            sessionTableForm.Show();
        }
    }
}
