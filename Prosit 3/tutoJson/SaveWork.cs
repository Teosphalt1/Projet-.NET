﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_load_json
{
    public class SaveWork
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public int id { get; set; }
        public string Name { get; set; }
        public string FileSource { get; set; }
        public string destPath { get; set; }
        public string time { get; set; }

    }
}
