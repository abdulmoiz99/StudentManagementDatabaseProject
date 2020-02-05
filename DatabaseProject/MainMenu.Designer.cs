namespace DatabaseProject
{
    partial class MainMenu
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
            this.btn_ShowMarksOfAllStudent = new System.Windows.Forms.Button();
            this.btn_GradeAStudent = new System.Windows.Forms.Button();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ShowMarksOfAllStudent
            // 
            this.btn_ShowMarksOfAllStudent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowMarksOfAllStudent.Location = new System.Drawing.Point(21, 74);
            this.btn_ShowMarksOfAllStudent.Name = "btn_ShowMarksOfAllStudent";
            this.btn_ShowMarksOfAllStudent.Size = new System.Drawing.Size(698, 64);
            this.btn_ShowMarksOfAllStudent.TabIndex = 0;
            this.btn_ShowMarksOfAllStudent.Text = "Show Marks Of All Students";
            this.btn_ShowMarksOfAllStudent.UseVisualStyleBackColor = true;
            // 
            // btn_GradeAStudent
            // 
            this.btn_GradeAStudent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GradeAStudent.Location = new System.Drawing.Point(21, 144);
            this.btn_GradeAStudent.Name = "btn_GradeAStudent";
            this.btn_GradeAStudent.Size = new System.Drawing.Size(698, 64);
            this.btn_GradeAStudent.TabIndex = 0;
            this.btn_GradeAStudent.Text = "Grade A Student";
            this.btn_GradeAStudent.UseVisualStyleBackColor = true;
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudent.Location = new System.Drawing.Point(21, 214);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(698, 64);
            this.btn_AddStudent.TabIndex = 0;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(21, 284);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(698, 64);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 369);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AddStudent);
            this.Controls.Add(this.btn_GradeAStudent);
            this.Controls.Add(this.btn_ShowMarksOfAllStudent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowMarksOfAllStudent;
        private System.Windows.Forms.Button btn_GradeAStudent;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_Exit;
    }
}

