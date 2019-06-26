﻿using System.Collections.Generic;

namespace role_searcher.Domains
{
    public class Group
    {        
        public GroupType GroupType { get; set; }
        
        public int Condo { get; set; }

        public List<KeyValuePair<string, Role>> Permissions { get; set; }
    }
}
