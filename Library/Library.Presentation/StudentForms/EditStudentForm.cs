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
using Library.Data.Enums;
using Library.Infrastructure;

namespace Library.Presentation.StudentForms
{
    public partial class EditStudentForm : Form
    {
        private Student _student { get; set; }
        private LibraryContext _context { get; set; }

        public EditStudentForm(Student student)
        {
            InitializeComponent();
            _student = student;
            UpdateForm();
        }

        public void UpdateForm()
        {
            _context = new LibraryContext();
            GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            FirstNameTextBox.Text = _student.FirstName;
            LastNameTextBox.Text = _student.LastName;
            DateOfBirthDateTimePicker.Value = _student.DateOfBirth;
            GenderComboBox.SelectedItem = _student.Gender;
            ClassTextBox.Text = _student.Class;
        }

        public bool IsInCorrectFormat()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show(@"First name cannot be empty", @"First name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(LastNameTextBox.Text)) return true;
            MessageBox.Show(@"Last name cannot be empty", @"Last name empty", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;

        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            EditStudent();
            MessageBox.Show(@"Student successfully edited", @"Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        public void EditStudent()
        {
            _context.Students.Find(_student.StudentId).FirstName = FirstNameTextBox.Text.RemoveDoubleWhiteSpaces().UpperCaseFirstLetters();
            _context.Students.Find(_student.StudentId).LastName = LastNameTextBox.Text.RemoveDoubleWhiteSpaces().UpperCaseFirstLetters();
            _context.Students.Find(_student.StudentId).DateOfBirth = DateOfBirthDateTimePicker.Value;
            _context.Students.Find(_student.StudentId).Gender = (Gender)GenderComboBox.SelectedItem;
            _context.Students.Find(_student.StudentId).Class = ClassTextBox.Text;
            _context.SaveChanges();
        }
    }
}
