namespace Students
{
    partial class SessionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label номер_ведомостиLabel;
            System.Windows.Forms.Label номер_студентаLabel;
            System.Windows.Forms.Label номер_семестраLabel;
            System.Windows.Forms.Label номер_группыLabel;
            System.Windows.Forms.Label название_дисциплиныLabel;
            System.Windows.Forms.Label дата_сдачи_предметаLabel;
            System.Windows.Forms.Label оценкаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.studentsDataSet = new Students.StudentsDataSet();
            this.ведомость_сдачи_сессииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ведомость_сдачи_сессииTableAdapter = new Students.StudentsDataSetTableAdapters.Ведомость_сдачи_сессииTableAdapter();
            this.tableAdapterManager = new Students.StudentsDataSetTableAdapters.TableAdapterManager();
            this.группаTableAdapter = new Students.StudentsDataSetTableAdapters.ГруппаTableAdapter();
            this.перечень_дисциплинTableAdapter = new Students.StudentsDataSetTableAdapters.Перечень_дисциплинTableAdapter();
            this.студентTableAdapter = new Students.StudentsDataSetTableAdapters.СтудентTableAdapter();
            this.ведомость_сдачи_сессииBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_ведомостиTextBox = new System.Windows.Forms.TextBox();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_семестраNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.название_дисциплиныComboBox = new System.Windows.Forms.ComboBox();
            this.переченьдисциплинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_сдачи_предметаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.оценкаNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            номер_ведомостиLabel = new System.Windows.Forms.Label();
            номер_студентаLabel = new System.Windows.Forms.Label();
            номер_семестраLabel = new System.Windows.Forms.Label();
            номер_группыLabel = new System.Windows.Forms.Label();
            название_дисциплиныLabel = new System.Windows.Forms.Label();
            дата_сдачи_предметаLabel = new System.Windows.Forms.Label();
            оценкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_сдачи_сессииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_сдачи_сессииBindingNavigator)).BeginInit();
            this.ведомость_сдачи_сессииBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номер_семестраNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.переченьдисциплинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкаNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_ведомостиLabel
            // 
            номер_ведомостиLabel.AutoSize = true;
            номер_ведомостиLabel.Location = new System.Drawing.Point(50, 84);
            номер_ведомостиLabel.Name = "номер_ведомостиLabel";
            номер_ведомостиLabel.Size = new System.Drawing.Size(102, 13);
            номер_ведомостиLabel.TabIndex = 5;
            номер_ведомостиLabel.Text = "Номер ведомости:";
            // 
            // номер_студентаLabel
            // 
            номер_студентаLabel.AutoSize = true;
            номер_студентаLabel.Location = new System.Drawing.Point(60, 110);
            номер_студентаLabel.Name = "номер_студентаLabel";
            номер_студентаLabel.Size = new System.Drawing.Size(92, 13);
            номер_студентаLabel.TabIndex = 6;
            номер_студентаLabel.Text = "Номер студента:";
            // 
            // номер_семестраLabel
            // 
            номер_семестраLabel.AutoSize = true;
            номер_семестраLabel.Location = new System.Drawing.Point(56, 136);
            номер_семестраLabel.Name = "номер_семестраLabel";
            номер_семестраLabel.Size = new System.Drawing.Size(96, 13);
            номер_семестраLabel.TabIndex = 7;
            номер_семестраLabel.Text = "Номер семестра:";
            // 
            // номер_группыLabel
            // 
            номер_группыLabel.AutoSize = true;
            номер_группыLabel.Location = new System.Drawing.Point(53, 163);
            номер_группыLabel.Name = "номер_группыLabel";
            номер_группыLabel.Size = new System.Drawing.Size(99, 13);
            номер_группыLabel.TabIndex = 8;
            номер_группыLabel.Text = "Название группы:";
            // 
            // название_дисциплиныLabel
            // 
            название_дисциплиныLabel.AutoSize = true;
            название_дисциплиныLabel.Location = new System.Drawing.Point(27, 190);
            название_дисциплиныLabel.Name = "название_дисциплиныLabel";
            название_дисциплиныLabel.Size = new System.Drawing.Size(125, 13);
            название_дисциплиныLabel.TabIndex = 10;
            название_дисциплиныLabel.Text = "Название дисциплины:";
            // 
            // дата_сдачи_предметаLabel
            // 
            дата_сдачи_предметаLabel.AutoSize = true;
            дата_сдачи_предметаLabel.Location = new System.Drawing.Point(32, 217);
            дата_сдачи_предметаLabel.Name = "дата_сдачи_предметаLabel";
            дата_сдачи_предметаLabel.Size = new System.Drawing.Size(120, 13);
            дата_сдачи_предметаLabel.TabIndex = 12;
            дата_сдачи_предметаLabel.Text = "Дата сдачи предмета:";
            // 
            // оценкаLabel
            // 
            оценкаLabel.AutoSize = true;
            оценкаLabel.Location = new System.Drawing.Point(104, 242);
            оценкаLabel.Name = "оценкаLabel";
            оценкаLabel.Size = new System.Drawing.Size(48, 13);
            оценкаLabel.TabIndex = 14;
            оценкаLabel.Text = "Оценка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ведомость сдачи сессии";
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ведомость_сдачи_сессииBindingSource
            // 
            this.ведомость_сдачи_сессииBindingSource.DataMember = "Ведомость_сдачи_сессии";
            this.ведомость_сдачи_сессииBindingSource.DataSource = this.studentsDataSet;
            // 
            // ведомость_сдачи_сессииTableAdapter
            // 
            this.ведомость_сдачи_сессииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Students.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ведомость_сдачи_сессииTableAdapter = this.ведомость_сдачи_сессииTableAdapter;
            this.tableAdapterManager.ГруппаTableAdapter = this.группаTableAdapter;
            this.tableAdapterManager.Перечень_дисциплинTableAdapter = this.перечень_дисциплинTableAdapter;
            this.tableAdapterManager.СпециальностьTableAdapter = null;
            this.tableAdapterManager.СтудентTableAdapter = this.студентTableAdapter;
            this.tableAdapterManager.Учебный_планTableAdapter = null;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // перечень_дисциплинTableAdapter
            // 
            this.перечень_дисциплинTableAdapter.ClearBeforeFill = true;
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
            // 
            // ведомость_сдачи_сессииBindingNavigator
            // 
            this.ведомость_сдачи_сессииBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ведомость_сдачи_сессииBindingNavigator.BindingSource = this.ведомость_сдачи_сессииBindingSource;
            this.ведомость_сдачи_сессииBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ведомость_сдачи_сессииBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ведомость_сдачи_сессииBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem});
            this.ведомость_сдачи_сессииBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ведомость_сдачи_сессииBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ведомость_сдачи_сессииBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ведомость_сдачи_сессииBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ведомость_сдачи_сессииBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ведомость_сдачи_сессииBindingNavigator.Name = "ведомость_сдачи_сессииBindingNavigator";
            this.ведомость_сдачи_сессииBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ведомость_сдачи_сессииBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ведомость_сдачи_сессииBindingNavigator.TabIndex = 5;
            this.ведомость_сдачи_сессииBindingNavigator.Text = "bindingNavigator1";
            this.ведомость_сдачи_сессииBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ведомость_сдачи_сессииBindingNavigatorSaveItem
            // 
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ведомость_сдачи_сессииBindingNavigatorSaveItem.Image")));
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem.Name = "ведомость_сдачи_сессииBindingNavigatorSaveItem";
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ведомость_сдачи_сессииBindingNavigatorSaveItem.Click += new System.EventHandler(this.ведомость_сдачи_сессииBindingNavigatorSaveItem_Click_1);
            // 
            // номер_ведомостиTextBox
            // 
            this.номер_ведомостиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ведомость_сдачи_сессииBindingSource, "Номер_ведомости", true));
            this.номер_ведомостиTextBox.Location = new System.Drawing.Point(158, 81);
            this.номер_ведомостиTextBox.Name = "номер_ведомостиTextBox";
            this.номер_ведомостиTextBox.Size = new System.Drawing.Size(201, 20);
            this.номер_ведомостиTextBox.TabIndex = 6;
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this.studentsDataSet;
            // 
            // номер_семестраNumericUpDown
            // 
            this.номер_семестраNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ведомость_сдачи_сессииBindingSource, "Номер_семестра", true));
            this.номер_семестраNumericUpDown.Location = new System.Drawing.Point(158, 134);
            this.номер_семестраNumericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.номер_семестраNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.номер_семестраNumericUpDown.Name = "номер_семестраNumericUpDown";
            this.номер_семестраNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.номер_семестраNumericUpDown.TabIndex = 8;
            this.номер_семестраNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.studentsDataSet;
            // 
            // название_дисциплиныComboBox
            // 
            this.название_дисциплиныComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ведомость_сдачи_сессииBindingSource, "Название_дисциплины", true));
            this.название_дисциплиныComboBox.DataSource = this.переченьдисциплинBindingSource;
            this.название_дисциплиныComboBox.DisplayMember = "Название_дисциплины";
            this.название_дисциплиныComboBox.FormattingEnabled = true;
            this.название_дисциплиныComboBox.Location = new System.Drawing.Point(158, 187);
            this.название_дисциплиныComboBox.Name = "название_дисциплиныComboBox";
            this.название_дисциплиныComboBox.Size = new System.Drawing.Size(201, 21);
            this.название_дисциплиныComboBox.TabIndex = 11;
            // 
            // переченьдисциплинBindingSource
            // 
            this.переченьдисциплинBindingSource.DataMember = "Перечень_дисциплин";
            this.переченьдисциплинBindingSource.DataSource = this.studentsDataSet;
            // 
            // дата_сдачи_предметаDateTimePicker
            // 
            this.дата_сдачи_предметаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ведомость_сдачи_сессииBindingSource, "Дата_сдачи_предмета", true));
            this.дата_сдачи_предметаDateTimePicker.Location = new System.Drawing.Point(158, 214);
            this.дата_сдачи_предметаDateTimePicker.Name = "дата_сдачи_предметаDateTimePicker";
            this.дата_сдачи_предметаDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.дата_сдачи_предметаDateTimePicker.TabIndex = 13;
            // 
            // оценкаNumericUpDown
            // 
            this.оценкаNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ведомость_сдачи_сессииBindingSource, "Оценка", true));
            this.оценкаNumericUpDown.Location = new System.Drawing.Point(158, 240);
            this.оценкаNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.оценкаNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.оценкаNumericUpDown.Name = "оценкаNumericUpDown";
            this.оценкаNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.оценкаNumericUpDown.TabIndex = 15;
            this.оценкаNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ведомость_сдачи_сессииBindingSource, "Номер_группы", true));
            this.comboBox1.DataSource = this.группаBindingSource;
            this.comboBox1.DisplayMember = "Название_группы";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "Номер_группы";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ведомость_сдачи_сессииBindingSource, "Номер_студента", true));
            this.comboBox2.DataSource = this.студентBindingSource;
            this.comboBox2.DisplayMember = "ФИО_Студента";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "Номер_студента";
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(376, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(364, 23);
            this.button8.TabIndex = 48;
            this.button8.Text = "Табличный вид";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(376, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(364, 23);
            this.button7.TabIndex = 47;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(561, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 23);
            this.button6.TabIndex = 46;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(376, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Первая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Предыдущая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 288);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(оценкаLabel);
            this.Controls.Add(this.оценкаNumericUpDown);
            this.Controls.Add(дата_сдачи_предметаLabel);
            this.Controls.Add(this.дата_сдачи_предметаDateTimePicker);
            this.Controls.Add(название_дисциплиныLabel);
            this.Controls.Add(this.название_дисциплиныComboBox);
            this.Controls.Add(номер_группыLabel);
            this.Controls.Add(номер_семестраLabel);
            this.Controls.Add(this.номер_семестраNumericUpDown);
            this.Controls.Add(номер_студентаLabel);
            this.Controls.Add(номер_ведомостиLabel);
            this.Controls.Add(this.номер_ведомостиTextBox);
            this.Controls.Add(this.ведомость_сдачи_сессииBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionForm";
            this.Text = "Таблица \"Ведомость сдачи сессии\"";
            this.Load += new System.EventHandler(this.SessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_сдачи_сессииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_сдачи_сессииBindingNavigator)).EndInit();
            this.ведомость_сдачи_сессииBindingNavigator.ResumeLayout(false);
            this.ведомость_сдачи_сессииBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номер_семестраNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.переченьдисциплинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкаNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource ведомость_сдачи_сессииBindingSource;
        private StudentsDataSetTableAdapters.Ведомость_сдачи_сессииTableAdapter ведомость_сдачи_сессииTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ведомость_сдачи_сессииBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ведомость_сдачи_сессииBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_ведомостиTextBox;
        private System.Windows.Forms.NumericUpDown номер_семестраNumericUpDown;
        private System.Windows.Forms.ComboBox название_дисциплиныComboBox;
        private System.Windows.Forms.DateTimePicker дата_сдачи_предметаDateTimePicker;
        private System.Windows.Forms.NumericUpDown оценкаNumericUpDown;
        private StudentsDataSetTableAdapters.СтудентTableAdapter студентTableAdapter;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private StudentsDataSetTableAdapters.Перечень_дисциплинTableAdapter перечень_дисциплинTableAdapter;
        private System.Windows.Forms.BindingSource переченьдисциплинBindingSource;
        private StudentsDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}