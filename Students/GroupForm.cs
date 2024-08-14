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
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private void группаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.studentsDataSet.Специальность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.studentsDataSet.Группа);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            группаBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            группаBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            группаBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            группаBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            группаBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            группаBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GroupTableForm groupTableForm = new GroupTableForm();
            groupTableForm.Show();
        }
    }
}
