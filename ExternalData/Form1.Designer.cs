namespace ExternalData
{
    partial class Form1
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnViewStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(32, 21);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(658, 275);
            this.dgvStudents.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(164, 324);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(126, 63);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(441, 324);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(126, 63);
            this.btnViewStudent.TabIndex = 2;
            this.btnViewStudent.Text = "View Student";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.btnViewStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnViewStudent;
    }
}

