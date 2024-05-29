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
    public partial class Add_Student : Form
    {
        private Control control;
        private string errorMessage;
        private string message;
        public static List<Student> studentEntries = new List<Student>();

        public Student NewStudent { get; private set; } // Add this line
        public Add_Student()
        {
            InitializeComponent();
            DP_DOB.Format = DateTimePickerFormat.Custom;
            DP_DOB.CustomFormat = " ";



            // Attach event handlers
            DP_DOB.ValueChanged += DP_DOB_ValueChanged;
            TB_Age.TextChanged += TB_Age_TextChanged; // Add this line to handle age changes

            TB_FN.KeyPress += TB_FN_KeyPress;
            TB_LN.KeyPress += TB_LN_KeyPress;
            TB_Age.KeyPress += TB_Age_KeyPress;
            BSave.Click += BSave_Click;

            CB_Gender.GotFocus += RemovePlaceholder;
            CB_Gender.LostFocus += SetPlaceholder;

            RTB_Address.Enter += RemovePlaceholder;
            RTB_Address.Leave += SetPlaceholder;


            SetPlaceholder(CB_Gender, EventArgs.Empty);
            SetPlaceholder(RTB_Address, EventArgs.Empty);

        }

        private void TBAgeKeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control characters like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press if it's not a digit or control character
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
        }

        private void DP_DOB_ValueChanged(object sender, EventArgs e)
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

        private void TB_FN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, restrict input to a maximum of 15 characters
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                (TB_FN.Text.Length >= 15 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Suppress the key press if it's not a letter or control character
            }
        }

        private void TB_LN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, restrict input to a maximum of 18 characters
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                (TB_LN.Text.Length >= 18 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Suppress the key press if it's not a letter or control character
            }
        }


        private bool ValidateData()
        {
            bool isValid = true;

            // Check if first name is filled
            if (string.IsNullOrWhiteSpace(TB_FN.Text))
            {
                errorMessage = "First Name is required";
                ShowErrorMessage(errorMessage, TB_FN);
                isValid = false;
            }
            else
            {
                // Clear error message if first name is filled
                ClearErrorMessage(TB_FN);
            }

            // Check if last name is filled
            if (string.IsNullOrWhiteSpace(TB_LN.Text))
            {
                errorMessage = "Last Name is required";
                ShowErrorMessage(errorMessage, TB_LN);
                isValid = false;
            }
            else
            {
                // Clear error message if last name is filled
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

        private void ShowErrorMessage(string errorMessage, Control control)
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

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (sender == CB_Gender && CB_Gender.SelectedIndex == -1)
            {
                CB_Gender.Text = "Please Select Gender";
                CB_Gender.ForeColor = Color.Gray;
            }
            else if (sender == RTB_Address && string.IsNullOrWhiteSpace(RTB_Address.Text))
            {
                RTB_Address.Text = "Enter Address";
                RTB_Address.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (sender == CB_Gender && CB_Gender.Text == "Please Select Gender")
            {
                CB_Gender.Text = "";
                CB_Gender.ForeColor = Color.Black;
            }
            else if (sender == RTB_Address && RTB_Address.Text == "Enter Address")
            {
                RTB_Address.Text = "";
                RTB_Address.ForeColor = Color.Black;
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            // Validate data
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

            // Clear error message if Last Name is valid
            ClearErrorMessage(TB_LN);

            Student newStudent = new Student
            {
                FirstName = TB_FN.Text,
                LastName = TB_LN.Text,
                Gender = CB_Gender.SelectedItem.ToString(),
                Age = $"{TB_Age.Text} years",
                Class = TB_Class.Text,
                DateOfBirth = DP_DOB.Value, // Set DateOfBirth here
                Address = RTB_Address.Text // Capture the address entered by the user

            };

            // Check for duplicate student entry
            if (studentEntries.Any(s => s.FirstName == newStudent.FirstName && s.LastName == newStudent.LastName))
            {
                errorMessage = "Student with the same name already exists";
                ShowErrorMessage(errorMessage, TB_FN);
                return;
            }

            studentEntries.Add(newStudent);

            // Pass the new student back to Form1
            NewStudent = newStudent;

            // Close the form
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
