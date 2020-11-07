using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;
namespace ukolnicek.Models
{
    
    public class Ukol
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime New_Date { get; set; }
        public DateTime Original_Date { get; set; }

    }
    
}