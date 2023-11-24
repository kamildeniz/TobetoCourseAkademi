namespace FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnCategory = new Button();
            btnInstructor = new Button();
            btnCourse = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(413, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.Layout += dataGridView1_Layout;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(11, 172);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(75, 23);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Kategori";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnInstructor
            // 
            btnInstructor.FlatStyle = FlatStyle.System;
            btnInstructor.Location = new Point(109, 172);
            btnInstructor.Name = "btnInstructor";
            btnInstructor.Size = new Size(75, 23);
            btnInstructor.TabIndex = 2;
            btnInstructor.Text = "Eğitmen";
            btnInstructor.UseVisualStyleBackColor = true;
            btnInstructor.Click += btnInstructor_Click;
            // 
            // btnCourse
            // 
            btnCourse.Location = new Point(207, 172);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(75, 23);
            btnCourse.TabIndex = 3;
            btnCourse.Text = "Kurs";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCourse);
            Controls.Add(btnInstructor);
            Controls.Add(btnCategory);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCategory;
        private Button btnInstructor;
        private Button btnCourse;
    }
}