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
            if (MessageBox.Show(selection.Books.Count > 0 ? $@"Are you sure you want to delete {selection.Name}?" + "\n" + "Deleting the publisher will also delete all of the publisher's books" : $"Are you sure you want to delete {selection.Name}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
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
            if (PublishersListBox.SelectedItem == null)
            {
                MessageBox.Show(@"You must select the publisher you want to edit", @"No publisher selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var editPublisher = new EditPublisherForm((Publisher)PublishersListBox.SelectedItem, _context);
            editPublisher.ShowDialog();
            UpdateList();
        }

        private void Search(object sender, EventArgs e)
        {
            var searchPublisherList = new List<Publisher>();

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                PublishersListBox.Items.Clear();
                _publisherRepository.GetAllPublishers().ForEach(author => PublishersListBox.Items.Add(author));
            }

            foreach (var publisher in _publisherRepository.GetAllPublishers())
            {
                if (publisher.Name.ToLower().Contains(NameTextBox.Text.ToLower()))
                {
                    searchPublisherList.Add(publisher);
                }
            }
            if (searchPublisherList.Count == 0)
            {
                MessageBox.Show(@"No publishers fit the search conditions", @"Invalid search term", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                PublishersListBox.Items.Clear();
                searchPublisherList.ForEach(author => PublishersListBox.Items.Add(author));
            }

        }
    }
}
