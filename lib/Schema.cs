using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkoDB
{

    public class Schema
    {
        public string DataName { get; set; }
        public string CodeContent { get; set; }
        public string CodeLanguage { get; set; }
        public string GroupName { get; set; }
        public bool useTimeStamp { get; set; }
    }
}
