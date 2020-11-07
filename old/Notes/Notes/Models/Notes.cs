using System;
using SQLite;

namespace Notes.Models
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime Original_Date { get; set; }
    }
}
