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

namespace Library.Presentation.AuthorForms
{
    public partial class ListOfAuthorsForm : Form
    {
        private LibraryContext _context { get; set; }
        private AuthorRepository _authorRepository { get; set; }

        public ListOfAuthorsForm()
        {
            InitializeComponent();
            _context = new LibraryContext();
            UpdateList();
        }

        public void UpdateList()
        {
            _authorRepository = new AuthorRepository();
            AuthorsListBox.Items.Clear();
            _authorRepository.GetAllAuthors().ForEach(book => AuthorsListBox.Items.Add(book));
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the author you want to delete", @"No author selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selection = (Author)AuthorsListBox.SelectedItem;
            if (MessageBox.Show($@"Are you sure you want to delete {selection.FirstName} {selection.LastName}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            _authorRepository.DeleteAuthor(selection);
            UpdateList();
        }

        private void Details(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the author you want to see the details of", @"No author selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void Edit(object sender, EventArgs e)
        {

        }
    }
}
