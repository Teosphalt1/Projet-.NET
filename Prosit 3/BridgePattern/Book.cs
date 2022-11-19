using BridgePattern.BookContentProviders;
using BridgePattern.BookPublishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Book : IBook
    {
        private readonly IBookContentProvider _contentProvider;
        private readonly IBookPublisher _publisher;

        public Book(IBookContentProvider contentProvider, IBookPublisher publisher)
        {
            _contentProvider = contentProvider;
            _publisher = publisher;
        }
        public void Publish()
        {
            IEnumerable<string> bookContent = _contentProvider.GetContent();

            Console.WriteLine("Saved boook content to database");
            _publisher.Publish(bookContent);
        }
    }
}
