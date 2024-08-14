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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecialityForm specialityForm = new SpecialityForm();
            specialityForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlanForm planForm = new PlanForm();
            planForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SessionForm sessionForm = new SessionForm();
            sessionForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisciplinesForm disciplinesForm = new DisciplinesForm();
            disciplinesForm.Show();
        }
    }
}
