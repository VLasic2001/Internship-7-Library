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
using Library.Data.Models;
using Library.Domain;

namespace Library.Presentation.PublisherForms
{
    public partial class AddPublisherForm : Form
    {
        private LibraryContext _context { get; set; }
        private PublisherRepository _publisherRepository { get; set; }

        public AddPublisherForm()
        {
            InitializeComponent();
            _context = new LibraryContext();
            _publisherRepository = new PublisherRepository();
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            CreateAndAddPublisher();
            MessageBox.Show(@"Publisher successfully added", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public bool IsInCorrectFormat()
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text)) return true;
            MessageBox.Show(@"Name cannot be empty", @"Name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void CreateAndAddPublisher()
        {
            _publisherRepository.AddPublisher(new Publisher(NameTextBox.Text));
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
