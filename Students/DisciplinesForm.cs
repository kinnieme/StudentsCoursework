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
    public partial class DisciplinesForm : Form
    {
        public DisciplinesForm()
        {
            InitializeComponent();
        }

        private void перечень_дисциплинBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.перечень_дисциплинBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void DisciplinesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Перечень_дисциплин". При необходимости она может быть перемещена или удалена.
            this.перечень_дисциплинTableAdapter.Fill(this.studentsDataSet.Перечень_дисциплин);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            перечень_дисциплинBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            перечень_дисциплинBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            перечень_дисциплинBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            перечень_дисциплинBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            перечень_дисциплинBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            перечень_дисциплинBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.перечень_дисциплинBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }
    }
}
