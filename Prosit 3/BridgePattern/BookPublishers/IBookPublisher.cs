﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookPublishers
{
    public interface IBookPublisher
    {
        void Publish(IEnumerable<string> bookContent);
    }
}
