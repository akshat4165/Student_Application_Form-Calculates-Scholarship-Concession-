using System;
using System.Windows.Forms;

namespace StudentApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCourses();
            this.btnCheck.Click += new System.EventHandler(btnCheck_Click);
            this.ClientSize = new System.Drawing.Size(578, 530);  // Set a custom size
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadCourses()
        {
            cmbCourse.Items.Add("Computer Science - ₹50000");
            cmbCourse.Items.Add("Commerce - ₹60000");
            cmbCourse.Items.Add("Media Studies - ₹55000");
            cmbCourse.Items.Add("Psychology - ₹45000");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Validate fields for checking fees
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtMarks.Text) ||
                cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtMarks.Text, out int marks) || marks < 0 || marks > 100)
            {
                MessageBox.Show("Please enter valid marks between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine base fee
            int baseFee = 0;
            switch (cmbCourse.SelectedIndex)
            {
                case 0:
                    baseFee = 50000;
                    break;
                case 1:
                    baseFee = 60000;
                    break;
                case 2:
                    baseFee = 55000;
                    break;
                case 3:
                    baseFee = 45000;
                    break;
            }

            // Calculate concession
            double concessionPercentage = 0;
            if (marks >= 90)
            {
                concessionPercentage = 0.30;
            }
            else if (marks >= 75)
            {
                concessionPercentage = 0.20;
            }
            else if (marks >= 50)
            {
                concessionPercentage = 0.10;
            }

            double concessionAmount = baseFee * concessionPercentage;
            double finalFee = baseFee - concessionAmount;

            // Display results for fee calculation
            lblBaseFee.Text = $"Base Fee: ₹{baseFee}";
            lblConcession.Text = $"Concession: ₹{concessionAmount}";
            lblFinalFee.Text = $"Final Fee: ₹{finalFee}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate fields for submission
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtMarks.Text) ||
                cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
