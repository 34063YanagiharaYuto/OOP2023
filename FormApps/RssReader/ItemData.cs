﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader {
    class ItemData {
        internal readonly object FirstAttribute;

        public string Title { get; set; }
        public string Link { get; set; }
        public string Xml { get; set; }
    }
}
