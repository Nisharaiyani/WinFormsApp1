namespace Sample
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
            L_T_OurStudents = new Label();
            StudentList = new DataGridView();
            TB_Search = new TextBox();
            B_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentList).BeginInit();
            SuspendLayout();
            // 
            // L_T_OurStudents
            // 
            L_T_OurStudents.AutoSize = true;
            L_T_OurStudents.Location = new Point(383, 39);
            L_T_OurStudents.Name = "L_T_OurStudents";
            L_T_OurStudents.Size = new Size(116, 25);
            L_T_OurStudents.TabIndex = 0;
            L_T_OurStudents.Text = "Our Students";
            // 
            // StudentList
            // 
            StudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentList.Location = new Point(136, 223);
            StudentList.Name = "StudentList";
            StudentList.RowHeadersWidth = 62;
            StudentList.Size = new Size(637, 225);
            StudentList.TabIndex = 1;
            // 
            // TB_Search
            // 
            TB_Search.Location = new Point(438, 165);
            TB_Search.Name = "TB_Search";
            TB_Search.Size = new Size(150, 31);
            TB_Search.TabIndex = 2;
            // 
            // B_Add
            // 
            B_Add.Location = new Point(617, 147);
            B_Add.Name = "B_Add";
            B_Add.Size = new Size(133, 49);
            B_Add.TabIndex = 3;
            B_Add.Text = "+Add";
            B_Add.UseVisualStyleBackColor = true;
            B_Add.Click += B_Add_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 576);
            Controls.Add(B_Add);
            Controls.Add(TB_Search);
            Controls.Add(StudentList);
            Controls.Add(L_T_OurStudents);
            Name = "Form1";
            Text = "Our Students";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_T_OurStudents;
        private DataGridView StudentList;
        private TextBox TB_Search;
        private Button B_Add;
    }
}
