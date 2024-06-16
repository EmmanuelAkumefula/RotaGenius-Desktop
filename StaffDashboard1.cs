using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace RotaGenius
{
    public partial class StaffDashboard1 : Form
    {
        private ListBox EmployeeProfile;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;

        public StaffDashboard1()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            this.EmployeeProfile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeProfile
            // 
            this.EmployeeProfile.FormattingEnabled = true;
            this.EmployeeProfile.ItemHeight = 25;
            this.EmployeeProfile.Location = new System.Drawing.Point(1151, 6);
            this.EmployeeProfile.Name = "EmployeeProfile";
            this.EmployeeProfile.Size = new System.Drawing.Size(354, 304);
            this.EmployeeProfile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assigned Shifts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set Availability";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 44);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1238, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 59);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show Profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(694, 35);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // StaffDashboard1
            // 
            this.ClientSize = new System.Drawing.Size(1679, 913);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeProfile);
            this.Name = "StaffDashboard1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private string email;
        private string password;
        public StaffDashboard1(string email, string password)
        {
            InitializeComponent();

            // Initialize email and password fields
            this.email = email;
            this.password = password;
        }

        // Your existing code...




        private void button2_Click(object sender, System.EventArgs e)
        {
            StaffDashboard staffDashboard_var = new StaffDashboard();

            //

            string email = staffDashboard_var.textBoxs.Text; // Extract text value from email textbox
            string password = staffDashboard_var.textBoxss.Text; // Extract text value from password textbox

            // Query the database to check if the email and password exist
            if (CheckCredentials(email, password))
            {

                // Call a method to fetch and display data on the ListBox
                DisplayDataFromDatabase(email, password);

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


    }
}