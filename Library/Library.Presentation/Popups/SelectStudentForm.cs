using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain;

namespace Library.Presentation.Popups
{
    public partial class SelectStudentForm : Form
    {
        private StudentRepository _studentRepository { get; set; }
        public Student Student { get; set; }

        public SelectStudentForm()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            _studentRepository = new StudentRepository();
            _studentRepository.GetAllStudents().ForEach(student => StudentsListBox.Items.Add(student));
            StudentClassComboBox.Items.Clear();
            StudentClassComboBox.Items.Add("");
            foreach (var studentClass in _studentRepository.GetAllStudents().GroupBy(student => student.Class).OrderBy(student => student.Key))
            {

                StudentClassComboBox.Items.Add(studentClass.Key);
            }

            StudentClassComboBox.SelectedIndex = 0;
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
                searchStudentsList = searchStudentsList.Where(student => student.Class == StudentClassComboBox.SelectedItem).ToList();
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

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Select(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"No student selected, please select a student and try again", @"No student selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Student = (Student)StudentsListBox.SelectedItem;
                Close();
            }
        }

        private void SelectedStudent(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItem == null) return;
            var selection = (Student)StudentsListBox.SelectedItem;
            if (selection.Loans.Count(loan => loan.IsLoanActive()) == 0) return;
            MessageBox.Show(@"Student already has an active loan", @"Cannot select student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            StudentsListBox.ClearSelected();
        }
    }
}
