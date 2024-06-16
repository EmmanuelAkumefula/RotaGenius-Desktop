using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RotaGenius
{
    public partial class StaffDashboard : Form
    {
        public TextBox textBoxs;
        private Label label2;
        public TextBox textBoxss;
        private Button button1;
        private PictureBox pictureBox1;
        private ListBox EmployeeProfile;
        private Button button2;
        private MonthCalendar monthCalendar1;
        private Button button3;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button4;
        private Database51DataSet1 database51DataSet1;
        private BindingSource staffsAvailabilityBindingSource;
        private System.ComponentModel.IContainer components;
        private Database51DataSet1TableAdapters.StaffsAvailabilityTableAdapter staffsAvailabilityTableAdapter;
        private BindingSource staffsAvailabilityBindingSource1;
        private BindingSource staffsAvailabilityBindingSource2;
        private Database51DataSet2 database51DataSet2;
        private BindingSource shiftsAssignedBindingSource;
        private Database51DataSet2TableAdapters.ShiftsAssignedTableAdapter shiftsAssignedTableAdapter;
        private ListBox ShiftsASsigned;
        private Button button5;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label1;

        public StaffDashboard()
        {
            InitializeComponent();
            EmployeeProfile.Hide();
            ShiftsASsigned.Hide();
            label5.Hide();
            textBox2.Hide();
            label6.Hide();
            button2.Hide();
            button5.Hide();
            label3.Hide();
            button3.Hide();
            textBox1.Hide();
            monthCalendar1.Hide();
            //dataGridView1.Hide();
            label4.Hide();
        }
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxss = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeProfile = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffsAvailabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet1 = new RotaGenius.Database51DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.staffsAvailabilityTableAdapter = new RotaGenius.Database51DataSet1TableAdapters.StaffsAvailabilityTableAdapter();
            this.staffsAvailabilityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffsAvailabilityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet2 = new RotaGenius.Database51DataSet2();
            this.shiftsAssignedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftsAssignedTableAdapter = new RotaGenius.Database51DataSet2TableAdapters.ShiftsAssignedTableAdapter();
            this.ShiftsASsigned = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Email";
            // 
            // textBoxs
            // 
            this.textBoxs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxs.Location = new System.Drawing.Point(745, 410);
            this.textBoxs.Name = "textBoxs";
            this.textBoxs.Size = new System.Drawing.Size(492, 49);
            this.textBoxs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Password";
            // 
            // textBoxss
            // 
            this.textBoxss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxss.Location = new System.Drawing.Point(745, 504);
            this.textBoxss.Name = "textBoxss";
            this.textBoxss.Size = new System.Drawing.Size(492, 49);
            this.textBoxss.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(651, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 85);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RotaGenius.Properties.Resources.Departments;
            this.pictureBox1.Location = new System.Drawing.Point(172, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeProfile
            // 
            this.EmployeeProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeProfile.FormattingEnabled = true;
            this.EmployeeProfile.ItemHeight = 37;
            this.EmployeeProfile.Location = new System.Drawing.Point(597, 21);
            this.EmployeeProfile.Name = "EmployeeProfile";
            this.EmployeeProfile.Size = new System.Drawing.Size(464, 189);
            this.EmployeeProfile.TabIndex = 6;
            this.EmployeeProfile.SelectedIndexChanged += new System.EventHandler(this.EmployeeProfile_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(800, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1073, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(544, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 59);
            this.button3.TabIndex = 12;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(544, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 44);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Set Availability";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Assigned Shifts";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackgroundImage = global::RotaGenius.Properties.Resources.OIP__2_;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(1323, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 120);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // staffsAvailabilityTableAdapter
            // 
            this.staffsAvailabilityTableAdapter.ClearBeforeFill = true;
            // 
            // staffsAvailabilityBindingSource1
            // 
            this.staffsAvailabilityBindingSource1.DataMember = "StaffsAvailability";
            this.staffsAvailabilityBindingSource1.DataSource = this.database51DataSet1;
            // 
            // staffsAvailabilityBindingSource2
            // 
            this.staffsAvailabilityBindingSource2.DataMember = "StaffsAvailability";
            this.staffsAvailabilityBindingSource2.DataSource = this.database51DataSet1;
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
            // ShiftsASsigned
            // 
            this.ShiftsASsigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftsASsigned.FormattingEnabled = true;
            this.ShiftsASsigned.ItemHeight = 37;
            this.ShiftsASsigned.Location = new System.Drawing.Point(10, 26);
            this.ShiftsASsigned.Name = "ShiftsASsigned";
            this.ShiftsASsigned.Size = new System.Drawing.Size(553, 152);
            this.ShiftsASsigned.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(153, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 59);
            this.button5.TabIndex = 18;
            this.button5.Text = "Show Shifts";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "ShiftDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirmation ( YES / NO )";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(544, 378);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 44);
            this.textBox2.TabIndex = 21;
            // 
            // StaffDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1531, 1061);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ShiftsASsigned);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EmployeeProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxs);
            this.Controls.Add(this.label1);
            this.Name = "StaffDashboard";
            this.Load += new System.EventHandler(this.StaffDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsAvailabilityBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsAssignedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        public static class Globals
        {
            // Example: Unmodifiable constant
            public const int BUFFER_SIZE = 512;

            // Example: Modifiable variable
            public static string FILE_NAME = "Output.txt";

            // Example: Unmodifiable readonly variable
            public static readonly string CODE_PREFIX = "US-";

            // Static method to extract email and password

        }






        public void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxs.Text; // Extract text value from email textbox

            string password = textBoxss.Text; // Extract text value from password textbox

            // Query the database to check if the email and password exist
            if (CheckCredentials(email, password))
            {
                label1.Hide();
                label2.Hide();
                textBoxs.Hide();
                textBoxss.Hide();
                pictureBox1.Hide();
                button1.Hide();

                //employer profile show
                EmployeeProfile.Show();
                ShiftsASsigned.Show();
                button5.Show();
                button2.Show();
                label3.Show();
                button3.Show();
                textBox1.Show();
                monthCalendar1.Show();
                //dataGridView1.Show();
                label4.Show();
                label5.Show();
                textBox2.Show();
                label6.Show();
                //EmployeeProfile.Show();
                //button2.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private bool CheckCredentials(string Email, string Password)
        {

            bool isValid = false;
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + @" Data Source = C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            // SQL query to check if the email and password exist in the database
            string query = "SELECT COUNT(*) FROM [Manager Details] WHERE Email = @Email AND Password = @Password";

            OleDbConnection connection = new OleDbConnection(connectionString);

            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    isValid = true;
                }
            }
            catch (OleDbException ex)
            {
                // Handle OleDbException separately
                MessageBox.Show("OLEDB Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error: " + ex.Message);
            }



            return isValid;
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database51DataSet2.ShiftsAssigned' table. You can move, or remove it, as needed.
            //this.shiftsAssignedTableAdapter.Fill(this.database51DataSet2.ShiftsAssigned);
            // TODO: This line of code loads data into the 'database51DataSet1.StaffsAvailability' table. You can move, or remove it, as needed.
            //this.staffsAvailabilityTableAdapter.Fill(this.database51DataSet1.StaffsAvailability);

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //StaffDashboard staffDashboard_var = new StaffDashboard();

            //

            string email = textBoxs.Text; // Extract text value from email textbox
            string password = textBoxss.Text; // Extract text value from password textbox

            // Query the database to check if the email and password exist
            if (CheckCredentials1(email, password))
            {

                // Call a method to fetch and display data on the ListBox
                DisplayDataFromDatabase(email, password);

            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }

        }

        private void DisplayDataFromDatabase(string email, string password)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string query = "SELECT FirstName, LastName,PhoneNumber,HomeAddresss,email FROM [Manager Details] WHERE Email = ? AND Password = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("Email", email); // Remove @ symbol
                command.Parameters.AddWithValue("Password", password); // Remove @ symbol

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    // Clear existing items in the ListBox
                    EmployeeProfile.Items.Clear();

                    // Read data from the database and add it to the ListBox
                    while (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string PhoneNumber = reader["PhoneNumber"].ToString();
                        string HomeAddresss = reader["HomeAddresss"].ToString();
                        string email1 = reader["email"].ToString();


                        string itemText = $" FIRSTNAME :   {firstName}";
                        string itemText2 = $" LASTNAME :  {lastName}";
                        string itemText3 = $" PHONE NUMBER :  {PhoneNumber}";
                        string itemText4 = $" HOME ADDRESS  :  {HomeAddresss}";
                        string itemText5 = $"email  :  {email}";
                        EmployeeProfile.Items.Add(itemText);
                        EmployeeProfile.Items.Add(itemText2);
                        EmployeeProfile.Items.Add(itemText3); EmployeeProfile.Items.Add(itemText4); EmployeeProfile.Items.Add(itemText5);
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }
        // staff 2
        private void DisplayDataFromDatabasestaff(string email)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string query = "SELECT ShiftDate, ShiftTime,ShiftType,ShiftEndTime,Department, Confirmation FROM [Shifts Assigned] WHERE Email = ? ";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("Email", email); // Remove @ symbol
                

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    // Clear existing items in the ListBox
                    EmployeeProfile.Items.Clear();

                    // Read data from the database and add it to the ListBox
                    while (reader.Read())
                    {
                        string ShiftDate = reader["ShiftDate"].ToString();
                        string ShiftTime = reader["ShiftTime"].ToString();
                        string ShiftType = reader["ShiftType"].ToString();
                        string ShiftEndTime = reader["ShiftEndTime"].ToString();
                        string Department = reader["Department"].ToString();
                        string Confirmation = reader["Confirmation"].ToString();

                        string itemText = $"ShiftDate  :    {ShiftDate}";
                        string itemText2 = $"ShiftTime  :   {ShiftTime}";
                        string itemText3 = $"ShiftType  :   {ShiftType}";
                        string itemText4 = $" ShiftEndTime  :{ShiftEndTime}";
                        string itemText5 = $"Department  :  {Department}";
                        string itemText6 = $"Confirmation  :  {Confirmation}";
                        EmployeeProfile.Items.Add(itemText);
                        EmployeeProfile.Items.Add(itemText2);
                        EmployeeProfile.Items.Add(itemText3); EmployeeProfile.Items.Add(itemText4); EmployeeProfile.Items.Add(itemText5); EmployeeProfile.Items.Add(itemText6);
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private bool CheckCredentials1(string email, string password)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string dbcommand = "SELECT COUNT(*) FROM [Manager Details] WHERE Email = ? AND Password = ?";

            using (OleDbConnection conn = new OleDbConnection(dbconnection))
            {
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);

                // Add parameters with their values
                comm.Parameters.AddWithValue("@Email", email);
                comm.Parameters.AddWithValue("@Password", password);

                try
                {
                    conn.Open();
                    int count = (int)comm.ExecuteScalar();
                    return count > 0;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return false; // Return false in case of exception
                }
            }

        }
        //for shifts assigned
        private bool CheckCredentials12(string email)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string dbcommand = "SELECT COUNT(*) FROM [Manager Details] WHERE Email = ? ";

            using (OleDbConnection conn = new OleDbConnection(dbconnection))
            {
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);

                // Add parameters with their values
                comm.Parameters.AddWithValue("@Email", email);
                

                try
                {
                    conn.Open();
                    int count = (int)comm.ExecuteScalar();
                    return count > 0;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return false; // Return false in case of exception
                }
            }

        }
        // to confirm shifts
        private bool CheckCredentialsupdate(string Date,string confirmation)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\Desktop\\RotaGenius\\Database51.accdb";
            string dbcommand = "UPDATE ShiftsAssigned SET confirmation =? WHERE Date = ?;";




            using (OleDbConnection conn = new OleDbConnection(dbconnection))
            {
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);

                // Add parameters with their values
                comm.Parameters.AddWithValue("@Date", Date);
                comm.Parameters.AddWithValue("@confirmation", confirmation);

                try
                {
                    conn.Open();
                    int count = (int)comm.ExecuteScalar();
                    return count > 0;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return false; // Return false in case of exception
                }
            }

        }

        private void EmployeeProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string email = textBoxs.Text; // Extract text value from email textbox
            string password = textBoxss.Text; // Extract text value from password textbox

            // Query the database to check if the email and password exist
            if (CheckCredentials1(email, password))
            {

                // Call a method to fetch and display data on the ListBox
                DisplayDataFromDatabase(email, password);

            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string email = textBoxs.Text; // Extract text value from email textbox
            

            // Query the database to check if the email and password exist
            if (CheckCredentials12(email))
            {

                // Call a method to fetch and display data on the ListBox
                DisplayDataFromDatabasestaff(email);

            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // to update the database for confirmation
            string Date = textBox1.Text; // Extract text value from email textbox
            string confirmation = textBox2.Text; // Extract text value from password textbox

            // Query the database to check if the email and password exist
            if (CheckCredentialsupdate(Date, confirmation))
            {

                MessageBox.Show("Shift Confirmation Successfully Updated!");

            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }
    }
}