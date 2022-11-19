using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookContentProviders
{
    internal class AutobiographyBookContentProvider : IBookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>
            {
                "I was born.",
                "I learned to program",
                "I become an Enginer."
            };
        }
    }
}
