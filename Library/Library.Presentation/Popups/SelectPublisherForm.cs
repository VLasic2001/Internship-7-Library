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
using Library.Data.Models;
using Library.Domain;

namespace Library.Presentation.Popups
{
    public partial class SelectPublisherForm : Form
    {
        private readonly PublisherRepository _publisherRepository = new PublisherRepository();
        public Publisher Publisher { get; set; }

        public SelectPublisherForm(LibraryContext context)
        {
            InitializeComponent();
            SetupList();
        }

        public void SetupList()
        {
            _publisherRepository.GetAllPublishers().ForEach(author => PublishersListBox.Items.Add(author));
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
                if (publisher.Name.Contains(NameTextBox.Text))
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

        private void Select(object sender, EventArgs e)
        {
            if (PublishersListBox.SelectedItem == null)
            {
                MessageBox.Show(@"No publisher selected, please select an author and try again", @"No publisher selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Publisher = (Publisher)PublishersListBox.SelectedItem;
                Close();
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

    }
}
