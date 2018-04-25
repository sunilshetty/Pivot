using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BusinessEntities
{
    public class SPListCollection
    {
        public string MethodName { get; set; }
        public string SPName { get; set; }
        public string SPInputParameters { get; set; }
        public string ReturnParameters { get; set; }
    }

    public class SPList
    {
        public List<SPListCollection> SpListCollection { get; set; }
        public string JsonFIleName { get; set; }
    }
}
