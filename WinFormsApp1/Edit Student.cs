using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Edit_Student : Form
    {
        private string errorMessage;

        internal Student UpdatedStudent { get; set; }
        internal bool Deleted { get; private set; } = false; // Add this line
        public Edit_Student(Student selectedStudent)
        {
            InitializeComponent();
            if (selectedStudent != null)
            {
                UpdatedStudent = selectedStudent;
                TB_FN.Text = selectedStudent.FirstName;
                TB_LN.Text = selectedStudent.LastName;
                CB_Gender.SelectedItem = selectedStudent.Gender;
                TB_Age.Text = selectedStudent.Age;
                TB_Class.Text = selectedStudent.Class;
                RTB_Address.Text = selectedStudent.Address.ToString(); // Convert Address to string

                // Ensure to set Date of Birth correctly, with a check for valid dates
                if (selectedStudent.DateOfBirth < DP_DOB.MinDate || selectedStudent.DateOfBirth > DP_DOB.MaxDate)
                {
                    DP_DOB.Value = DP_DOB.MinDate; // Set to minimum date if out of range
                }
                else
                {
                    DP_DOB.Value = selectedStudent.DateOfBirth;
                }
            }
            TB_FN.KeyPress += TB_FN_KeyPress;
            TB_LN.KeyPress += TB_LN_KeyPress;
            TB_Age.KeyPress += TB_Age_KeyPress;
            TB_Age.TextChanged += TB_Age_TextChanged;

        }


        private void BSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            // Validate First Name length
            if (TB_FN.Text.Length < 3)
            {
                errorMessage = "First Name should be at least 3 characters long";
                ShowErrorMessage(errorMessage, TB_FN);
                return; // Exit the method without proceeding further
            }
            ClearErrorMessage(TB_FN);

            // Validate Last Name length
            if (TB_LN.Text.Length < 2 || TB_LN.Text.Length > 18)
            {
                errorMessage = "Last Name should be between 2 and 18 characters long";
                ShowErrorMessage(errorMessage, TB_LN);
                return; // Exit the method without proceeding further
            }
            ClearErrorMessage(TB_LN);

            if (string.IsNullOrWhiteSpace(TB_FN.Text))
            {
                errorMessage = "First Name is required";
                ShowErrorMessage(errorMessage, TB_FN);
                return;
            }
            ClearErrorMessage(TB_FN);

            if (string.IsNullOrWhiteSpace(TB_LN.Text))
            {
                errorMessage = "Last Name is required";
                ShowErrorMessage(errorMessage, TB_LN);
                return;
            }
            ClearErrorMessage(TB_LN);


            if (!int.TryParse(TB_Age.Text, out int age))
            {
                errorMessage = "Date of Birth is required";
                ShowErrorMessage(errorMessage, TB_Age);
                return;
            }

            // Check age range
            if (age < 5 || age > 99)
            {
                errorMessage = "Age should be between 5 and 99 years";
                ShowErrorMessage(errorMessage, TB_Age);
                return;
            }


            // Clear error message if age is valid
            ClearErrorMessage(TB_Age);

            UpdatedStudent.FirstName = TB_FN.Text;
            UpdatedStudent.LastName = TB_LN.Text;
            UpdatedStudent.Gender = CB_Gender.SelectedItem.ToString();
            UpdatedStudent.Age = TB_Age.Text;
            UpdatedStudent.Class = TB_Class.Text;
            UpdatedStudent.Address = RTB_Address.Text.ToString();

            UpdatedStudent.DateOfBirth = DP_DOB.Value; // Ensure to update Date of Birth


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TB_FN_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow only letters, restrict input to a maximum of 15 characters
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                (TB_FN.Text.Length >= 15 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Suppress the key press if it's not a letter or control character
            }
        }

        private void TB_LN_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow only letters, restrict input to a maximum of 18 characters
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                (TB_LN.Text.Length >= 18 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Suppress the key press if it's not a letter or control character
            }
        }

        public void TB_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control characters like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press if it's not a digit or control character
            }

            // Check if backspace is pressed and the age text box is empty
            if (e.KeyChar == (char)Keys.Back && TB_Age.Text.Length == 1)
            {
                // Clear the Date of Birth field
                DP_DOB.CustomFormat = " ";
                DP_DOB.Text = ""; // Clear the text
            }

            // Check if the entered age would exceed 99 years
            if (TB_Age.Text.Length >= 2 && e.KeyChar != (char)Keys.Back)
            {
                int currentAge = int.Parse(TB_Age.Text + e.KeyChar);
                if (currentAge > 99)
                {
                    e.Handled = true; // Suppress the key press if the maximum age is reached
                }
            }

            // Validate the age when the user presses Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!int.TryParse(TB_Age.Text, out int age))
                {
                    errorMessage = "Invalid Age";
                    ShowErrorMessage(errorMessage, TB_Age);
                    return;
                }

                // Check age range
                if (age < 5 || age > 99)
                {
                    errorMessage = "Age should be between 5 and 99 years";
                    ShowErrorMessage(errorMessage, TB_Age);
                    return;
                }
            }
        }

        private bool ValidateData()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(TB_FN.Text))
            {
                errorMessage = "First Name is required";
                ShowErrorMessage(errorMessage, TB_FN);
                isValid = false;
            }
            else if (TB_FN.Text.Length < 3)
            {
                errorMessage = "First Name should be at least 3 characters long";
                ShowErrorMessage(errorMessage, TB_FN);
                isValid = false;
            }
            else
            {
                ClearErrorMessage(TB_FN);
            }

            // Check if Last Name is empty
            if (string.IsNullOrWhiteSpace(TB_LN.Text))
            {
                errorMessage = "Last Name is required";
                ShowErrorMessage(errorMessage, TB_LN);
                isValid = false;
            }
            else if (TB_LN.Text.Length < 2)
            {
                errorMessage = "Last Name should be at least 2 characters long";
                ShowErrorMessage(errorMessage, TB_LN);
                isValid = false;
            }
            else
            {
                ClearErrorMessage(TB_LN);
            }


            // Check if age is filled
            if (string.IsNullOrWhiteSpace(TB_Age.Text))
            {
                errorMessage = "Age is required";
                ShowErrorMessage(errorMessage, TB_Age);
                isValid = false;
            }
            else
            {
                // Clear error message if age is filled
                ClearErrorMessage(TB_Age);
            }

            if (CB_Gender.SelectedIndex == -1)
            {
                errorMessage = "Gender is required";
                ShowErrorMessage(errorMessage, CB_Gender);
                isValid = false;
            }
            else
            {
                // Clear error message if Gender is selected
                ClearErrorMessage(CB_Gender);
            }

            // Check if Date of Birth is selected
            if (DP_DOB.Value == null || DP_DOB.Value > DateTime.Today)
            {
                errorMessage = "Date of Birth is required";
                ShowErrorMessage(errorMessage, DP_DOB);
                isValid = false;
            }
            else
            {
                // Clear error message if Date of Birth is selected
                ClearErrorMessage(DP_DOB);
            }

            return isValid;
        }

        private void ShowErrorMessage(string? errorMessage, Control control)
        {
            if (control == null)
            {
                // Handle null control (optional)
                return;
            }

            // Create or update error label
            Label errorLabel = control.Tag as Label;
            if (errorLabel == null)
            {
                // Create new error label
                errorLabel = new Label
                {
                    AutoSize = true,
                    ForeColor = Color.Red
                };
                control.Tag = errorLabel; // Attach the error label to the control's Tag property
            }

            errorLabel.Text = errorMessage;

            // Set the position of error message label below the control
            errorLabel.Location = new Point(control.Left, control.Bottom + 5);

            // Add or update error label on the form
            if (!Controls.Contains(errorLabel))
            {
                Controls.Add(errorLabel);
            }
        }

        private void ClearErrorMessage(Control control)
        {
            if (control == null)
            {
                // Handle null control (optional)
                return;
            }

            // Find and remove error message label associated with the control
            Label errorLabel = control.Tag as Label;
            if (errorLabel != null && Controls.Contains(errorLabel))
            {
                Controls.Remove(errorLabel);
                control.Tag = null; // Clear the control's Tag property
            }
        }

        private void DP_DOB_ValueChanged(object? sender, EventArgs e)
        {
            // Set the format to display the selected date
            DP_DOB.CustomFormat = "dd/MM/yyyy";

            // Calculate age based on selected Date of Birth
            TimeSpan ageSpan = DateTime.Today - DP_DOB.Value;
            int age = ageSpan.Days / 365; // Approximate age in years

            // Update the value of the Age TextBox
            TB_Age.Text = age.ToString();
        }

        private void TB_Age_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TB_Age.Text, out int age))
            {
                if (age >= 5 && age <= 99)
                {
                    DateTime dob = DateTime.Today.AddYears(-age);
                    DP_DOB.ValueChanged -= DP_DOB_ValueChanged; // Temporarily remove the event handler to avoid recursive updates
                    DP_DOB.Value = dob;
                    DP_DOB.CustomFormat = "dd/MM/yyyy";
                    DP_DOB.ValueChanged += DP_DOB_ValueChanged; // Re-attach the event handler
                    ClearErrorMessage(TB_Age);
                }
                else
                {
                    errorMessage = "Age should be between 5 and 99 years";
                    ShowErrorMessage(errorMessage, TB_Age);
                }
            }
        }


        private void B_Delete_Click_1(object sender, EventArgs e)
        {

            // Show confirmation dialog
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this student records?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Mark as deleted
                Deleted = true;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void B_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
