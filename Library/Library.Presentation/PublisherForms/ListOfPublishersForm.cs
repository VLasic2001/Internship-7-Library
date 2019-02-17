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
    public partial class ListOfPublishersForm : Form
    {
        private LibraryContext _context { get; set; }
        private PublisherRepository _publisherRepository { get; set; }

        public ListOfPublishersForm()
        {
            InitializeComponent();
            _context = new LibraryContext();
            UpdateList();
        }

        public void UpdateList()
        {
            _publisherRepository = new PublisherRepository();
            PublishersListBox.Items.Clear();
            _publisherRepository.GetAllPublishers().ForEach(publisher => PublishersListBox.Items.Add(publisher));
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete(object sender, EventArgs e)
        {
            if (PublishersListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the publisher you want to delete", @"No publisher selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selection = (Publisher)PublishersListBox.SelectedItem;
            if (MessageBox.Show($@"Are you sure you want to delete {selection.Name}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            _publisherRepository.DeletePublisher(selection);
            UpdateList();
        }

        private void Details(object sender, EventArgs e)
        {
            if (PublishersListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the publisher you want to see the details of", @"No publisher selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var publisherDetails = new PublisherDetailsForm((Publisher)PublishersListBox.SelectedItem);
            publisherDetails.ShowDialog();
            UpdateList();
        }

        private void Edit(object sender, EventArgs e)
        {
            var editPublisher = new EditPublisherForm((Publisher)PublishersListBox.SelectedItem, _context);
            editPublisher.ShowDialog();
            UpdateList();
        }
    }
}
