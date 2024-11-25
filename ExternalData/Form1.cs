using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalData
{
    public partial class Form1 : Form
    {
        string connectionString = @"server=(localdb)\MSSQLLocalDB;database=Dominican;Trusted_connection=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            //This opens the sql connection using our 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Student", conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dgvStudents.DataSource = dt;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                Student student = new Student(addStudentForm.ID, addStudentForm.FirstName,
                    addStudentForm.LastName, addStudentForm.Major);
                AddStudentToDb(student);
            }
        }

        public void AddStudentToDb(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO dbo.Student(Id, FirstName, LastName, Major) " +
                    "VALUES (@Id, @FirstName, @LastName, @Major)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", student.Id);
                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@Major", student.Major);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Added new student successfully!");
        }
    }
}
