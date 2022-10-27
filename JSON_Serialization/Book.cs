using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Serialization
{
    internal class Book
    {
        public string Title { get; }
        public PublishingHouse PublishingHouse { get; }

        public Book(string title, PublishingHouse publishingHouse)
        {
            Title = title;
            PublishingHouse = publishingHouse;
        }   
    }
}
