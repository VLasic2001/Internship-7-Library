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
            if (MessageBox.Show(selection.Books.Count>0 ? $@"Are you sure you want to delete {selection.FirstName} {selection.LastName}?" + "\n" + "Deleting the author will also delete all of the author's books" : $"Are you sure you want to delete {selection.FirstName} {selection.LastName}?", 
                    @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
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
            var authorDetails = new AuthorDetailsForm((Author)AuthorsListBox.SelectedItem);
            authorDetails.ShowDialog();
            UpdateList();
        }

        private void Edit(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the author you want to edit", @"No author selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var editAuthor = new EditAuthorForm((Author)AuthorsListBox.SelectedItem, _context);
            editAuthor.ShowDialog();
            UpdateList();
        }

        private void Search(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                AuthorsListBox.Items.Clear();
                _authorRepository.GetAllAuthors().ForEach(author => AuthorsListBox.Items.Add(author));
            }
            else
            {
                var searchAuthorList = new List<Author>();
                foreach (var author in _authorRepository.GetAllAuthors())
                {
                    if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
                    {
                        if (author.LastName.ToLower().Contains(LastNameTextBox.Text.ToLower()))
                        {
                            searchAuthorList.Add(author);
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
                    {
                        if (author.FirstName.ToLower().Contains(FirstNameTextBox.Text.ToLower()))
                        {
                            searchAuthorList.Add(author);
                        }
                    }
                    else if (author.FirstName.ToLower().Contains(FirstNameTextBox.Text.ToLower()) &&
                             author.LastName.ToLower().Contains(LastNameTextBox.Text.ToLower()))
                    {
                        searchAuthorList.Add(author);
                    }
                }

                if (searchAuthorList.Count == 0)
                {
                    MessageBox.Show(@"No authors fit the search conditions", @"Invalid search term", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AuthorsListBox.Items.Clear();
                    searchAuthorList.ForEach(author => AuthorsListBox.Items.Add(author));
                }
            }
        }
    }
}
