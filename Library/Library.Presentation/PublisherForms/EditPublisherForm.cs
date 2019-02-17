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

namespace Library.Presentation.PublisherForms
{
    public partial class EditPublisherForm : Form
    {
        private Publisher _publisher { get; set; }
        private LibraryContext _context { get; set; }

        public EditPublisherForm(Publisher publisher, LibraryContext context)
        {
            InitializeComponent();
            _publisher = publisher;
            _context = context;
            UpdateForm();
        }

        public void UpdateForm()
        {
            NameTextBox.Text = _publisher.Name;
        }

        private void Save(object sender, EventArgs e)
        {
            if (!IsInCorrectFormat()) return;
            EditPublisher();
            MessageBox.Show(@"Publisher successfully edited", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public bool IsInCorrectFormat()
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text)) return true;
            MessageBox.Show(@"Name cannot be empty", @"Name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void EditPublisher()
        {
            _context.Publishers.Find(_publisher.PublisherId).Name = NameTextBox.Text;
            _context.SaveChanges();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
