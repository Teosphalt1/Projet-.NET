using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookPublishers
{
    public class AudioBookPublisher : IBookPublisher
    {
        public void Publish(IEnumerable<string> bookContent)
        {
            Console.WriteLine($"Successfully uploaded book to Audible. (${bookContent.Count()} lines)");
        }
    }
}
