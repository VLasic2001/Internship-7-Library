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

namespace Library.Presentation.Popups
{
    public partial class SelectAuthorForm : Form
    {
        public LibraryContext Context { get; set; }
        private readonly AuthorRepository _authorRepository = new AuthorRepository();
        public Author Author { get; set; }

        public SelectAuthorForm(LibraryContext context)
        {
            InitializeComponent();
            Context = context;
            SetupList();
        }

        public void SetupList()
        {
            _authorRepository.GetAllAuthors().ForEach(author => AuthorsListBox.Items.Add(author));
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
                        if (author.LastName.Contains(LastNameTextBox.Text))
                        {
                            searchAuthorList.Add(author);
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
                    {
                        if (author.FirstName.Contains(FirstNameTextBox.Text))
                        {
                            searchAuthorList.Add(author);
                        }
                    }
                    else if (author.FirstName.Contains(FirstNameTextBox.Text) &&
                        author.LastName.Contains(LastNameTextBox.Text))
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

        private void Select(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"No author selected, please select an author and try again", @"No author selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Author = (Author)AuthorsListBox.SelectedItem;
                Close();
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
