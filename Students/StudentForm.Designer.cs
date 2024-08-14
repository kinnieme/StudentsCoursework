namespace Students
{
    partial class StudentForm
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
            System.Windows.Forms.Label номер_группыLabel;
            System.Windows.Forms.Label фИО_СтудентаLabel;
            System.Windows.Forms.Label адрес_проживанияLabel;
            System.Windows.Forms.Label контактный_номер_телефонаLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label пол_студентаLabel;
            System.Windows.Forms.Label серия_и_номер_паспортаLabel;
            System.Windows.Forms.Label сНИЛСLabel;
            System.Windows.Forms.Label номер_ИННLabel;
            System.Windows.Forms.Label год_окончания_школыLabel;
            System.Windows.Forms.Label номер_аттестатаLabel;
            System.Windows.Forms.Label воинское_удостоверениеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.studentsDataSet = new Students.StudentsDataSet();
            this.студентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентTableAdapter = new Students.StudentsDataSetTableAdapters.СтудентTableAdapter();
            this.tableAdapterManager = new Students.StudentsDataSetTableAdapters.TableAdapterManager();
            this.группаTableAdapter = new Students.StudentsDataSetTableAdapters.ГруппаTableAdapter();
            this.студентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.студентBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фИО_СтудентаTextBox = new System.Windows.Forms.TextBox();
            this.адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.пол_студентаComboBox = new System.Windows.Forms.ComboBox();
            this.год_окончания_школыTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            номер_группыLabel = new System.Windows.Forms.Label();
            фИО_СтудентаLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            контактный_номер_телефонаLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            пол_студентаLabel = new System.Windows.Forms.Label();
            серия_и_номер_паспортаLabel = new System.Windows.Forms.Label();
            сНИЛСLabel = new System.Windows.Forms.Label();
            номер_ИННLabel = new System.Windows.Forms.Label();
            год_окончания_школыLabel = new System.Windows.Forms.Label();
            номер_аттестатаLabel = new System.Windows.Forms.Label();
            воинское_удостоверениеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingNavigator)).BeginInit();
            this.студентBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_группыLabel
            // 
            номер_группыLabel.AutoSize = true;
            номер_группыLabel.Location = new System.Drawing.Point(72, 77);
            номер_группыLabel.Name = "номер_группыLabel";
            номер_группыLabel.Size = new System.Drawing.Size(99, 13);
            номер_группыLabel.TabIndex = 6;
            номер_группыLabel.Text = "Название группы:";
            // 
            // фИО_СтудентаLabel
            // 
            фИО_СтудентаLabel.AutoSize = true;
            фИО_СтудентаLabel.Location = new System.Drawing.Point(85, 104);
            фИО_СтудентаLabel.Name = "фИО_СтудентаLabel";
            фИО_СтудентаLabel.Size = new System.Drawing.Size(86, 13);
            фИО_СтудентаLabel.TabIndex = 7;
            фИО_СтудентаLabel.Text = "ФИО Студента:";
            // 
            // адрес_проживанияLabel
            // 
            адрес_проживанияLabel.AutoSize = true;
            адрес_проживанияLabel.Location = new System.Drawing.Point(65, 130);
            адрес_проживанияLabel.Name = "адрес_проживанияLabel";
            адрес_проживанияLabel.Size = new System.Drawing.Size(106, 13);
            адрес_проживанияLabel.TabIndex = 8;
            адрес_проживанияLabel.Text = "Адрес проживания:";
            // 
            // контактный_номер_телефонаLabel
            // 
            контактный_номер_телефонаLabel.AutoSize = true;
            контактный_номер_телефонаLabel.Location = new System.Drawing.Point(13, 157);
            контактный_номер_телефонаLabel.Name = "контактный_номер_телефонаLabel";
            контактный_номер_телефонаLabel.Size = new System.Drawing.Size(158, 13);
            контактный_номер_телефонаLabel.TabIndex = 10;
            контактный_номер_телефонаLabel.Text = "Контактный номер телефона:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(82, 183);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 12;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // пол_студентаLabel
            // 
            пол_студентаLabel.AutoSize = true;
            пол_студентаLabel.Location = new System.Drawing.Point(93, 209);
            пол_студентаLabel.Name = "пол_студентаLabel";
            пол_студентаLabel.Size = new System.Drawing.Size(78, 13);
            пол_студентаLabel.TabIndex = 14;
            пол_студентаLabel.Text = "Пол студента:";
            // 
            // серия_и_номер_паспортаLabel
            // 
            серия_и_номер_паспортаLabel.AutoSize = true;
            серия_и_номер_паспортаLabel.Location = new System.Drawing.Point(36, 236);
            серия_и_номер_паспортаLabel.Name = "серия_и_номер_паспортаLabel";
            серия_и_номер_паспортаLabel.Size = new System.Drawing.Size(135, 13);
            серия_и_номер_паспортаLabel.TabIndex = 16;
            серия_и_номер_паспортаLabel.Text = "Серия и номер паспорта:";
            // 
            // сНИЛСLabel
            // 
            сНИЛСLabel.AutoSize = true;
            сНИЛСLabel.Location = new System.Drawing.Point(123, 262);
            сНИЛСLabel.Name = "сНИЛСLabel";
            сНИЛСLabel.Size = new System.Drawing.Size(48, 13);
            сНИЛСLabel.TabIndex = 18;
            сНИЛСLabel.Text = "СНИЛС:";
            // 
            // номер_ИННLabel
            // 
            номер_ИННLabel.AutoSize = true;
            номер_ИННLabel.Location = new System.Drawing.Point(100, 288);
            номер_ИННLabel.Name = "номер_ИННLabel";
            номер_ИННLabel.Size = new System.Drawing.Size(71, 13);
            номер_ИННLabel.TabIndex = 20;
            номер_ИННLabel.Text = "Номер ИНН:";
            // 
            // год_окончания_школыLabel
            // 
            год_окончания_школыLabel.AutoSize = true;
            год_окончания_школыLabel.Location = new System.Drawing.Point(50, 314);
            год_окончания_школыLabel.Name = "год_окончания_школыLabel";
            год_окончания_школыLabel.Size = new System.Drawing.Size(121, 13);
            год_окончания_школыLabel.TabIndex = 22;
            год_окончания_школыLabel.Text = "Год окончания школы:";
            // 
            // номер_аттестатаLabel
            // 
            номер_аттестатаLabel.AutoSize = true;
            номер_аттестатаLabel.Location = new System.Drawing.Point(74, 340);
            номер_аттестатаLabel.Name = "номер_аттестатаLabel";
            номер_аттестатаLabel.Size = new System.Drawing.Size(97, 13);
            номер_аттестатаLabel.TabIndex = 24;
            номер_аттестатаLabel.Text = "Номер аттестата:";
            // 
            // воинское_удостоверениеLabel
            // 
            воинское_удостоверениеLabel.AutoSize = true;
            воинское_удостоверениеLabel.Location = new System.Drawing.Point(33, 366);
            воинское_удостоверениеLabel.Name = "воинское_удостоверениеLabel";
            воинское_удостоверениеLabel.Size = new System.Drawing.Size(138, 13);
            воинское_удостоверениеLabel.TabIndex = 26;
            воинское_удостоверениеLabel.Text = "Воинское удостоверение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Студенты";
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентBindingSource
            // 
            this.студентBindingSource.DataMember = "Студент";
            this.студентBindingSource.DataSource = this.studentsDataSet;
            // 
            // студентTableAdapter
            // 
            this.студентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Students.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Ведомость_сдачи_сессииTableAdapter = null;
            this.tableAdapterManager.ГруппаTableAdapter = this.группаTableAdapter;
            this.tableAdapterManager.Перечень_дисциплинTableAdapter = null;
            this.tableAdapterManager.СпециальностьTableAdapter = null;
            this.tableAdapterManager.СтудентTableAdapter = this.студентTableAdapter;
            this.tableAdapterManager.Учебный_планTableAdapter = null;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // студентBindingNavigator
            // 
            this.студентBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентBindingNavigator.BindingSource = this.студентBindingSource;
            this.студентBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.студентBindingNavigatorSaveItem});
            this.студентBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентBindingNavigator.Name = "студентBindingNavigator";
            this.студентBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.студентBindingNavigator.TabIndex = 5;
            this.студентBindingNavigator.Text = "bindingNavigator1";
            this.студентBindingNavigator.Visible = false;
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
            // студентBindingNavigatorSaveItem
            // 
            this.студентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.студентBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("студентBindingNavigatorSaveItem.Image")));
            this.студентBindingNavigatorSaveItem.Name = "студентBindingNavigatorSaveItem";
            this.студентBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.студентBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.студентBindingNavigatorSaveItem.Click += new System.EventHandler(this.студентBindingNavigatorSaveItem_Click);
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.studentsDataSet;
            // 
            // фИО_СтудентаTextBox
            // 
            this.фИО_СтудентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "ФИО_Студента", true));
            this.фИО_СтудентаTextBox.Location = new System.Drawing.Point(177, 101);
            this.фИО_СтудентаTextBox.Name = "фИО_СтудентаTextBox";
            this.фИО_СтудентаTextBox.Size = new System.Drawing.Size(199, 20);
            this.фИО_СтудентаTextBox.TabIndex = 8;
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Адрес_проживания", true));
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(177, 127);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(199, 20);
            this.адрес_проживанияTextBox.TabIndex = 9;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентBindingSource, "Дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(177, 180);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 13;
            // 
            // пол_студентаComboBox
            // 
            this.пол_студентаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Пол_студента", true));
            this.пол_студентаComboBox.FormattingEnabled = true;
            this.пол_студентаComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.пол_студентаComboBox.Location = new System.Drawing.Point(177, 206);
            this.пол_студентаComboBox.Name = "пол_студентаComboBox";
            this.пол_студентаComboBox.Size = new System.Drawing.Size(199, 21);
            this.пол_студентаComboBox.TabIndex = 15;
            // 
            // год_окончания_школыTextBox
            // 
            this.год_окончания_школыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Год_окончания_школы", true));
            this.год_окончания_школыTextBox.Location = new System.Drawing.Point(177, 311);
            this.год_окончания_школыTextBox.Name = "год_окончания_школыTextBox";
            this.год_окончания_школыTextBox.Size = new System.Drawing.Size(199, 20);
            this.год_окончания_школыTextBox.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Контактный_номер_телефона", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(177, 154);
            this.maskedTextBox1.Mask = "+9 (999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox1.TabIndex = 27;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Номер_аттестата", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(177, 337);
            this.maskedTextBox2.Mask = "99999999999999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox2.TabIndex = 28;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Номер_ИНН", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(177, 285);
            this.maskedTextBox3.Mask = "99-9999999999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox3.TabIndex = 29;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Воинское_удостоверение", true));
            this.maskedTextBox4.Location = new System.Drawing.Point(177, 363);
            this.maskedTextBox4.Mask = "9999-999999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox4.TabIndex = 30;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "Серия_и_номер_паспорта", true));
            this.maskedTextBox5.Location = new System.Drawing.Point(177, 233);
            this.maskedTextBox5.Mask = "9999-999999";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox5.TabIndex = 31;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентBindingSource, "СНИЛС", true));
            this.maskedTextBox6.Location = new System.Drawing.Point(177, 259);
            this.maskedTextBox6.Mask = "999-999-999 99";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox6.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Предыдущая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Первая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(586, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(401, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 23);
            this.button5.TabIndex = 37;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(586, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 23);
            this.button6.TabIndex = 38;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(401, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(364, 23);
            this.button7.TabIndex = 39;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(401, 361);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(364, 23);
            this.button8.TabIndex = 40;
            this.button8.Text = "Табличный вид";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.студентBindingSource, "Номер_группы", true));
            this.comboBox1.DataSource = this.группаBindingSource;
            this.comboBox1.DisplayMember = "Название_группы";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.ValueMember = "Номер_группы";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(воинское_удостоверениеLabel);
            this.Controls.Add(номер_аттестатаLabel);
            this.Controls.Add(год_окончания_школыLabel);
            this.Controls.Add(this.год_окончания_школыTextBox);
            this.Controls.Add(номер_ИННLabel);
            this.Controls.Add(сНИЛСLabel);
            this.Controls.Add(серия_и_номер_паспортаLabel);
            this.Controls.Add(пол_студентаLabel);
            this.Controls.Add(this.пол_студентаComboBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(контактный_номер_телефонаLabel);
            this.Controls.Add(адрес_проживанияLabel);
            this.Controls.Add(this.адрес_проживанияTextBox);
            this.Controls.Add(фИО_СтудентаLabel);
            this.Controls.Add(this.фИО_СтудентаTextBox);
            this.Controls.Add(номер_группыLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.студентBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Таблица \"Студенты\"";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентBindingNavigator)).EndInit();
            this.студентBindingNavigator.ResumeLayout(false);
            this.студентBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource студентBindingSource;
        private StudentsDataSetTableAdapters.СтудентTableAdapter студентTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator студентBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton студентBindingNavigatorSaveItem;
        private StudentsDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.TextBox фИО_СтудентаTextBox;
        private System.Windows.Forms.TextBox адрес_проживанияTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.ComboBox пол_студентаComboBox;
        private System.Windows.Forms.TextBox год_окончания_школыTextBox;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}