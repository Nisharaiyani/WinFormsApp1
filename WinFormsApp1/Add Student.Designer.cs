namespace Sample
{
    partial class Add_Student
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
            L_FN = new Label();
            L_LN = new Label();
            L_Gender = new Label();
            L_DOP = new Label();
            L_Class = new Label();
            L_Address = new Label();
            L_Age = new Label();
            L_Years = new Label();
            TB_FN = new TextBox();
            TB_LN = new TextBox();
            TB_Class = new TextBox();
            CB_Gender = new ComboBox();
            DP_DOB = new DateTimePicker();
            TB_Age = new TextBox();
            RTB_Address = new RichTextBox();
            BSave = new Button();
            B_Cancel = new Button();
            L_T_AddStudent = new Label();
            SuspendLayout();
            // 
            // L_FN
            // 
            L_FN.AutoSize = true;
            L_FN.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_FN.Location = new Point(60, 100);
            L_FN.Name = "L_FN";
            L_FN.Size = new Size(117, 30);
            L_FN.TabIndex = 0;
            L_FN.Text = "First Name";
            // 
            // L_LN
            // 
            L_LN.AutoSize = true;
            L_LN.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_LN.Location = new Point(60, 201);
            L_LN.Name = "L_LN";
            L_LN.Size = new Size(114, 30);
            L_LN.TabIndex = 1;
            L_LN.Text = "Last Name";
            // 
            // L_Gender
            // 
            L_Gender.AutoSize = true;
            L_Gender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Gender.Location = new Point(60, 300);
            L_Gender.Name = "L_Gender";
            L_Gender.Size = new Size(85, 30);
            L_Gender.TabIndex = 2;
            L_Gender.Text = "Gender";
            // 
            // L_DOP
            // 
            L_DOP.AutoSize = true;
            L_DOP.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_DOP.Location = new Point(60, 393);
            L_DOP.Name = "L_DOP";
            L_DOP.Size = new Size(135, 30);
            L_DOP.TabIndex = 3;
            L_DOP.Text = "Date of Birth";
            // 
            // L_Class
            // 
            L_Class.AutoSize = true;
            L_Class.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Class.Location = new Point(60, 487);
            L_Class.Name = "L_Class";
            L_Class.Size = new Size(61, 30);
            L_Class.TabIndex = 4;
            L_Class.Text = "Class";
            // 
            // L_Address
            // 
            L_Address.AutoSize = true;
            L_Address.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Address.Location = new Point(60, 574);
            L_Address.Name = "L_Address";
            L_Address.Size = new Size(91, 30);
            L_Address.TabIndex = 5;
            L_Address.Text = "Address";
            // 
            // L_Age
            // 
            L_Age.AutoSize = true;
            L_Age.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Age.Location = new Point(443, 393);
            L_Age.Name = "L_Age";
            L_Age.Size = new Size(52, 30);
            L_Age.TabIndex = 6;
            L_Age.Text = "Age";
            // 
            // L_Years
            // 
            L_Years.AutoSize = true;
            L_Years.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Years.Location = new Point(612, 393);
            L_Years.Name = "L_Years";
            L_Years.Size = new Size(63, 30);
            L_Years.TabIndex = 7;
            L_Years.Text = "Years";
            // 
            // TB_FN
            // 
            TB_FN.Location = new Point(213, 100);
            TB_FN.Name = "TB_FN";
            TB_FN.PlaceholderText = "Enter First Name";
            TB_FN.Size = new Size(311, 31);
            TB_FN.TabIndex = 8;
            // 
            // TB_LN
            // 
            TB_LN.Location = new Point(213, 202);
            TB_LN.Name = "TB_LN";
            TB_LN.PlaceholderText = "Please enter Last Name";
            TB_LN.Size = new Size(311, 31);
            TB_LN.TabIndex = 9;
            // 
            // TB_Class
            // 
            TB_Class.Location = new Point(213, 488);
            TB_Class.Name = "TB_Class";
            TB_Class.PlaceholderText = "Please enter class";
            TB_Class.Size = new Size(311, 31);
            TB_Class.TabIndex = 10;
            // 
            // CB_Gender
            // 
            CB_Gender.FormattingEnabled = true;
            CB_Gender.Items.AddRange(new object[] { "Male", "Female" });
            CB_Gender.Location = new Point(213, 297);
            CB_Gender.Name = "CB_Gender";
            CB_Gender.Size = new Size(311, 33);
            CB_Gender.TabIndex = 11;
            // 
            // DP_DOB
            // 
            DP_DOB.Location = new Point(213, 392);
            DP_DOB.Name = "DP_DOB";
            DP_DOB.Size = new Size(204, 31);
            DP_DOB.TabIndex = 12;
            // 
            // TB_Age
            // 
            TB_Age.Location = new Point(501, 392);
            TB_Age.Name = "TB_Age";
            TB_Age.Size = new Size(106, 31);
            TB_Age.TabIndex = 13;
            // 
            // RTB_Address
            // 
            RTB_Address.Location = new Point(197, 553);
            RTB_Address.Name = "RTB_Address";
            RTB_Address.Size = new Size(394, 91);
            RTB_Address.TabIndex = 14;
            RTB_Address.Text = "";
            // 
            // BSave
            // 
            BSave.Location = new Point(490, 693);
            BSave.Name = "BSave";
            BSave.Size = new Size(112, 34);
            BSave.TabIndex = 15;
            BSave.Text = "Save";
            BSave.UseVisualStyleBackColor = true;
            BSave.Click += BSave_Click;
            // 
            // B_Cancel
            // 
            B_Cancel.Location = new Point(612, 693);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new Size(112, 34);
            B_Cancel.TabIndex = 16;
            B_Cancel.Text = "Cancel";
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // L_T_AddStudent
            // 
            L_T_AddStudent.AutoSize = true;
            L_T_AddStudent.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            L_T_AddStudent.Location = new Point(306, 25);
            L_T_AddStudent.Name = "L_T_AddStudent";
            L_T_AddStudent.Size = new Size(198, 45);
            L_T_AddStudent.TabIndex = 17;
            L_T_AddStudent.Text = "Add Student";
            // 
            // Add_Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 754);
            Controls.Add(L_T_AddStudent);
            Controls.Add(B_Cancel);
            Controls.Add(BSave);
            Controls.Add(RTB_Address);
            Controls.Add(TB_Age);
            Controls.Add(DP_DOB);
            Controls.Add(CB_Gender);
            Controls.Add(TB_Class);
            Controls.Add(TB_LN);
            Controls.Add(TB_FN);
            Controls.Add(L_Years);
            Controls.Add(L_Age);
            Controls.Add(L_Address);
            Controls.Add(L_Class);
            Controls.Add(L_DOP);
            Controls.Add(L_Gender);
            Controls.Add(L_LN);
            Controls.Add(L_FN);
            Name = "Add_Student";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_FN;
        private Label L_LN;
        private Label L_Gender;
        private Label L_DOP;
        private Label L_Class;
        private Label L_Address;
        private Label L_Age;
        private Label L_Years;
        private TextBox TB_FN;
        private TextBox TB_LN;
        private TextBox TB_Class;
        private ComboBox CB_Gender;
        private DateTimePicker DP_DOB;
        private TextBox TB_Age;
        private RichTextBox RTB_Address;
        private Button BSave;
        private Button B_Cancel;
        private Label L_T_AddStudent;
    }
}