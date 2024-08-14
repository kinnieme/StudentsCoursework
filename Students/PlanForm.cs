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
    public partial class PlanForm : Form
    {
        public PlanForm()
        {
            InitializeComponent();
        }

        private void учебный_планBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учебный_планBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void PlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.studentsDataSet.Специальность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Перечень_дисциплин". При необходимости она может быть перемещена или удалена.
            this.перечень_дисциплинTableAdapter.Fill(this.studentsDataSet.Перечень_дисциплин);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Учебный_план". При необходимости она может быть перемещена или удалена.
            this.учебный_планTableAdapter.Fill(this.studentsDataSet.Учебный_план);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            учебный_планBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учебный_планBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlanTableForm planTableForm = new PlanTableForm();
            planTableForm.Show();
        }
    }
}
