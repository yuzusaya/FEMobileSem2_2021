using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
