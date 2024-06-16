using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RotaGenius
{
    public partial class ManagerProfile : Form
    {
        private Button button1;
        private Button button2;
        private ListBox ProfileDetails;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button3;
        private PictureBox pictureBox1;

        public ManagerProfile()
        {

            InitializeComponent();
        }





        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ProfileDetails = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RotaGenius.Properties.Resources.Profile1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "ASSIGN STAFFS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "VIEW STAFFS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProfileDetails
            // 
            this.ProfileDetails.FormattingEnabled = true;
            this.ProfileDetails.Location = new System.Drawing.Point(177, 75);
            this.ProfileDetails.Name = "ProfileDetails";
            this.ProfileDetails.Size = new System.Drawing.Size(237, 121);
            this.ProfileDetails.TabIndex = 3;
            this.ProfileDetails.SelectedIndexChanged += new System.EventHandler(this.ProfileDetails_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RotaGenius.Properties.Resources.Departments1;
            this.pictureBox2.Location = new System.Drawing.Point(209, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RotaGenius.Properties.Resources.Departments1;
            this.pictureBox3.Location = new System.Drawing.Point(209, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "ViewProfile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManagerProfile
            // 
            this.ClientSize = new System.Drawing.Size(542, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ProfileDetails);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagerProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        private void ProfileDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private bool CheckCredentials(string Email, string Password)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\akume\\source\\repos\\RotaGenius\\Database51.accdb";
            string dbcommand = "SELECT COUNT(*) FROM [Manager Details] WHERE Email = ? AND Password = ?";

            using (OleDbConnection conn = new OleDbConnection(dbconnection))
            {
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);

                // Add parameters with their values
                comm.Parameters.AddWithValue("@Email", Email);
                comm.Parameters.AddWithValue("@Password", Password);

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


    }
}