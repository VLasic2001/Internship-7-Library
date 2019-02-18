using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain;
using Library.Infrastructure;

namespace Library.Presentation.StudentForms
{
    public partial class ListOfStudentsForm : Form
    {
        private LibraryContext _context { get; set; }
        private StudentRepository _studentRepository { get; set; }

        public ListOfStudentsForm()
        {
            InitializeComponent();
            _context = new LibraryContext();
            UpdateList();
        }

        public void UpdateList()
        {
            _studentRepository = new StudentRepository();
            StudentsListBox.Items.Clear();
            _studentRepository.GetAllStudents().ForEach(book => StudentsListBox.Items.Add(book));
            StudentClassComboBox.Items.Clear();
            StudentClassComboBox.Items.Add("");
            foreach (var studentClass in _studentRepository.GetAllStudents().GroupBy(student => student.Class).OrderBy(student => student.Key))
            {
                
                StudentClassComboBox.Items.Add(studentClass.Key);
            }

            StudentClassComboBox.SelectedIndex = 0;
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the student you want to delete", @"No student selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selection = (Student)StudentsListBox.SelectedItem;
            if (MessageBox.Show(selection.Loans.Count > 0 ? $@"Are you sure you want to delete {selection.FirstName} {selection.LastName} - {selection.Class}?" + "\n" + "Deleting the student will also delete all of the student's loans" : $"Are you sure you want to delete {selection.FirstName} {selection.LastName} - {selection.Class}?",
                    @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            _studentRepository.DeleteStudent(selection);
            UpdateList();
        }

        private void Details(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the student you want to see the details of", @"No student selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var studentDetails = new StudentDetailsForm((Student)StudentsListBox.SelectedItem);
            studentDetails.ShowDialog();
            UpdateList();
        }

        private void Edit(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the student you want to edit", @"No student selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var editStudent = new EditStudentForm((Student)StudentsListBox.SelectedItem);
            editStudent.ShowDialog();
            UpdateList();
        }

        private void Search(object sender, EventArgs e)
        {
            var searchStudentsList = new List<Student>(_studentRepository.GetAllStudents());

            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                searchStudentsList = searchStudentsList.Where(student => student.FirstName.ToLower().Contains(FirstNameTextBox.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                searchStudentsList = searchStudentsList.Where(student => student.LastName.ToLower().Contains(LastNameTextBox.Text.ToLower())).ToList();
            }

            if (StudentClassComboBox.SelectedItem != "")
            {
                searchStudentsList = searchStudentsList.Where(student => student.Class == StudentClassComboBox.SelectedItem.ToString()).ToList();
            }

            if (searchStudentsList.Count == 0)
            {
                MessageBox.Show(@"Change the search inputs and try again", @"No student matches the search inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StudentsListBox.Items.Clear();
            if (searchStudentsList.Count == _studentRepository.GetAllStudents().Count)
            {
                _studentRepository.GetAllStudents().ForEach(student => StudentsListBox.Items.Add(student));
                return;
            }
            searchStudentsList.ForEach(student => StudentsListBox.Items.Add(student));
        }
    }
}
