using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Shop.Models
{
    public class Book
    {
        public virtual int Number { get; set; }
        public virtual string Name { get; set; }
        public virtual string Author { get; set; }
        public virtual string Description { get; set; }
        public virtual string Category { get; set; }
        public virtual int Price { get; set; }

        public List<Book> ReadBooks(string dataPath) //deducted from the data file
        {
            var reader = new StreamReader(File.OpenRead(dataPath));
            reader.ReadLine();
            var books = new List<Book>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(';');
                    var book = new Book
                    {
                        Number = Convert.ToInt32(values[0]),
                        Name = values[1],
                        Author = values[2],
                        Description = values[3],
                        Category = values[4],
                        Price = Convert.ToInt32(values[5]),

                    };
                    books.Add(book);
                }

            }
            reader.Close();
            return books;


        }

    }

}