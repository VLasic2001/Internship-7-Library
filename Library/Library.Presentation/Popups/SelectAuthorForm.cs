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

        private readonly AuthorRepository AuthorRepository = new AuthorRepository();

        public SelectAuthorForm(LibraryContext context)
        {
            InitializeComponent();
            SetupList();
        }

        public void SetupList()
        {
            AuthorRepository.GetAllAuthors().ForEach(author => AuthorsListBox.Items.Add(author));
        }
    }
}
