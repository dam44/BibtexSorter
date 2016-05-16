using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibtexSorter
{
    class Reference
    {
        private String privRef;
        public String reference {
            get
            {
                return privRef;
            }
            set
            {
                privRef = value;
                Regex yourRegex = new Regex(@"(?<=title\s=\s\{\{)(.*)(?=\}\})");
                title = yourRegex.Match(privRef).Value;
            }
        }
        public String title { get; set; }

        public Reference(String reference)
        {
            this.reference = reference;
        }

        public override String ToString()
        {
            return title;
        }
    }
}
