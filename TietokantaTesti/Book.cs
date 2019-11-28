using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TietokantaTesti
{
    class Book
    {
        public int Bookid { get; set; }
        public string Title { get; set; }
        public int Authorid { get; set; }
        public int Publisherid { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }

        public Book()
        {

        }

        public Book(int id, string title, int authorid, int publisherid, int pages, double price, DateTime date)
        {
            this.Bookid = id;
            this.Title = title;
            this.Authorid = authorid;
            this.Publisherid = publisherid;
            this.Pages = pages;
            this.Price = price;
            this.Date = date;
        }

        public override string ToString()
        {
            return this.Bookid + " " + this.Title + " " + this.Price;
        }
    }
}
