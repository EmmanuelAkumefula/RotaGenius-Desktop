using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RotaGenius
{
    public partial class AssignStaffs : Form
    {
        //database connection
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";


        private BindingSource database51DataSetBindingSource;
        private System.ComponentModel.IContainer components;
        private BindingSource managerDetailsBindingSource;
        private Database51DataSetTableAdapters.Manager_DetailsTableAdapter manager_DetailsTableAdapter;
        private Label label1;
        private BindingSource staffsAvailabilityBindingSource;
        private Database51DataSet1 database51DataSet1;
        private Database51DataSet1TableAdapters.StaffsAvailabilityTableAdapter staffsAvailabilityTableAdapter;
        private Database51DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employmentTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private ToolStripButton fillByToolStripButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label8;
        private Database51DataSet2 database51DataSet2;
        private BindingSource shiftsAssignedBindingSource;
        private Database51DataSet2TableAdapters.ShiftsAssignedTableAdapter shiftsAssignedTableAdapter;
        private Database51DataSet3 database51DataSet3;
        private BindingSource shiftsAssignedBindingSource1;
        private Database51DataSet3TableAdapters.ShiftsAssignedTableAdapter shiftsAssignedTableAdapter1;
        private Database51DataSet4 database51DataSet4;
        private BindingSource shiftsAssignedBindingSource2;
        private Database51DataSet4TableAdapters.ShiftsAssignedTableAdapter shiftsAssignedTableAdapter2;
        private Database51DataSet5 database51DataSet5;
        private BindingSource shiftsAssignedBindingSource3;
        private Database51DataSet5TableAdapters.ShiftsAssignedTableAdapter shiftsAssignedTableAdapter3;
        private DataGridView dataGridView2;
        private Database51DataSet6 database51DataSet6;
        private BindingSource shiftsAssignedBindingSource4;
        private Database51DataSet6TableAdapters.ShiftsAssignedTableAdapter shiftsAssignedTableAdapter4;
        private Label label9;
        private TextBox textBox6;
        private Button button2;
        private Database51DataSet7 database51DataSet7;
        private BindingSource shiftsAssignedBindingSource5;
        private Database51DataSet7TableAdapters.ShiftsAssignedTableAdapter shiftsAssignedTableAdapter5;
        private DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shiftTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn shiftEndTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Confirmation;
        private Label label10;
        private DataGridView dataGridView3;
        private Button button3;
        private Database51DataSet database51DataSet;

        public AssignStaffs()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeDatabase2();
            RefreshDataGridView();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.managerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet = new RotaGenius.Database51DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new RotaGenius.Database51DataSet1TableAdapters.TableAdapterManager();
            this.staffsAvailabilityTableAdapter = new RotaGenius.Database51DataSet1TableAdapters.StaffsAvailabilityTableAdapter();
            this.staffsAvailabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet1 = new RotaGenius.Database51DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.database51DataSet2 = new RotaGenius.Database51DataSet2();
            this.shiftsAssignedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftsAssignedTableAdapter = new RotaGenius.Database51DataSet2TableAdapters.ShiftsAssignedTableAdapter();
            this.shiftsAssignedBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet4 = new RotaGenius.Database51DataSet4();
            this.shiftsAssignedTableAdapter2 = new RotaGenius.Database51DataSet4TableAdapters.ShiftsAssignedTableAdapter();
            this.shiftsAssignedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet3 = new RotaGenius.Database51DataSet3();
            this.shiftsAssignedTableAdapter1 = new RotaGenius.Database51DataSet3TableAdapters.ShiftsAssignedTableAdapter();
            this.shiftsAssignedBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet5 = new RotaGenius.Database51DataSet5();
            this.shiftsAssignedTableAdapter3 = new RotaGenius.Database51DataSet5TableAdapters.ShiftsAssignedTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftsAssignedBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet7 = new RotaGenius.Database51DataSet7();
            this.shiftsAssignedBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet6 = new RotaGenius.Database51DataSet6();
            this.shiftsAssignedTableAdapter4 = new RotaGenius.Database51DataSet6TableAdapters.ShiftsAssignedTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.shiftsAssignedTableAdapter5 = new RotaGenius.Database51DataSet7TableAdapters.ShiftsAssignedTableAdapter();
            this.manager_DetailsTableAdapter = new RotaGenius.Database51DataSetTableAdapters.Manager_DetailsTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.managerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // managerDetailsBindingSource
            // 
            this.managerDetailsBindingSource.DataMember = "Manager Details";
            this.managerDetailsBindingSource.DataSource = this.database51DataSetBindingSource;
            // 
            // database51DataSetBindingSource
            // 
            this.database51DataSetBindingSource.DataSource = this.database51DataSet;
            this.database51DataSetBindingSource.Position = 0;
            // 
            // database51DataSet
            // 
            this.database51DataSet.DataSetName = "Database51DataSet";
            this.database51DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "STAFFS AVAILABILITY";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StaffsAvailabilityTableAdapter = this.staffsAvailabilityTableAdapter;
            this.tableAdapterManager.UpdateOrder = RotaGenius.Database51DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffsAvailabilityTableAdapter
            // 
            this.staffsAvailabilityTableAdapter.ClearBeforeFill = true;
            // 
            // staffsAvailabilityBindingSource
            // 
            this.staffsAvailabilityBindingSource.DataMember = "StaffsAvailability";
            this.staffsAvailabilityBindingSource.DataSource = this.database51DataSet1;
            // 
            // database51DataSet1
            // 
            this.database51DataSet1.DataSetName = "Database51DataSet1";
            this.database51DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.shiftTypeDataGridViewTextBoxColumn,
            this.employmentTypeDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffsAvailabilityBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.ForestGreen;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 176);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftTypeDataGridViewTextBoxColumn
            // 
            this.shiftTypeDataGridViewTextBoxColumn.DataPropertyName = "ShiftType";
            this.shiftTypeDataGridViewTextBoxColumn.HeaderText = "ShiftType";
            this.shiftTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftTypeDataGridViewTextBoxColumn.Name = "shiftTypeDataGridViewTextBoxColumn";
            this.shiftTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // employmentTypeDataGridViewTextBoxColumn
            // 
            this.employmentTypeDataGridViewTextBoxColumn.DataPropertyName = "EmploymentType";
            this.employmentTypeDataGridViewTextBoxColumn.HeaderText = "EmploymentType";
            this.employmentTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employmentTypeDataGridViewTextBoxColumn.Name = "employmentTypeDataGridViewTextBoxColumn";
            this.employmentTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            this.availabilityDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(985, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assigning Staffs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(982, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Staff Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(986, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shift Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(986, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Shift Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(986, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Shift Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(986, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Shift End Time";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1175, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1175, 417);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1175, 454);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1175, 495);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 22);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1175, 533);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 22);
            this.textBox5.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(987, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "STAFFS  ASSIGNED";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // database51DataSet2
            // 
            this.database51DataSet2.DataSetName = "Database51DataSet2";
            this.database51DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsAssignedBindingSource
            // 
            this.shiftsAssignedBindingSource.DataMember = "ShiftsAssigned";
            this.shiftsAssignedBindingSource.DataSource = this.database51DataSet2;
            // 
            // shiftsAssignedTableAdapter
            // 
            this.shiftsAssignedTableAdapter.ClearBeforeFill = true;
            // 
            // shiftsAssignedBindingSource2
            // 
            this.shiftsAssignedBindingSource2.DataMember = "ShiftsAssigned";
            this.shiftsAssignedBindingSource2.DataSource = this.database51DataSet4;
            // 
            // database51DataSet4
            // 
            this.database51DataSet4.DataSetName = "Database51DataSet4";
            this.database51DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsAssignedTableAdapter2
            // 
            this.shiftsAssignedTableAdapter2.ClearBeforeFill = true;
            // 
            // shiftsAssignedBindingSource1
            // 
            this.shiftsAssignedBindingSource1.DataMember = "ShiftsAssigned";
            this.shiftsAssignedBindingSource1.DataSource = this.database51DataSet3;
            // 
            // database51DataSet3
            // 
            this.database51DataSet3.DataSetName = "Database51DataSet3";
            this.database51DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsAssignedTableAdapter1
            // 
            this.shiftsAssignedTableAdapter1.ClearBeforeFill = true;
            // 
            // shiftsAssignedBindingSource3
            // 
            this.shiftsAssignedBindingSource3.DataMember = "ShiftsAssigned";
            this.shiftsAssignedBindingSource3.DataSource = this.database51DataSet5;
            // 
            // database51DataSet5
            // 
            this.database51DataSet5.DataSetName = "Database51DataSet5";
            this.database51DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsAssignedTableAdapter3
            // 
            this.shiftsAssignedTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.shiftDateDataGridViewTextBoxColumn,
            this.shiftTimeDataGridViewTextBoxColumn,
            this.shiftTypeDataGridViewTextBoxColumn1,
            this.shiftEndTimeDataGridViewTextBoxColumn,
            this.staffEmailDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn1,
            this.Confirmation});
            this.dataGridView2.DataSource = this.shiftsAssignedBindingSource5;
            this.dataGridView2.GridColor = System.Drawing.Color.ForestGreen;
            this.dataGridView2.Location = new System.Drawing.Point(12, 333);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(924, 184);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftDateDataGridViewTextBoxColumn
            // 
            this.shiftDateDataGridViewTextBoxColumn.DataPropertyName = "ShiftDate";
            this.shiftDateDataGridViewTextBoxColumn.HeaderText = "ShiftDate";
            this.shiftDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDateDataGridViewTextBoxColumn.Name = "shiftDateDataGridViewTextBoxColumn";
            this.shiftDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftTimeDataGridViewTextBoxColumn
            // 
            this.shiftTimeDataGridViewTextBoxColumn.DataPropertyName = "ShiftTime";
            this.shiftTimeDataGridViewTextBoxColumn.HeaderText = "ShiftTime";
            this.shiftTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftTimeDataGridViewTextBoxColumn.Name = "shiftTimeDataGridViewTextBoxColumn";
            this.shiftTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftTypeDataGridViewTextBoxColumn1
            // 
            this.shiftTypeDataGridViewTextBoxColumn1.DataPropertyName = "ShiftType";
            this.shiftTypeDataGridViewTextBoxColumn1.HeaderText = "ShiftType";
            this.shiftTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.shiftTypeDataGridViewTextBoxColumn1.Name = "shiftTypeDataGridViewTextBoxColumn1";
            this.shiftTypeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // shiftEndTimeDataGridViewTextBoxColumn
            // 
            this.shiftEndTimeDataGridViewTextBoxColumn.DataPropertyName = "ShiftEndTime";
            this.shiftEndTimeDataGridViewTextBoxColumn.HeaderText = "ShiftEndTime";
            this.shiftEndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftEndTimeDataGridViewTextBoxColumn.Name = "shiftEndTimeDataGridViewTextBoxColumn";
            this.shiftEndTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffEmailDataGridViewTextBoxColumn
            // 
            this.staffEmailDataGridViewTextBoxColumn.DataPropertyName = "StaffEmail";
            this.staffEmailDataGridViewTextBoxColumn.HeaderText = "StaffEmail";
            this.staffEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffEmailDataGridViewTextBoxColumn.Name = "staffEmailDataGridViewTextBoxColumn";
            this.staffEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            this.departmentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Confirmation
            // 
            this.Confirmation.DataPropertyName = "Confirmation";
            this.Confirmation.HeaderText = "Confirmation";
            this.Confirmation.MinimumWidth = 6;
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Width = 125;
            // 
            // shiftsAssignedBindingSource5
            // 
            this.shiftsAssignedBindingSource5.DataMember = "ShiftsAssigned";
            this.shiftsAssignedBindingSource5.DataSource = this.database51DataSet7;
            // 
            // database51DataSet7
            // 
            this.database51DataSet7.DataSetName = "Database51DataSet7";
            this.database51DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsAssignedBindingSource4
            // 
            this.shiftsAssignedBindingSource4.DataMember = "ShiftsAssigned";
            this.shiftsAssignedBindingSource4.DataSource = this.database51DataSet6;
            // 
            // database51DataSet6
            // 
            this.database51DataSet6.DataSetName = "Database51DataSet6";
            this.database51DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsAssignedTableAdapter4
            // 
            this.shiftsAssignedTableAdapter4.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(986, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Department";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1175, 568);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 22);
            this.textBox6.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 752);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shiftsAssignedTableAdapter5
            // 
            this.shiftsAssignedTableAdapter5.ClearBeforeFill = true;
            // 
            // manager_DetailsTableAdapter
            // 
            this.manager_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(644, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(773, 48);
            this.label10.TabIndex = 20;
            this.label10.Text = "STAFF MANAGEMENT DASHBOARD";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 536);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(518, 210);
            this.dataGridView3.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::RotaGenius.Properties.Resources.OIP__3_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(565, -7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 76);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AssignStaffs
            // 
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1837, 889);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "AssignStaffs";
            this.Load += new System.EventHandler(this.AssignStaffs_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.managerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void AssignStaffs_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDatabase()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string query = "SELECT ID, email, FirstName, LastName, PhoneNumber, Department,ShiftType,EmploymentType,Availability FROM [StaffsAvailability]";

            connection = new OleDbConnection(connectionString);
            dataAdapter = new OleDbDataAdapter(query, connection);
            dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }


        private void InitializeDatabase2()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string query = "SELECT Index, StaffEmail, ShiftDate, ShiftTime, ShiftType, ShiftEndTime FROM [ShiftsAssigned]";

            connection = new OleDbConnection(connectionString);
            dataAdapter = new OleDbDataAdapter(query, connection);
            dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            //dataGridView3.DataSource = dataTable;
        }

        private void InitializeDatabase3()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string query = "SELECT Index, StaffEmail, ShiftDate, ShiftTime, ShiftType, ShiftEndTime FROM [ShiftsAssigned]";

            connection = new OleDbConnection(connectionString);
            dataAdapter = new OleDbDataAdapter(query, connection);
            dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            //dataGridView2.DataSource = dataTable;
            dataGridView3.DataSource = dataTable;
        }


        private void AssignStaffs_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database51DataSet7.ShiftsAssigned' table. You can move, or remove it, as needed.
            this.shiftsAssignedTableAdapter5.Fill(this.database51DataSet7.ShiftsAssigned);
            // TODO: This line of code loads data into the 'database51DataSet6.ShiftsAssigned' table. You can move, or remove it, as needed.
            this.shiftsAssignedTableAdapter4.Fill(this.database51DataSet6.ShiftsAssigned);
            // TODO: This line of code loads data into the 'database51DataSet5.ShiftsAssigned' table. You can move, or remove it, as needed.
            this.shiftsAssignedTableAdapter3.Fill(this.database51DataSet5.ShiftsAssigned);
            // TODO: This line of code loads data into the 'database51DataSet4.ShiftsAssigned' table. You can move, or remove it, as needed.
            this.shiftsAssignedTableAdapter2.Fill(this.database51DataSet4.ShiftsAssigned);
            // TODO: This line of code loads data into the 'database51DataSet3.ShiftsAssigned' table. You can move, or remove it, as needed.
            this.shiftsAssignedTableAdapter1.Fill(this.database51DataSet3.ShiftsAssigned);
            // TODO: This line of code loads data into the 'database51DataSet2.ShiftsAssigned' table. You can move, or remove it, as needed.
            this.shiftsAssignedTableAdapter.Fill(this.database51DataSet2.ShiftsAssigned);


        }



        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.staffsAvailabilityTableAdapter.FillBy(this.database51DataSet1.StaffsAvailability);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.shiftsAssignedTableAdapter1.FillBy(this.database51DataSet3.ShiftsAssigned);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.shiftsAssignedTableAdapter2.FillBy(this.database51DataSet4.ShiftsAssigned);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve data from text boxes
            string email = textBox1.Text;
            string date = textBox2.Text;
            string time = textBox3.Text;
            string type = textBox4.Text;
            string end = textBox5.Text;
            string department = textBox6.Text;

            // Connection string to your MS Access database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";

            // SQL statement to insert data into the database
            string sqlInsert = "INSERT INTO ShiftsAssigned (StaffEmail, ShiftDate, ShiftTime, ShiftType, ShiftEndTime, Department) VALUES (?, ?, ?, ?, ?,?)";

            // Create connection and command objects
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(sqlInsert, connection))
                {
                    try
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@p1", email);
                        command.Parameters.AddWithValue("@p2", date);
                        command.Parameters.AddWithValue("@p3", time);
                        command.Parameters.AddWithValue("@p4", type);
                        command.Parameters.AddWithValue("@p5", end);
                        command.Parameters.AddWithValue("@p5", department);
                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Insert successful
                            MessageBox.Show("Data inserted successfully!");

                        }
                        else
                        {
                            // Insert failed
                            MessageBox.Show("Failed to insert data!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Method to refresh DataGridView with updated data
        private void RefreshDataGridView()
        {
            // SQL statement to select all data from the database table
            string sqlSelect = "SELECT * FROM ShiftsAssigned";

            // Create a DataTable to hold the data
            var dataTable = new System.Data.DataTable();

            // Create connection and command objects
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlSelect, connection))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView2.DataSource = dataTable;
                        dataGridView3.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void fillByToolStripButton1_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.shiftsAssignedTableAdapter3.FillBy(this.database51DataSet5.ShiftsAssigned);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.shiftsAssignedTableAdapter3.FillBy1(this.database51DataSet5.ShiftsAssigned);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.shiftsAssignedTableAdapter3.FillBy1(this.database51DataSet5.ShiftsAssigned);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerAuthentication managerAuthentication = new ManagerAuthentication();
            managerAuthentication.Show();

            managerAuthentication.pictureBox1.Hide();
            managerAuthentication.label1.Hide();
            managerAuthentication.label2.Hide();
            managerAuthentication.Email.Hide();
            managerAuthentication.Password.Hide();
            managerAuthentication.button1.Hide();
            managerAuthentication.button5.Hide();
            managerAuthentication.label3.Hide();


            managerAuthentication.pictureBox4.Show();
            managerAuthentication.button2.Show();
            managerAuthentication.button3.Show();
            managerAuthentication.button4.Show();
            managerAuthentication.ProfileDetails.Show();
            managerAuthentication.monthCalendar1.Show();
            managerAuthentication.label4.Show();
            this.Hide();












        }

    }


}