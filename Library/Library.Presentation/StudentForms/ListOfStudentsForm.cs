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
            if (MessageBox.Show($@"Are you sure you want to delete {selection.FirstName} {selection.LastName} - {selection.Class}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
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
    }
}
