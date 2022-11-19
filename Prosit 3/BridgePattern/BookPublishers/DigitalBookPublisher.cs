using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookPublishers
{
    public class DigitalBookPublisher : IBookPublisher
    {
        public void Publish(IEnumerable<string> bookContent)
        {
            Console.WriteLine($"Successfully uploaded book to Amazon. (${bookContent.Count()} lines)");
        }
    }
}
