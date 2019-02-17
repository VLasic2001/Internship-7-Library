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
    }
}
