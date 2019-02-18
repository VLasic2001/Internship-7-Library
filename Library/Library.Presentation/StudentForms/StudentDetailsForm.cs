using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain;

namespace Library.Presentation.StudentForms
{
    public partial class StudentDetailsForm : Form
    {
        private Student _student { get; set; }
        private StudentRepository _studentRepository { get; set; }

        public StudentDetailsForm(Student student)
        {
            InitializeComponent();
            _student = student;
            UpdateForm();
        }

        public void UpdateForm()
        {
            _studentRepository = new StudentRepository();
            _student = _studentRepository.GetStudent(_student.StudentId);
            FirstNameLabel.Text = $"First Name: {_student.FirstName}";
            LastNameLabel.Text = $"Last Name: {_student.LastName}";
            DateOfBirthLabel.Text = $"Date Of Birth: {_student.DateOfBirth.ToShortDateString()}";
            GenderLabel.Text = $"Gender: {_student.Gender}";
            ClassLabel.Text = $"Class: {_student.Class}";
            NumberOfActiveLoansLabel.Text =
                $"Number Of Active Loans: {_student.Loans.Count(loan => loan.IsLoanActive())}";
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit(object sender, EventArgs e)
        {
            var editStudent = new EditStudentForm(_student);
            editStudent.ShowDialog();
            UpdateForm();
        }
    }
}
