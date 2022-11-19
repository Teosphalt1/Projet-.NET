using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookContentProviders
{
    internal class SCIFIBookContentProvider : IBookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>
            {
                "Space Marine"
            };
        }
    }
}
