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
using Library.Data.Enums;
using Library.Domain;

namespace Library.Presentation.StudentForms
{
    public partial class AddStudentForm : Form
    {
        private StudentRepository _studentRepository { get; set; }

        public AddStudentForm()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            SetupForm();
        }

        public void SetupForm()
        {
            GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            DateOfBirthDateTimePicker.Value = DateTime.Now;
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            _studentRepository.AddStudent(new Student(FirstNameTextBox.Text, LastNameTextBox.Text, DateOfBirthDateTimePicker.Value, (Gender)GenderComboBox.SelectedItem, ClassTextBox.Text));
            Close();
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
    }
}
