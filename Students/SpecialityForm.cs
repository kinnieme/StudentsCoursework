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
    public partial class SpecialityForm : Form
    {
        public SpecialityForm()
        {
            InitializeComponent();
        }

        private void специальностьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специальностьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void SpecialityForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.studentsDataSet.Специальность);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            специальностьBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            специальностьBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            специальностьBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            специальностьBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            специальностьBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            специальностьBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специальностьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }
    }
}
