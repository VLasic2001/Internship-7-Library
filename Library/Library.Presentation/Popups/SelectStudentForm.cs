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
        }

        private void Search(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                StudentsListBox.Items.Clear();
                _studentRepository.GetAllStudents().ForEach(author => StudentsListBox.Items.Add(author));
            }
            else
            {
                var searchStudentsList = new List<Student>();
                foreach (var student in _studentRepository.GetAllStudents())
                {
                    if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
                    {
                        if (student.LastName.Contains(LastNameTextBox.Text))
                        {
                            searchStudentsList.Add(student);
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
                    {
                        if (student.FirstName.Contains(FirstNameTextBox.Text))
                        {
                            searchStudentsList.Add(student);
                        }
                    }
                    else if (student.FirstName.Contains(FirstNameTextBox.Text) &&
                             student.LastName.Contains(LastNameTextBox.Text))
                    {
                        searchStudentsList.Add(student);
                    }
                }

                if (searchStudentsList.Count == 0)
                {
                    MessageBox.Show(@"No students fit the search conditions", @"Invalid search term", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    StudentsListBox.Items.Clear();
                    searchStudentsList.ForEach(author => StudentsListBox.Items.Add(author));
                }
            }
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
    }
}
