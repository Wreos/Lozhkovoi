using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;


namespace App1
{
    [Table ("Workers")]
    public class Worker
    {
        [PrimaryKey,AutoIncrement,Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Phone { get; set; }
        public double Hours { get; set; }
        public double Tarif { get; set; }
        public double Salary { get; set; }
        public double Salaryw { get; set; }

    }
}