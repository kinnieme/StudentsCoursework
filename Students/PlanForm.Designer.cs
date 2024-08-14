namespace Students
{
    partial class PlanForm
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
            System.Windows.Forms.Label номер_специальностиLabel;
            System.Windows.Forms.Label название_дисциплиныLabel;
            System.Windows.Forms.Label номер_семестраLabel;
            System.Windows.Forms.Label формы_аттестацииLabel;
            System.Windows.Forms.Label виды_занятийLabel;
            System.Windows.Forms.Label трудоемкостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanForm));
            this.label1 = new System.Windows.Forms.Label();
            this.studentsDataSet = new Students.StudentsDataSet();
            this.учебный_планBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учебный_планTableAdapter = new Students.StudentsDataSetTableAdapters.Учебный_планTableAdapter();
            this.tableAdapterManager = new Students.StudentsDataSetTableAdapters.TableAdapterManager();
            this.перечень_дисциплинTableAdapter = new Students.StudentsDataSetTableAdapters.Перечень_дисциплинTableAdapter();
            this.специальностьTableAdapter = new Students.StudentsDataSetTableAdapters.СпециальностьTableAdapter();
            this.учебный_планBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.учебный_планBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.специальностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.название_дисциплиныComboBox = new System.Windows.Forms.ComboBox();
            this.переченьдисциплинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_семестраNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.формы_аттестацииComboBox = new System.Windows.Forms.ComboBox();
            this.виды_занятийComboBox = new System.Windows.Forms.ComboBox();
            this.трудоемкостьNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            номер_специальностиLabel = new System.Windows.Forms.Label();
            название_дисциплиныLabel = new System.Windows.Forms.Label();
            номер_семестраLabel = new System.Windows.Forms.Label();
            формы_аттестацииLabel = new System.Windows.Forms.Label();
            виды_занятийLabel = new System.Windows.Forms.Label();
            трудоемкостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_планBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_планBindingNavigator)).BeginInit();
            this.учебный_планBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.переченьдисциплинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номер_семестраNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трудоемкостьNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_специальностиLabel
            // 
            номер_специальностиLabel.AutoSize = true;
            номер_специальностиLabel.Location = new System.Drawing.Point(22, 63);
            номер_специальностиLabel.Name = "номер_специальностиLabel";
            номер_специальностиLabel.Size = new System.Drawing.Size(140, 13);
            номер_специальностиLabel.TabIndex = 6;
            номер_специальностиLabel.Text = "Название специальности:";
            // 
            // название_дисциплиныLabel
            // 
            название_дисциплиныLabel.AutoSize = true;
            название_дисциплиныLabel.Location = new System.Drawing.Point(37, 90);
            название_дисциплиныLabel.Name = "название_дисциплиныLabel";
            название_дисциплиныLabel.Size = new System.Drawing.Size(125, 13);
            название_дисциплиныLabel.TabIndex = 7;
            название_дисциплиныLabel.Text = "Название дисциплины:";
            // 
            // номер_семестраLabel
            // 
            номер_семестраLabel.AutoSize = true;
            номер_семестраLabel.Location = new System.Drawing.Point(66, 116);
            номер_семестраLabel.Name = "номер_семестраLabel";
            номер_семестраLabel.Size = new System.Drawing.Size(96, 13);
            номер_семестраLabel.TabIndex = 8;
            номер_семестраLabel.Text = "Номер семестра:";
            // 
            // формы_аттестацииLabel
            // 
            формы_аттестацииLabel.AutoSize = true;
            формы_аттестацииLabel.Location = new System.Drawing.Point(53, 143);
            формы_аттестацииLabel.Name = "формы_аттестацииLabel";
            формы_аттестацииLabel.Size = new System.Drawing.Size(109, 13);
            формы_аттестацииLabel.TabIndex = 9;
            формы_аттестацииLabel.Text = "Формы аттестации:";
            // 
            // виды_занятийLabel
            // 
            виды_занятийLabel.AutoSize = true;
            виды_занятийLabel.Location = new System.Drawing.Point(81, 170);
            виды_занятийLabel.Name = "виды_занятийLabel";
            виды_занятийLabel.Size = new System.Drawing.Size(81, 13);
            виды_занятийLabel.TabIndex = 10;
            виды_занятийLabel.Text = "Виды занятий:";
            // 
            // трудоемкостьLabel
            // 
            трудоемкостьLabel.AutoSize = true;
            трудоемкостьLabel.Location = new System.Drawing.Point(79, 196);
            трудоемкостьLabel.Name = "трудоемкостьLabel";
            трудоемкостьLabel.Size = new System.Drawing.Size(83, 13);
            трудоемкостьLabel.TabIndex = 12;
            трудоемкостьLabel.Text = "Трудоемкость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Учебные планы";
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учебный_планBindingSource
            // 
            this.учебный_планBindingSource.DataMember = "Учебный_план";
            this.учебный_планBindingSource.DataSource = this.studentsDataSet;
            // 
            // учебный_планTableAdapter
            // 
            this.учебный_планTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Students.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ведомость_сдачи_сессииTableAdapter = null;
            this.tableAdapterManager.ГруппаTableAdapter = null;
            this.tableAdapterManager.Перечень_дисциплинTableAdapter = this.перечень_дисциплинTableAdapter;
            this.tableAdapterManager.СпециальностьTableAdapter = this.специальностьTableAdapter;
            this.tableAdapterManager.СтудентTableAdapter = null;
            this.tableAdapterManager.Учебный_планTableAdapter = this.учебный_планTableAdapter;
            // 
            // перечень_дисциплинTableAdapter
            // 
            this.перечень_дисциплинTableAdapter.ClearBeforeFill = true;
            // 
            // специальностьTableAdapter
            // 
            this.специальностьTableAdapter.ClearBeforeFill = true;
            // 
            // учебный_планBindingNavigator
            // 
            this.учебный_планBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.учебный_планBindingNavigator.BindingSource = this.учебный_планBindingSource;
            this.учебный_планBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.учебный_планBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.учебный_планBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.учебный_планBindingNavigatorSaveItem});
            this.учебный_планBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.учебный_планBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.учебный_планBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.учебный_планBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.учебный_планBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.учебный_планBindingNavigator.Name = "учебный_планBindingNavigator";
            this.учебный_планBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.учебный_планBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.учебный_планBindingNavigator.TabIndex = 6;
            this.учебный_планBindingNavigator.Text = "bindingNavigator1";
            this.учебный_планBindingNavigator.Visible = false;
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
            // учебный_планBindingNavigatorSaveItem
            // 
            this.учебный_планBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.учебный_планBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("учебный_планBindingNavigatorSaveItem.Image")));
            this.учебный_планBindingNavigatorSaveItem.Name = "учебный_планBindingNavigatorSaveItem";
            this.учебный_планBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.учебный_планBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.учебный_планBindingNavigatorSaveItem.Click += new System.EventHandler(this.учебный_планBindingNavigatorSaveItem_Click);
            // 
            // специальностьBindingSource
            // 
            this.специальностьBindingSource.DataMember = "Специальность";
            this.специальностьBindingSource.DataSource = this.studentsDataSetBindingSource;
            // 
            // studentsDataSetBindingSource
            // 
            this.studentsDataSetBindingSource.DataSource = this.studentsDataSet;
            this.studentsDataSetBindingSource.Position = 0;
            // 
            // название_дисциплиныComboBox
            // 
            this.название_дисциплиныComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учебный_планBindingSource, "Название_дисциплины", true));
            this.название_дисциплиныComboBox.DataSource = this.переченьдисциплинBindingSource;
            this.название_дисциплиныComboBox.DisplayMember = "Название_дисциплины";
            this.название_дисциплиныComboBox.FormattingEnabled = true;
            this.название_дисциплиныComboBox.Location = new System.Drawing.Point(168, 87);
            this.название_дисциплиныComboBox.Name = "название_дисциплиныComboBox";
            this.название_дисциплиныComboBox.Size = new System.Drawing.Size(192, 21);
            this.название_дисциплиныComboBox.TabIndex = 8;
            // 
            // переченьдисциплинBindingSource
            // 
            this.переченьдисциплинBindingSource.DataMember = "Перечень_дисциплин";
            this.переченьдисциплинBindingSource.DataSource = this.studentsDataSet;
            // 
            // номер_семестраNumericUpDown
            // 
            this.номер_семестраNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учебный_планBindingSource, "Номер_семестра", true));
            this.номер_семестраNumericUpDown.Location = new System.Drawing.Point(168, 114);
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
            this.номер_семестраNumericUpDown.TabIndex = 9;
            this.номер_семестраNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // формы_аттестацииComboBox
            // 
            this.формы_аттестацииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учебный_планBindingSource, "Формы_аттестации", true));
            this.формы_аттестацииComboBox.FormattingEnabled = true;
            this.формы_аттестацииComboBox.Items.AddRange(new object[] {
            "Зачет",
            "Экзамен"});
            this.формы_аттестацииComboBox.Location = new System.Drawing.Point(168, 140);
            this.формы_аттестацииComboBox.Name = "формы_аттестацииComboBox";
            this.формы_аттестацииComboBox.Size = new System.Drawing.Size(192, 21);
            this.формы_аттестацииComboBox.TabIndex = 10;
            // 
            // виды_занятийComboBox
            // 
            this.виды_занятийComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учебный_планBindingSource, "Виды_занятий", true));
            this.виды_занятийComboBox.FormattingEnabled = true;
            this.виды_занятийComboBox.Items.AddRange(new object[] {
            "Лекция",
            "Практика"});
            this.виды_занятийComboBox.Location = new System.Drawing.Point(168, 167);
            this.виды_занятийComboBox.Name = "виды_занятийComboBox";
            this.виды_занятийComboBox.Size = new System.Drawing.Size(192, 21);
            this.виды_занятийComboBox.TabIndex = 11;
            // 
            // трудоемкостьNumericUpDown
            // 
            this.трудоемкостьNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учебный_планBindingSource, "Трудоемкость", true));
            this.трудоемкостьNumericUpDown.Location = new System.Drawing.Point(168, 194);
            this.трудоемкостьNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.трудоемкостьNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.трудоемкостьNumericUpDown.Name = "трудоемкостьNumericUpDown";
            this.трудоемкостьNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.трудоемкостьNumericUpDown.TabIndex = 13;
            this.трудоемкостьNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.учебный_планBindingSource, "Номер_специальности", true));
            this.comboBox1.DataSource = this.специальностьBindingSource;
            this.comboBox1.DisplayMember = "Название_специальности";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Номер_специальности";
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(510, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(364, 23);
            this.button8.TabIndex = 56;
            this.button8.Text = "Табличный вид";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(510, 147);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(364, 23);
            this.button7.TabIndex = 55;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(695, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 23);
            this.button6.TabIndex = 54;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(510, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(695, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 23);
            this.button4.TabIndex = 52;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "Первая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Предыдущая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 245);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(трудоемкостьLabel);
            this.Controls.Add(this.трудоемкостьNumericUpDown);
            this.Controls.Add(виды_занятийLabel);
            this.Controls.Add(this.виды_занятийComboBox);
            this.Controls.Add(формы_аттестацииLabel);
            this.Controls.Add(this.формы_аттестацииComboBox);
            this.Controls.Add(номер_семестраLabel);
            this.Controls.Add(this.номер_семестраNumericUpDown);
            this.Controls.Add(название_дисциплиныLabel);
            this.Controls.Add(this.название_дисциплиныComboBox);
            this.Controls.Add(номер_специальностиLabel);
            this.Controls.Add(this.учебный_планBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlanForm";
            this.Text = "Таблица \"Учебные планы\"";
            this.Load += new System.EventHandler(this.PlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_планBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебный_планBindingNavigator)).EndInit();
            this.учебный_планBindingNavigator.ResumeLayout(false);
            this.учебный_планBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.специальностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.переченьдисциплинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номер_семестраNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трудоемкостьNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource учебный_планBindingSource;
        private StudentsDataSetTableAdapters.Учебный_планTableAdapter учебный_планTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator учебный_планBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton учебный_планBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox название_дисциплиныComboBox;
        private System.Windows.Forms.NumericUpDown номер_семестраNumericUpDown;
        private System.Windows.Forms.ComboBox формы_аттестацииComboBox;
        private System.Windows.Forms.ComboBox виды_занятийComboBox;
        private System.Windows.Forms.NumericUpDown трудоемкостьNumericUpDown;
        private StudentsDataSetTableAdapters.Перечень_дисциплинTableAdapter перечень_дисциплинTableAdapter;
        private System.Windows.Forms.BindingSource переченьдисциплинBindingSource;
        private StudentsDataSetTableAdapters.СпециальностьTableAdapter специальностьTableAdapter;
        private System.Windows.Forms.BindingSource studentsDataSetBindingSource;
        private System.Windows.Forms.BindingSource специальностьBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
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