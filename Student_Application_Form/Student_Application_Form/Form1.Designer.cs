namespace StudentApplicationForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            label1 = new Label();
            grpPersonalDetails = new GroupBox();
            txtPhoneNumber = new TextBox();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            lblPhoneNumber = new Label();
            lblStudentID = new Label();
            lblStudentName = new Label();
            grpCourseDetails = new GroupBox();
            btnCheck = new Button();
            txtMarks = new TextBox();
            cmbCourse = new ComboBox();
            lblMarksObtained = new Label();
            lblCourse = new Label();
            grpFeeCalculation = new GroupBox();
            lblFinalFee = new Label();
            lblConcession = new Label();
            lblBaseFee = new Label();
            btnSubmit = new Button();
            pnlHeader.SuspendLayout();
            grpPersonalDetails.SuspendLayout();
            grpCourseDetails.SuspendLayout();
            grpFeeCalculation.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightGray;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(16, 15);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1040, 64);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(234, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(617, 59);
            label1.TabIndex = 0;
            label1.Text = "Student Application Form 🎓";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpPersonalDetails
            // 
            grpPersonalDetails.Controls.Add(txtPhoneNumber);
            grpPersonalDetails.Controls.Add(txtStudentID);
            grpPersonalDetails.Controls.Add(txtStudentName);
            grpPersonalDetails.Controls.Add(lblPhoneNumber);
            grpPersonalDetails.Controls.Add(lblStudentID);
            grpPersonalDetails.Controls.Add(lblStudentName);
            grpPersonalDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpPersonalDetails.Location = new Point(16, 102);
            grpPersonalDetails.Margin = new Padding(4);
            grpPersonalDetails.Name = "grpPersonalDetails";
            grpPersonalDetails.Padding = new Padding(4);
            grpPersonalDetails.Size = new Size(1040, 320);
            grpPersonalDetails.TabIndex = 1;
            grpPersonalDetails.TabStop = false;
            grpPersonalDetails.Text = "Personal Details";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(286, 224);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(714, 50);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(286, 147);
            txtStudentID.Margin = new Padding(4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(714, 50);
            txtStudentID.TabIndex = 4;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(286, 70);
            txtStudentName.Margin = new Padding(4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(714, 50);
            txtStudentName.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(26, 224);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(257, 45);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(26, 147);
            lblStudentID.Margin = new Padding(4, 0, 4, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(188, 45);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(26, 70);
            lblStudentName.Margin = new Padding(4, 0, 4, 0);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(242, 45);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name:";
            // 
            // grpCourseDetails
            // 
            grpCourseDetails.Controls.Add(btnCheck);
            grpCourseDetails.Controls.Add(txtMarks);
            grpCourseDetails.Controls.Add(cmbCourse);
            grpCourseDetails.Controls.Add(lblMarksObtained);
            grpCourseDetails.Controls.Add(lblCourse);
            grpCourseDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpCourseDetails.Location = new Point(16, 448);
            grpCourseDetails.Margin = new Padding(4);
            grpCourseDetails.Name = "grpCourseDetails";
            grpCourseDetails.Padding = new Padding(4);
            grpCourseDetails.Size = new Size(1040, 256);
            grpCourseDetails.TabIndex = 2;
            grpCourseDetails.TabStop = false;
            grpCourseDetails.Text = "Course Details";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(672, 156);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(69, 59);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "✅        ";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(286, 160);
            txtMarks.Margin = new Padding(4);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(259, 50);
            txtMarks.TabIndex = 7;
            // 
            // cmbCourse
            // 
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(286, 70);
            cmbCourse.Margin = new Padding(4);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(714, 53);
            cmbCourse.TabIndex = 6;
            // 
            // lblMarksObtained
            // 
            lblMarksObtained.AutoSize = true;
            lblMarksObtained.Location = new Point(26, 160);
            lblMarksObtained.Margin = new Padding(4, 0, 4, 0);
            lblMarksObtained.Name = "lblMarksObtained";
            lblMarksObtained.Size = new Size(269, 45);
            lblMarksObtained.TabIndex = 5;
            lblMarksObtained.Text = "Marks Obtained:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(26, 70);
            lblCourse.Margin = new Padding(4, 0, 4, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(255, 45);
            lblCourse.TabIndex = 4;
            lblCourse.Text = "Select a Course:";
            // 
            // grpFeeCalculation
            // 
            grpFeeCalculation.Controls.Add(lblFinalFee);
            grpFeeCalculation.Controls.Add(lblConcession);
            grpFeeCalculation.Controls.Add(lblBaseFee);
            grpFeeCalculation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpFeeCalculation.Location = new Point(16, 730);
            grpFeeCalculation.Margin = new Padding(4);
            grpFeeCalculation.Name = "grpFeeCalculation";
            grpFeeCalculation.Padding = new Padding(4);
            grpFeeCalculation.Size = new Size(1040, 256);
            grpFeeCalculation.TabIndex = 3;
            grpFeeCalculation.TabStop = false;
            grpFeeCalculation.Text = "Fee Calculation";
            // 
            // lblFinalFee
            // 
            lblFinalFee.AutoSize = true;
            lblFinalFee.Location = new Point(26, 192);
            lblFinalFee.Margin = new Padding(4, 0, 4, 0);
            lblFinalFee.Name = "lblFinalFee";
            lblFinalFee.Size = new Size(160, 45);
            lblFinalFee.TabIndex = 8;
            lblFinalFee.Text = "Final Fee:";
            // 
            // lblConcession
            // 
            lblConcession.AutoSize = true;
            lblConcession.Location = new Point(26, 128);
            lblConcession.Margin = new Padding(4, 0, 4, 0);
            lblConcession.Name = "lblConcession";
            lblConcession.Size = new Size(196, 45);
            lblConcession.TabIndex = 7;
            lblConcession.Text = "Concession:";
            // 
            // lblBaseFee
            // 
            lblBaseFee.AutoSize = true;
            lblBaseFee.Location = new Point(26, 64);
            lblBaseFee.Margin = new Padding(4, 0, 4, 0);
            lblBaseFee.Name = "lblBaseFee";
            lblBaseFee.Size = new Size(158, 45);
            lblBaseFee.TabIndex = 6;
            lblBaseFee.Text = "Base Fee:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSubmit.Location = new Point(390, 1024);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(325, 77);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1071, 1149);
            Controls.Add(btnSubmit);
            Controls.Add(grpFeeCalculation);
            Controls.Add(grpCourseDetails);
            Controls.Add(grpPersonalDetails);
            Controls.Add(pnlHeader);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Application Form";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpPersonalDetails.ResumeLayout(false);
            grpPersonalDetails.PerformLayout();
            grpCourseDetails.ResumeLayout(false);
            grpCourseDetails.PerformLayout();
            grpFeeCalculation.ResumeLayout(false);
            grpFeeCalculation.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.GroupBox grpCourseDetails;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblMarksObtained;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.GroupBox grpFeeCalculation;
        private System.Windows.Forms.Label lblFinalFee;
        private System.Windows.Forms.Label lblConcession;
        private System.Windows.Forms.Label lblBaseFee;
        private System.Windows.Forms.Button btnSubmit;
        private Button btnCheck;
        
    }
}
