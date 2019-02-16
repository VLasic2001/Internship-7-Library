﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}