namespace Sample
{
    partial class Edit_Student
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
            L_T_AddStudent = new Label();
            B_Cancel = new Button();
            BSave = new Button();
            RTB_Address = new RichTextBox();
            TB_Age = new TextBox();
            DP_DOB = new DateTimePicker();
            CB_Gender = new ComboBox();
            TB_Class = new TextBox();
            TB_LN = new TextBox();
            TB_FN = new TextBox();
            L_Years = new Label();
            L_Age = new Label();
            L_Address = new Label();
            L_Class = new Label();
            L_DOP = new Label();
            L_Gender = new Label();
            L_LN = new Label();
            L_FN = new Label();
            B_Delete = new Button();
            SuspendLayout();
            // 
            // L_T_AddStudent
            // 
            L_T_AddStudent.AutoSize = true;
            L_T_AddStudent.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            L_T_AddStudent.Location = new Point(314, 5);
            L_T_AddStudent.Name = "L_T_AddStudent";
            L_T_AddStudent.Size = new Size(193, 45);
            L_T_AddStudent.TabIndex = 35;
            L_T_AddStudent.Text = "Edit Student";
            // 
            // B_Cancel
            // 
            B_Cancel.Location = new Point(636, 657);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new Size(112, 34);
            B_Cancel.TabIndex = 34;
            B_Cancel.Text = "Cancel";
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // BSave
            // 
            BSave.Location = new Point(502, 666);
            BSave.Name = "BSave";
            BSave.Size = new Size(112, 34);
            BSave.TabIndex = 33;
            BSave.Text = "Save";
            BSave.UseVisualStyleBackColor = true;
            BSave.Click += BSave_Click;
            // 
            // RTB_Address
            // 
            RTB_Address.Location = new Point(205, 533);
            RTB_Address.Name = "RTB_Address";
            RTB_Address.Size = new Size(394, 91);
            RTB_Address.TabIndex = 32;
            RTB_Address.Text = "";
            // 
            // TB_Age
            // 
            TB_Age.Location = new Point(509, 372);
            TB_Age.Name = "TB_Age";
            TB_Age.Size = new Size(106, 31);
            TB_Age.TabIndex = 31;
            // 
            // DP_DOB
            // 
            DP_DOB.Location = new Point(221, 372);
            DP_DOB.Name = "DP_DOB";
            DP_DOB.Size = new Size(204, 31);
            DP_DOB.TabIndex = 30;
            // 
            // CB_Gender
            // 
            CB_Gender.FormattingEnabled = true;
            CB_Gender.Items.AddRange(new object[] { "Male", "Female" });
            CB_Gender.Location = new Point(221, 277);
            CB_Gender.Name = "CB_Gender";
            CB_Gender.Size = new Size(311, 33);
            CB_Gender.TabIndex = 29;
            // 
            // TB_Class
            // 
            TB_Class.Location = new Point(221, 468);
            TB_Class.Name = "TB_Class";
            TB_Class.Size = new Size(311, 31);
            TB_Class.TabIndex = 28;
            // 
            // TB_LN
            // 
            TB_LN.Location = new Point(221, 182);
            TB_LN.Name = "TB_LN";
            TB_LN.Size = new Size(311, 31);
            TB_LN.TabIndex = 27;
            // 
            // TB_FN
            // 
            TB_FN.Location = new Point(221, 80);
            TB_FN.Name = "TB_FN";
            TB_FN.Size = new Size(311, 31);
            TB_FN.TabIndex = 26;
            // 
            // L_Years
            // 
            L_Years.AutoSize = true;
            L_Years.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Years.Location = new Point(620, 373);
            L_Years.Name = "L_Years";
            L_Years.Size = new Size(63, 30);
            L_Years.TabIndex = 25;
            L_Years.Text = "Years";
            // 
            // L_Age
            // 
            L_Age.AutoSize = true;
            L_Age.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Age.Location = new Point(451, 373);
            L_Age.Name = "L_Age";
            L_Age.Size = new Size(52, 30);
            L_Age.TabIndex = 24;
            L_Age.Text = "Age";
            // 
            // L_Address
            // 
            L_Address.AutoSize = true;
            L_Address.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Address.Location = new Point(68, 554);
            L_Address.Name = "L_Address";
            L_Address.Size = new Size(91, 30);
            L_Address.TabIndex = 23;
            L_Address.Text = "Address";
            // 
            // L_Class
            // 
            L_Class.AutoSize = true;
            L_Class.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Class.Location = new Point(68, 467);
            L_Class.Name = "L_Class";
            L_Class.Size = new Size(61, 30);
            L_Class.TabIndex = 22;
            L_Class.Text = "Class";
            // 
            // L_DOP
            // 
            L_DOP.AutoSize = true;
            L_DOP.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_DOP.Location = new Point(68, 373);
            L_DOP.Name = "L_DOP";
            L_DOP.Size = new Size(135, 30);
            L_DOP.TabIndex = 21;
            L_DOP.Text = "Date of Birth";
            // 
            // L_Gender
            // 
            L_Gender.AutoSize = true;
            L_Gender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_Gender.Location = new Point(68, 280);
            L_Gender.Name = "L_Gender";
            L_Gender.Size = new Size(85, 30);
            L_Gender.TabIndex = 20;
            L_Gender.Text = "Gender";
            // 
            // L_LN
            // 
            L_LN.AutoSize = true;
            L_LN.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_LN.Location = new Point(68, 181);
            L_LN.Name = "L_LN";
            L_LN.Size = new Size(114, 30);
            L_LN.TabIndex = 19;
            L_LN.Text = "Last Name";
            // 
            // L_FN
            // 
            L_FN.AutoSize = true;
            L_FN.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            L_FN.Location = new Point(68, 80);
            L_FN.Name = "L_FN";
            L_FN.Size = new Size(117, 30);
            L_FN.TabIndex = 18;
            L_FN.Text = "First Name";
            // 
            // B_Delete
            // 
            B_Delete.Location = new Point(68, 657);
            B_Delete.Name = "B_Delete";
            B_Delete.Size = new Size(112, 34);
            B_Delete.TabIndex = 36;
            B_Delete.Text = "Delete";
            B_Delete.UseVisualStyleBackColor = true;
            B_Delete.Click += B_Delete_Click_1;
            // 
            // Edit_Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 712);
            Controls.Add(B_Delete);
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
            Name = "Edit_Student";
            Text = "Edit_Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_T_AddStudent;
        private Button B_Cancel;
        private Button BSave;
        private RichTextBox RTB_Address;
        private TextBox TB_Age;
        private DateTimePicker DP_DOB;
        private ComboBox CB_Gender;
        private TextBox TB_Class;
        private TextBox TB_LN;
        private TextBox TB_FN;
        private Label L_Years;
        private Label L_Age;
        private Label L_Address;
        private Label L_Class;
        private Label L_DOP;
        private Label L_Gender;
        private Label L_LN;
        private Label L_FN;
        private Button B_Delete;
    }
}