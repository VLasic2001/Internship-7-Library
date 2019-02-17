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
    }
}
