namespace Sample
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        private bool isAscending = true;
        public Form1(List<Student> studentsList = null)
        {
            InitializeComponent();
            students = studentsList ?? new List<Student>
            {
                new Student { FirstName = "Nisha", LastName = "Salvi", Gender = "Female", Age = "20 years", Class = "Graduate", DateOfBirth = new DateTime(2003, 5, 15), Address = "123 Main St" },
                new Student { FirstName = "Shivam", LastName = "Chauhan", Gender = "Male", Age = "18", Class = "1st year", DateOfBirth = new DateTime(2006, 9, 25), Address = "456 Elm St" }
            };
            InitializeDataGridView();
            InitializeSearchTextBox();

        }

        private void InitializeDataGridView()
        {
            StudentList.DataSource = students;
            StudentList.Columns["FirstName"].HeaderText = "First Name";
            StudentList.Columns["LastName"].HeaderText = "Last Name";
            StudentList.Columns["Gender"].HeaderText = "Gender";
            StudentList.Columns["Age"].HeaderText = "Age";
            StudentList.Columns["Class"].HeaderText = "Class";


            StudentList.Columns["DateOfBirth"].Visible = false;
            StudentList.Columns["Address"].Visible = false; // Initially hide the "Address" column


            StudentList.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            StudentList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            StudentList.EnableHeadersVisualStyles = false;

            StudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentList.DefaultCellStyle.SelectionBackColor = Color.Green;

            StudentList.RowHeaderMouseClick += StudentList_RowHeaderMouseClick;
            StudentList.ColumnHeaderMouseClick += StudentList_ColumnHeaderMouseClick;

            StudentList.CellDoubleClick += StudentList_CellDoubleClick;

        }

        private void StudentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the selected row
            DataGridViewRow row = StudentList.Rows[e.RowIndex];

            // Set the row's default cell style back color to green
            row.DefaultCellStyle.BackColor = Color.Green;

            // Optionally, you can clear the back color of all other rows
            foreach (DataGridViewRow r in StudentList.Rows)
            {
                if (r.Index != e.RowIndex)
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                }
            }


        }

        private void InitializeSearchTextBox()
        {
            // Assuming you have a TextBox named TB_Search on your form
            TB_Search.TextChanged += TB_Search_TextChanged;
        }

        private void StudentList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = StudentList.Columns[e.ColumnIndex].Name;
            students = isAscending ? students.OrderBy(s => GetPropertyValue(s, columnName)).ToList()
                                    : students.OrderByDescending(s => GetPropertyValue(s, columnName)).ToList();

            isAscending = !isAscending;

            RefreshGrid();
        }

        private object GetPropertyValue(Student student, string propertyName)
        {
            return typeof(Student).GetProperty(propertyName)?.GetValue(student, null);
        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = TB_Search.Text.ToLower();
            var filteredStudents = students.Where(s => s.FirstName.ToLower().Contains(searchText) ||
                                                       s.LastName.ToLower().Contains(searchText) ||
                                                       s.Gender.ToLower().Contains(searchText) ||
                                                       s.Age.ToLower().Contains(searchText) ||
                                                       s.Class.ToLower().Contains(searchText)).ToList();

            StudentList.DataSource = filteredStudents;
            StudentList.Columns["DateOfBirth"].Visible = false;
            StudentList.Columns["Address"].Visible = false;

        }


        private void StudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected student
                Student selectedStudent = students[e.RowIndex];

                // Open the Edit_Student form in edit mode
                Edit_Student editStudent = new Edit_Student(selectedStudent);
                if (editStudent.ShowDialog() == DialogResult.OK)
                {
                    if (editStudent.Deleted)
                    {
                        // Remove the student if it was deleted
                        RemoveStudent(selectedStudent);
                    }
                    else
                    {
                        // Update the DataGridView with the modified student list
                        RefreshGrid();

                    }
                }
            }
        }

        internal void RemoveStudent(Student student)
        {
            students.Remove(student);
            RefreshGrid();


        }


        internal void UpdateStudentsList(List<Student> studentEntries)
        {
            students.AddRange(studentEntries);
            RefreshGrid();

        }

        private void RefreshGrid()
        {
            StudentList.DataSource = null;
            StudentList.DataSource = students;
            StudentList.Columns["DateOfBirth"].Visible = false;
            StudentList.Columns["Address"].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B_Add_Click_1(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            if (add_Student.ShowDialog() == DialogResult.OK)
            {
                // Add the new student to the list
                students.Add(add_Student.NewStudent);
                RefreshGrid();
            }
        }
    }
}
