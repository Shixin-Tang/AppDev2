using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        public string name { get; set; }
        public int pages { get; set; }
        public int publicationYear { get; set; }

        public Book(string name, int pages, int publicationYear)
        {
            this.name = name;
            this.pages = pages;
            this.publicationYear = publicationYear;
        }

        public override string ToString()
        {
            return $"Name: {name}, Pages: {pages}, Publication Year: {publicationYear}";
        }

        public string ToCsvString()
        {
            return $"\"{this.name}\",{this.pages},{this.publicationYear}";
        }

        public static Book FromCsvString(string csvLine)
        {
            string[] values = csvLine.Split(',');
            string name = values[0].Trim('\"');
            int pages = int.Parse(values[1]);
            int publicationYear = int.Parse(values[2]);
            return new Book(name, pages, publicationYear);
        }
    }
}
