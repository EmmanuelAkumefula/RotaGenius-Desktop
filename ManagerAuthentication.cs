using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RotaGenius
{
    public partial class ManagerAuthentication : Form
    {

        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;



        public Label label1;
        public TextBox Email;
        public Label label2;
        public TextBox Password;
        public Button button1;
        public Button button3;
        public ListBox ProfileDetails;
        public Button button2;
        public Button button4;
        public PictureBox pictureBox4;
        private Database51DataSet database51DataSet;
        private BindingSource managerDetailsBindingSource;
        private System.ComponentModel.IContainer components;
        private Database51DataSetTableAdapters.Manager_DetailsTableAdapter manager_DetailsTableAdapter;
        public MonthCalendar monthCalendar1;
        private Database51DataSet1TableAdapters.StaffsAvailabilityTableAdapter staffsAvailabilityTableAdapter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private BindingSource managerDetailsBindingSource1;
        public Button button5;
        public Label label3;
        public Label label4;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Button button6;
        public PictureBox pictureBox1;

        public ManagerAuthentication()
        {
            InitializeComponent();

            // Other initialization or code here

            pictureBox4.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ProfileDetails.Hide();
            monthCalendar1.Hide();
            label4.Hide();

        }
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProfileDetails = new System.Windows.Forms.ListBox();
            this.managerDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database51DataSet = new RotaGenius.Database51DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.managerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_DetailsTableAdapter = new RotaGenius.Database51DataSetTableAdapters.Manager_DetailsTableAdapter();
            this.staffsAvailabilityTableAdapter = new RotaGenius.Database51DataSet1TableAdapters.StaffsAvailabilityTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.managerDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDetailsBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Email.Location = new System.Drawing.Point(697, 341);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(266, 41);
            this.Email.TabIndex = 2;
            this.Email.Text = "Enter Work Email";
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(696, 406);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(227, 44);
            this.Password.TabIndex = 4;
            this.Password.Text = "Enter Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(617, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 73);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(743, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 56);
            this.button3.TabIndex = 13;
            this.button3.Text = "View Profile";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProfileDetails
            // 
            this.ProfileDetails.BackColor = System.Drawing.SystemColors.Window;
            this.ProfileDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileDetails.ForeColor = System.Drawing.Color.ForestGreen;
            this.ProfileDetails.FormattingEnabled = true;
            this.ProfileDetails.ItemHeight = 30;
            this.ProfileDetails.Items.AddRange(new object[] {
            "\t\tPROFILE DETAILS"});
            this.ProfileDetails.Location = new System.Drawing.Point(489, 101);
            this.ProfileDetails.Name = "ProfileDetails";
            this.ProfileDetails.Size = new System.Drawing.Size(349, 150);
            this.ProfileDetails.TabIndex = 10;
            this.ProfileDetails.SelectedIndexChanged += new System.EventHandler(this.ProfileDetails_SelectedIndexChanged);
            // 
            // managerDetailsBindingSource1
            // 
            this.managerDetailsBindingSource1.DataMember = "Manager Details";
            this.managerDetailsBindingSource1.DataSource = this.database51DataSet;
            // 
            // database51DataSet
            // 
            this.database51DataSet.DataSetName = "Database51DataSet";
            this.database51DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(489, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 227);
            this.button2.TabIndex = 9;
            this.button2.Text = "VIEW STAFFS";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.ForestGreen;
            this.button4.Location = new System.Drawing.Point(888, 556);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 227);
            this.button4.TabIndex = 8;
            this.button4.Text = "ASSIGN STAFFS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(697, 379);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // managerDetailsBindingSource
            // 
            this.managerDetailsBindingSource.DataMember = "Manager Details";
            this.managerDetailsBindingSource.DataSource = this.database51DataSet;
            // 
            // manager_DetailsTableAdapter
            // 
            this.manager_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // staffsAvailabilityTableAdapter
            // 
            this.staffsAvailabilityTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 42);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.profileToolStripMenuItem.Text = "profile";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(361, 44);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.ForestGreen;
            this.button5.Location = new System.Drawing.Point(826, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 73);
            this.button5.TabIndex = 17;
            this.button5.Text = "Forgot Password";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1009, 73);
            this.label3.TabIndex = 18;
            this.label3.Text = "Welcome Back PLease Login......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(689, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 73);
            this.label4.TabIndex = 19;
            this.label4.Text = "Your Dashboard";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::RotaGenius.Properties.Resources.OIP__2_;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(1192, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 73);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::RotaGenius.Properties.Resources.Snapchat_5340560281;
            this.pictureBox4.Location = new System.Drawing.Point(844, 101);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(192, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RotaGenius.Properties.Resources.Profile;
            this.pictureBox1.Location = new System.Drawing.Point(704, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerAuthentication
            // 
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(2884, 1640);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProfileDetails);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagerAuthentication";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.ManagerAuthentication_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.managerDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database51DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerDetailsBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        private void ManagerAuthentication_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = Email.Text; // Extract text value from email textbox
            string password = Password.Text; // Extract text value from password textbox

            // Query the database to check if the email and password exist
            if (CheckCredentials(email, password))
            {
                // Open the next form
                //ManagerProfile Managerlogin = new ManagerProfile();
                //Managerlogin.Show();
                //this.Hide();
                pictureBox1.Hide();
                label1.Hide();
                label2.Hide();
                Email.Hide();
                Password.Hide();
                button1.Hide();
                button5.Hide();
                label3.Hide();

                //show next page

                pictureBox4.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                ProfileDetails.Show();
                monthCalendar1.Show();
                label4.Show();

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

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = Email.Text; // Assuming "Email" is the name of your TextBox control
            string password = Password.Text; // Assuming "Password" is the name of your TextBox control

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
                    ProfileDetails.Items.Clear();

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
                        ProfileDetails.Items.Add(itemText);
                        ProfileDetails.Items.Add(itemText2);
                        ProfileDetails.Items.Add(itemText3); ProfileDetails.Items.Add(itemText4); ProfileDetails.Items.Add(itemText5);
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

        private void ManagerAuthentication_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database51DataSet1.StaffsAvailability' table. You can move, or remove it, as needed.



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.manager_DetailsTableAdapter.FillBy(this.database51DataSet.Manager_Details);
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
                this.manager_DetailsTableAdapter.FillBy1(this.database51DataSet.Manager_Details);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignStaffs AssignStaffs1 = new AssignStaffs();
            AssignStaffs1.Show();
            this.Hide();
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.manager_DetailsTableAdapter.FillBy2(this.database51DataSet.Manager_Details);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void ProfileDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



